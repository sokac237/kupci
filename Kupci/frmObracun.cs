using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kupci
{
    public partial class frmObracun : Form
    {
        Upiti veza = new Upiti();
        DataTable_ExportImport tekst_file = new DataTable_ExportImport();
        DataTable podaciobracun = new DataTable();
        DataTable podacitransakcije = new DataTable();
        DataTable podaciprovjera = new DataTable();
        DataTable podacikupci = new DataTable();
        DataTable podacistatus = new DataTable();
        DataTable podaciexport = new DataTable();

        string datum,datumod,datumdo,datumzadva,datumzamjesec;
        int broj;

        public frmObracun()
        {
            InitializeComponent();
        }

        private void frmObracun_Load(object sender, EventArgs e)
        {
            
            try
            {
                veza.ExecuteQuery(@"select ob_broj as 'Broj', ob_datum as 'Datum', ob_datumizrade as 'Datum izrade', ob_vrijeme as 'Vrijeme' 
                                    from obracun order by 1", ref podaciobracun);
                
                if (podaciobracun.Rows.Count > 0)
                {
                    dgTransakcije.DataSource = podaciobracun;    
                }


                DateTime now = DateTime.Now;

                DateTime lastDayLastMonth = new DateTime(now.Year, now.Month, 1);
                lastDayLastMonth = lastDayLastMonth.AddDays(-1);

                dtDo.Value = lastDayLastMonth;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmObracun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        
        private void dtDo_ValueChanged(object sender, EventArgs e)
        {
            dtDo.Format = DateTimePickerFormat.Short;
        }


        private void btnObradi_Click(object sender, EventArgs e)
        {
            if (Global.KorisnikID == "1967")
            {
                DialogResult result;
                result = MessageBox.Show("Da li ste sigurni ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    btnObradi.Enabled = false;

                    try
                    {
                        datum = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd");
                        datumdo = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                        veza.ExecuteQuery("SELECT ob_broj from obracun where ob_datum = '" + datumdo + "' ", ref podaciprovjera);

                        if (podaciprovjera.Rows.Count > 0)
                        {
                            MessageBox.Show("Obračun za taj mjesec već postoji !!!");
                            btnObradi.Enabled = true;
                            return;
                        }

                        //određivanje broja obračuna
                        DataTable brojobracuna = new DataTable();

                        veza.ExecuteQuery("select max(convert(substring_index(ob_broj, '.', -1), unsigned)) as maksimalni from obracun", ref brojobracuna);
                        if (brojobracuna.Rows.Count <= 0)
                        {
                            broj = 1;
                        }
                        else
                        {
                            broj = Convert.ToInt32(brojobracuna.Rows[0][0]) + 1;
                        }

                        //MessageBox.Show("Broj obračuna je: " + Convert.ToString(broj));

                        //određivanje praga popusta
                        veza.ExecuteQuery("select st_prag from statkar where st_sifra='02'", ref podacistatus);
                        double prag = Convert.ToDouble(podacistatus.Rows[0][0]);


                        DateTime prvidanumjesecu = new DateTime(dtDo.Value.Year, dtDo.Value.Month, 1);
                        datumod = Convert.ToDateTime(prvidanumjesecu).ToString("yyyyMMdd");

                        DateTime zadvadana = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                        zadvadana = zadvadana.AddDays(2);
                        datumzadva = Convert.ToDateTime(zadvadana).ToString("yyyyMMdd");
                        string vrijeme = DateTime.Now.ToShortTimeString();
                        //DateTime zamjesec = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 2);
                        DateTime ovajmjesec = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 2);
                        DateTime zamjesec = ovajmjesec.Date.AddDays(31);
                        datumzamjesec = Convert.ToDateTime(zamjesec).ToString("yyyyMMdd");

                        //MessageBox.Show("Datum od: " + datumod + " do: " + datumdo + " za dva dana: " + datumzadva);
                        
                        // dodajem novi obračun    
                        veza.ExecuteQuery("INSERT INTO obracun (ob_broj,ob_datum,ob_datumizrade,ob_vrijeme,dj_sifra) " +
                                          "VALUES ('" + broj + "','" + datumdo + "','" + datum + "','" + vrijeme + "',1)");
                        // ubacujem broj obračuna u transakcije
                        veza.ExecuteQuery("update transakcije " +
                                          "set obracun_ob_broj = '" + broj + "' where tra_datum>='" + datumod + "' " +
                                          "and tra_datum<='" + datumdo + "' ");

                        veza.ExecuteQuery("select kupci_id_kupci1, sum(tra_iznos) as 'suma' from transakcije where obracun_ob_broj = '" + broj + "' "+
                                          "and (kupci_statkar_st_sifra1='00' or kupci_statkar_st_sifra1='02') " +  
                                          "group by 1", ref podacitransakcije);

                        veza.PocniTransakciju();

                        // stavi sve 02 kartice na 00
                        veza.ExecuteQuery("update kupci " +
                                           "set statkar_st_sifra = '00' ,kup_prag = 0 " +
                                           "where statkar_st_sifra = '02' and kup_datpop < '" + datumzamjesec + "'");

                        foreach (DataRow dr in podacitransakcije.Rows)
                        {
                            int kupac = Convert.ToInt32(dr["kupci_id_kupci1"].ToString());
                            double suma = Convert.ToDouble(dr["suma"].ToString());

                            //traženje broja kupca
                            veza.ExecuteQuery("select kup_sifrakar from kupci where id_kupci = '" + kupac + "'", ref podacikupci);

                            if (podacikupci.Rows.Count > 0)
                            {
                                string sifrakar = Convert.ToString(podacikupci.Rows[0][0]);
                                
                                // provjera da li je kupac ostvario popust
                                string zbir = Convert.ToString(suma).Replace(',', '.');

                                if (suma >= prag)
                                {
                                    veza.ExecuteQuery("update kupci " +
                                                      "set statkar_st_sifra = '02' ,kup_datpop = '" + datumzamjesec + "',kup_saldo = kup_saldo + '" + zbir + "' " +
                                                      ",kup_prag = 0 " +
                                                      "where kup_sifrakar = '" + sifrakar + "' and statkar_st_sifra <> '04' ");

                                }
                                else
                                {
                                    veza.ExecuteQuery("update kupci " +
                                                      "set statkar_st_sifra = '00' ,kup_saldo = kup_saldo + '" + zbir + "' ,kup_prag = 0 " +
                                                      "where kup_sifrakar = '" + sifrakar + "' and statkar_st_sifra <> '04' and kup_datpop < '" + datumzamjesec + "'");
                                }
                            }


                        }

                        veza.ZavrsiTransakciju();

                        veza.ExecuteQuery(@"select ob_broj as 'Broj', ob_datum as 'Datum', ob_datumizrade as 'Datum izrade', ob_vrijeme as 'Vrijeme' 
                                    from obracun order by 1", ref podaciobracun);

                        if (podaciobracun.Rows.Count > 0)
                        {
                            dgTransakcije.DataSource = podaciobracun;
                        }


                    }
                    catch (Exception ex)
                    {
                        veza.VratiTransakciju();
                        MessageBox.Show(ex.Message);
                    }






//                    stara verzija
//                    try
//                    {
//                        datum = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd");
//                        datumdo = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

//                        veza.ExecuteQuery("SELECT ob_broj from obracun where ob_datum = '" + datumdo + "' ", ref podaciprovjera);

//                        if (podaciprovjera.Rows.Count > 0)
//                        {
//                            MessageBox.Show("Obračun za taj mjesec već postoji !!!");
//                            btnObradi.Enabled = true;
//                            return;
//                        }

//                        //određivanje broja obračuna
//                        DataTable brojobracuna = new DataTable();

//                        veza.ExecuteQuery("select max(convert(substring_index(ob_broj, '.', -1), unsigned)) as maksimalni from obracun", ref brojobracuna);
//                        if (brojobracuna.Rows.Count <= 0)
//                        {
//                            broj = 1;
//                        }
//                        else
//                        {
//                            broj = Convert.ToInt32(brojobracuna.Rows[0][0]) + 1;
//                        }

//                        //MessageBox.Show("Broj obračuna je: " + Convert.ToString(broj));

//                        //određivanje praga popusta
//                        veza.ExecuteQuery("select st_prag from statkar where st_sifra='02'", ref podacistatus);
//                        double prag = Convert.ToDouble(podacistatus.Rows[0][0]);


//                        DateTime prvidanumjesecu = new DateTime(dtDo.Value.Year, dtDo.Value.Month, 1);
//                        datumod = Convert.ToDateTime(prvidanumjesecu).ToString("yyyyMMdd");

//                        DateTime zadvadana = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
//                        zadvadana = zadvadana.AddDays(2);
//                        datumzadva = Convert.ToDateTime(zadvadana).ToString("yyyyMMdd");
//                        string vrijeme = DateTime.Now.ToShortTimeString();
//                        DateTime zamjesec = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 2);
//                        datumzamjesec = Convert.ToDateTime(zamjesec).ToString("yyyyMMdd");

//                        //MessageBox.Show("Datum od: " + datumod + " do: " + datumdo + " za dva dana: " + datumzadva);
                                                
//                        veza.ExecuteQuery("INSERT INTO obracun (ob_broj,ob_datum,ob_datumizrade,ob_vrijeme,dj_sifra) " +
//                                          "VALUES ('" + broj + "','" + datumdo + "','" + datum + "','" + vrijeme + "',1)");

//                        veza.PocniTransakciju();

//                        veza.ExecuteQuery("select id_kupci from kupci where (statkar_st_sifra='00' or statkar_st_sifra='02') and kup_datpop <= '" + datumzadva + "' ", ref podacikupci);

//                        foreach (DataRow dr in podacikupci.Rows)
//                        {
//                            int kupac = Convert.ToInt32(dr["id_kupci"].ToString());
//                            double suma = 0;

//                            veza.ExecuteQuery("select id_transakcije, tra_iznos from transakcije where kupci_id_kupci = '" + kupac + "' and "+
//                                              "str_to_date(tra_danisat, '%Y%m%d')>='" + datumod + "' and str_to_date(tra_danisat, '%Y%m%d')<='" + datumdo + "' "+
//                                              "and obracun_ob_broj is null", ref podacitransakcije);

//                            foreach (DataRow drtr in podacitransakcije.Rows)
//                            {
//                                double iznos = Convert.ToDouble(drtr["tra_iznos"].ToString());
//                                suma = suma + iznos;

//                                int transakcija = Convert.ToInt32(drtr["id_transakcije"].ToString());

//                                veza.ExecuteQuery("update transakcije " +
//                                                  "set obracun_ob_broj = '" + broj + "' where kupci_id_kupci = '" + kupac + "' " +
//                                                  "and id_transakcije = '" + transakcija + "' and obracun_ob_broj is null");

//                            }

//                            //MessageBox.Show("Iznos: " + suma);

//                            // provjera da li je kupac ostvario popust
//                            string zbir = Convert.ToString(suma).Replace(',', '.');

//                            if (suma >= prag)
//                            {
//                                veza.ExecuteQuery("update kupci " +
//                                                  "set statkar_st_sifra = '02' ,kup_datpop = '" + datumzamjesec + "',kup_saldo = kup_saldo + '" + zbir + "' " +
//                                                  ",kup_prag = 0 " +
//                                                  "where id_kupci = '" + kupac + "' ");

//                            }
//                            else
//                            {
//                                veza.ExecuteQuery("update kupci " +
//                                                  "set statkar_st_sifra = '00' ,kup_saldo = kup_saldo + '" + zbir + "' ,kup_prag = 0 " +
//                                                  "where id_kupci = '" + kupac + "' ");
//                            }

//                        }

//                        veza.ZavrsiTransakciju();

//                        veza.ExecuteQuery(@"select ob_broj as 'Broj', ob_datum as 'Datum', ob_datumizrade as 'Datum izrade', ob_vrijeme as 'Vrijeme' 
//                                    from obracun order by 1", ref podaciobracun);

//                        if (podaciobracun.Rows.Count > 0)
//                        {
//                            dgTransakcije.DataSource = podaciobracun;
//                        }


//                    }
//                    catch (Exception ex)
//                    {
//                        veza.VratiTransakciju();
//                        MessageBox.Show(ex.Message);
//                    }

                }
                else
                {
                    return;
                }

                btnObradi.Enabled = true;
            }

        }

        private void btnPriprema_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Da li ste sigurni ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                btnPriprema.Enabled = false;

                try
                {
                    veza.ExecuteQuery(@"SELECT kup_brkart, kup_sifrakar, statkar_ST_SIFRA, kup_prezime, kup_ime, kup_jmbg, kup_oib, kup_mjesto, kup_posta,
                                        kup_adresa, kup_telefon1, kup_telefon2, kup_telefon3, kup_fax, kup_siffir, 
                                        kup_danob1,kup_danob2,DATE_FORMAT(kup_dankar, '%Y%m%d'),
                                        DATE_FORMAT(kup_vazido, '%Y%m%d'), kup_status, 
					                    DATE_FORMAT(kup_rodjendan, '%Y.%m.%d'), kup_limkar,
                                        kup_saldo, kup_kumtro, kup_prag, 
					                    DATE_FORMAT(kup_datpop, '%Y.%m.%d'), kup_preporuka, kup_kucanstvo,
                                        po_sifra,  if(kup_umirovljenik=1,1,0), kup_pokrodjen  FROM kupci", ref podaciexport);
                    

                    tekst_file.ExportDataTabletoFile(podaciexport, ";", false, "T:\\KARTICE\\kupci.txt");
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                return;
            }

            btnPriprema.Enabled = true;
        
        }
    }
}
