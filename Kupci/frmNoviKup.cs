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
    public partial class frmNoviKup : Form
    {
        Upiti veza = new Upiti();
        Provjera brojoiba = new Provjera();
        string sifra,status;
        string rjesenjeModulo;
        int karticaID,sms,umirovljenik;
        string barkod, datpop, rodjendan;
        DataTable podaciposlovnice = new DataTable();
        
        public frmNoviKup()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmNoviKup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            //if (e.KeyCode == Keys.Delete)
            //{
            //    DevExpress.XtraEditors.GridLookUpEdit lista = (DevExpress.XtraEditors.GridLookUpEdit)ActiveControl;

            //    if (lista != null)
            //    {
            //        lista.EditValue = null;
            //    }

            //}
        }

       
        private void frmNoviKup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mpmanDataSet.kupci' table. You can move, or remove it, as needed.
            //this.kupciTableAdapter.Fill(this.mpmanDataSet.kupci);
            // TODO: This line of code loads data into the 'mpmanDataSet.statkar' table. You can move, or remove it, as needed.
            this.statkarTableAdapter1.Fill(this.mpmanDataSet.statkar);
            try
            {
                veza.ExecuteQuery("SELECT po_sifra as 'Šifra',po_naziv as 'Naziv' from boso2011.poslovnica", ref podaciposlovnice);

                if (podaciposlovnice.Rows.Count > 0)
                {
                    glPoslovnica.Properties.DisplayMember = "Naziv";
                    glPoslovnica.Properties.ValueMember = "Šifra";
                    glPoslovnica.Properties.DataSource = podaciposlovnice;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (brojoiba.CheckOIB(txtOIB.Text) == false)
            {
                MessageBox.Show("Neispravan OIB !!!");
                //txtOIB.Focus();
                //return;
            }

            //provjera da li postoji oib u bazi
            if (txtOIB.Text != "")
            {
                DataTable KupciOib = new DataTable();

                veza.ExecuteQuery("select kup_brkart from kupci where kup_oib=" + txtOIB.Text + "", ref KupciOib);
                if (KupciOib.Rows.Count > 0)
                {
                    MessageBox.Show("OIB već postoji !!!");
                    txtOIB.Focus();
                    return;
                }
            }
            
            if (txtIme.Text != "" && txtPrezime.Text != "" && glStatus.Text != "" && dtDatumR.Value != null && txtMjesto.Text != "" && txtAdresa.Text != "")
            {
                
                try
                {
                    btnSpremi.Enabled = false;
                    DialogResult result;
                    
                    result = MessageBox.Show("Želite spremiti novog korisnika?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        
                        //određivanje šifre kartice
                        DataTable KupciSifra = new DataTable();

                        veza.ExecuteQuery("select max(convert(substring_index(kup_sifrakar, '.', -1), unsigned)) as maksimalni from kupci", ref KupciSifra);
                        if (KupciSifra.Rows.Count <= 0)
                        {
                            sifra = "100001";
                        }
                        else
                        {
                            sifra = Convert.ToString(Convert.ToInt32(KupciSifra.Rows[0][0])+1);    
                        }

                        izracunajBarkod();
                                               

                        if (cbsms.Checked)
                        {
                            sms = 1;
                        }
                        else
                        {
                            sms = 0;
                        }

                        if (cbumirovljenik.Checked)
                        {
                            umirovljenik = 1;
                        }
                        else
                        {
                            umirovljenik = 0;
                        }
                        DateTime ovajmjesec = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 2);
                        DateTime zamjesec = ovajmjesec.Date.AddDays(61);
                        DateTime zagodinu = new DateTime(DateTime.Now.Year + 1, 1, 2);
                        status = glStatus.EditValue.ToString();

                        if (status == "05" || status == "01" || status == "06" || status == "04")
                        {
                            datpop = Convert.ToDateTime(zagodinu).ToString("yyyyMMdd");
                        }
                        else
                        {
                            datpop = Convert.ToDateTime(zamjesec).ToString("yyyyMMdd");
                        }
                       
                        rodjendan = Convert.ToDateTime(dtDatumR.Value).ToString("yyyyMMdd");

                        veza.ExecuteQuery("INSERT INTO kupci (kup_sifrakar,kup_brkart,kup_ime,kup_prezime,kup_oib,statkar_ST_SIFRA,kup_rodjendan,kup_mjesto,"+
                                          "kup_adresa,kup_telefon1,kup_telefon2,kup_email,kup_sms,kup_status,kup_datpop,po_sifra,kup_umirovljenik,kup_spol,"+
                                          "kup_posta,kup_siffir,kup_napomena) " +
                                          "VALUES ('" + sifra + "','" + barkod + "','" + txtIme.Text + "','" + txtPrezime.Text + "','" + txtOIB.Text + "',"+
                                          "'" + glStatus.EditValue.ToString() + "','" + rodjendan + "','" + txtMjesto.Text + "','" + txtAdresa.Text + "'," +
                                          "'" + txtTelefon.Text + "','" + txtMobitel.Text + "','" + txtEmail.Text + "','" + sms + "','N','" + datpop + "',"+
                                          "'" + glPoslovnica.EditValue.ToString() + "','" + umirovljenik + "','" + txtSpol.Text + "','" + txtPosta.Text + "',"+
                                          "'" + txtFirma.Text + "','" + txtNapomena.Text + "' )");
                       
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnSpremi.Enabled = true;
                }

                this.DialogResult = DialogResult.OK;
                this.Close(); 
                
                
            }
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            btnPrenesi.Enabled = false;
            frmZahtjevi _frm;
            foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmZahtjevi))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmZahtjevi();
            

            DialogResult res = _frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                txtIme.Text = _frm.ime;
                txtPrezime.Text = _frm.prezime;
                txtOIB.Text = _frm.oib;
                glStatus.EditValue = _frm.status;
                dtDatumR.Value = DateTime.Parse(_frm.datumr);
                txtMjesto.Text = _frm.mjesto;
                txtAdresa.Text = _frm.adresa;
                txtTelefon.Text = _frm.telefon;
                txtMobitel.Text = _frm.mobitel;
                txtNapomena.Text = _frm.napomena;
                txtSpol.Text = _frm.spol;
                txtEmail.Text = _frm.email;
                if (_frm.sms == 1)
                {
                    cbsms.Checked = true;
                }
                else
                {
                    cbsms.Checked = false;
                }
                glPoslovnica.EditValue = _frm.po_sifra;
                if (_frm.umirovljenik == 1)
                {
                    cbumirovljenik.Checked = true;
                }
                else
                {
                    cbumirovljenik.Checked = false;
                }
            }
           
            DataTable Posta = new DataTable();

            veza.ExecuteQuery("select mj_posta from boso2011.mjesto where mj_naziv = '" + txtMjesto.Text + "' ", ref Posta);
            if (Posta.Rows.Count > 0)
            {
                txtPosta.Text = Posta.Rows[0][0].ToString();
            }

            btnPrenesi.Enabled = true;
            btnPrenesi.Focus();
        }

        public string Modulo_11(string izraz)
        {
            string result;
            if (izraz != izraz.ToString())
            {
                izraz = izraz.ToString().Trim();
            }
            else
            {
                izraz.Trim();
            }

            int Modul_11_ZBROJ = 0;
            int ponder = 1;
            int i;

            for (i = izraz.Length - 1; i >= 0; i--)
            {
                ponder++;
                Modul_11_ZBROJ = Modul_11_ZBROJ + Convert.ToInt32(izraz.Substring(i, 1)) * ponder;
            }

            int ostatak;

            ostatak = Modul_11_ZBROJ - 11 * (Modul_11_ZBROJ / 11);


            int Modul_11_KONTROL = 11 - ostatak;

            if (Modul_11_KONTROL >= 10)
            {
                rjesenjeModulo = Convert.ToString(0);
                return result = Convert.ToString(0);
            }
            else
            {
                rjesenjeModulo = Modul_11_KONTROL.ToString().Trim();
                return result = Modul_11_KONTROL.ToString().Trim();
            }
        }

        public string Modulo_EAN(string izraz)
        {
            string result2;
            decimal j = 0;
            if (izraz != izraz.ToString())
            {
                izraz = izraz.ToString().Trim();
            }
            else
            {
                izraz.Trim();
            }

            int Modul_EAN_ZBROJ = 0;
            int i;
            for (i = izraz.Length - 1; i >= 0; i--)
            {
                j++;

                decimal a = j / 2;
                if (j / 2 == Math.Truncate(Convert.ToDecimal(j / 2)))
                {
                    Modul_EAN_ZBROJ = Modul_EAN_ZBROJ + Convert.ToInt32(izraz.Substring(i, 1));
                }
                else
                {
                    Modul_EAN_ZBROJ = Modul_EAN_ZBROJ + Convert.ToInt32(izraz.Substring(i, 1)) * 3;
                }
            }

            int dodatak;
            dodatak = 10 + (10 * (Modul_EAN_ZBROJ / 10));

            int Modul_EAN_KONTROL = dodatak - Modul_EAN_ZBROJ;

            if (Modul_EAN_KONTROL == 10)
            {
                return result2 = Convert.ToString(0); ;
            }
            else
            {
                return result2 = Modul_EAN_KONTROL.ToString().Trim();
            }
        }

        private void izracunajBarkod()
        {
            //racunanje barkod

            try
            {
                karticaID = Convert.ToInt32(sifra);
                int pocetak = karticaID;
                string izraz = Convert.ToString(pocetak);

                barkod = pocetak + Modulo_11(izraz) + Modulo_EAN(izraz + rjesenjeModulo);
                               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtDatumR_ValueChanged(object sender, EventArgs e)
        {
            dtDatumR.Format = DateTimePickerFormat.Short;
        }

        private void dtDatumR_Enter(object sender, EventArgs e)
        {
            if (dtDatumR.Text == " ")
            {
                dtDatumR.Value = DateTime.Now;
            }
        }

        private void txtMjesto_Leave(object sender, EventArgs e)
        {
            DataTable Posta = new DataTable();

            veza.ExecuteQuery("select mj_posta from boso2011.mjesto where mj_naziv = '" + txtMjesto.Text + "' ", ref Posta);
            if (Posta.Rows.Count > 0)
            {
                txtPosta.Text = Posta.Rows[0][0].ToString();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
       
    }
}
