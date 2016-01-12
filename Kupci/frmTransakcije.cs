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
    public partial class frmTransakcije : Form
    {
        Upiti veza = new Upiti();
        DataTable podacikupci = new DataTable();
        DataTable podaciposlovnice = new DataTable();
        DataTable podacitransakcije = new DataTable();
        DataTable podacikartica = new DataTable();
        DataTable podacinositelj = new DataTable();

        string datumOD;
        string datumDO;
        string kupac,prezime,ime;

        public frmTransakcije()
        {
            InitializeComponent();
        }

        private void frmTransakcije_Load(object sender, EventArgs e)
        {
            
            try
            {
                veza.ExecuteQuery("select kup_brkart as 'Broj kartice', kup_sifrakar as 'Šifra kupca',CONCAT(kup_prezime ,' ', kup_ime) as 'Prezime i Ime' from kupci order by kup_prezime, kup_ime", ref podacikupci);
                
                if (podacikupci.Rows.Count > 0)
                {
                    glKupac.Properties.DisplayMember = "Prezime i Ime";
                    glKupac.Properties.ValueMember = "Broj kartice";
                    glKupac.Properties.DataSource = podacikupci;
                }

                veza.ExecuteQuery("SELECT po_sifra as 'Šifra',po_naziv as 'Naziv' from boso2011.poslovnica", ref podaciposlovnice);

                if (podaciposlovnice.Rows.Count > 0)
                {
                    glPoslovnica.Properties.DisplayMember = "Naziv";
                    glPoslovnica.Properties.ValueMember = "Šifra";
                    glPoslovnica.Properties.DataSource = podaciposlovnice;
                }

                dtOd.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
                dtDo.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTransakcije_KeyDown(object sender, KeyEventArgs e)
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

        private void dtOd_ValueChanged(object sender, EventArgs e)
        {
            dtOd.Format = DateTimePickerFormat.Short;
        }

        private void dtDo_ValueChanged(object sender, EventArgs e)
        {
            dtDo.Format = DateTimePickerFormat.Short;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            btnPrikazi.Enabled = false;
            lkupac.Text = "";
            
            if (txtKartica.Text != "")
            {
                veza.ExecuteQuery("SELECT kup_sifrakar from kupci where kup_brkart = '" + txtKartica.Text + "'", ref podacikartica);

                kupac = Convert.ToString(podacikartica.Rows[0][0]);

                veza.ExecuteQuery("SELECT kup_prezime,kup_ime from kupci where kup_sifrakar = '" + kupac + "' and kup_status='N'", ref podacinositelj);

                prezime = Convert.ToString(podacinositelj.Rows[0][0]);
                ime = Convert.ToString(podacinositelj.Rows[0][1]);

                lkupac.Text = "Nositelj: " + kupac + " " + prezime + " " + ime;

            }
            else if (glKupac.Text != "")
            {
                veza.ExecuteQuery("SELECT kup_sifrakar from kupci where kup_brkart = '" + glKupac.EditValue + "'", ref podacikartica);

                kupac = Convert.ToString(podacikartica.Rows[0][0]);

                veza.ExecuteQuery("SELECT kup_prezime,kup_ime from kupci where kup_sifrakar = '" + kupac + "' and kup_status='N'", ref podacinositelj);

                prezime = Convert.ToString(podacinositelj.Rows[0][0]);
                ime = Convert.ToString(podacinositelj.Rows[0][1]);

                lkupac.Text = "Nositelj: "+kupac+" "+prezime+" "+ime;

            }
           
            if (kupac != "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null)
            {                
                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.tra_broj,k.kup_brkart,t.po_sifra,p.po_naziv,tra_datum as " +
                                      "'datum',date_format(str_to_date(t.tra_danisat, '%Y%m%d%H%i'), '%H:%i') as 'vrijeme',t.tra_iznos from transakcije t, " +
                                      "kupci k, boso2011.poslovnica p where t.kupci_id_kupci = k.id_kupci and t.po_sifra=p.po_sifra and "+
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and k.kup_sifrakar = '" + kupac + "'", ref podacitransakcije);

                    if (podacitransakcije.Rows.Count > 0)
                    {
                        dgTransakcije.DataSource = podacitransakcije;
                    }
                }
                    
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnPrikazi.Enabled = true;
                }

            }
            else if (kupac != "" && glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null)
            {
                                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.tra_broj,k.kup_brkart,t.po_sifra,p.po_naziv,tra_datum " +
                                      "as 'datum',date_format(str_to_date(t.tra_danisat, '%Y%m%d%H%i'), '%H:%i') as 'vrijeme',t.tra_iznos from transakcije t, "+
                                      "kupci k,boso2011.poslovnica p where t.kupci_id_kupci = k.id_kupci and t.po_sifra=p.po_sifra "+
                                      "and tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and k.kup_sifrakar = '" + kupac + "' and t.po_sifra = '" + glPoslovnica.EditValue + "'", ref podacitransakcije);

                    if (podacitransakcije.Rows.Count > 0)
                    {
                        dgTransakcije.DataSource = podacitransakcije;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnPrikazi.Enabled = true;
                }

            }

            btnPrikazi.Enabled = true;
        }

        private void btnStavke_Click(object sender, EventArgs e)
        {
            if (dgrTransakcije.RowCount > 0)
            {
                try
                {
                    btnStavke.Enabled = false;
                    System.Data.DataRow row = dgrTransakcije.GetDataRow(dgrTransakcije.FocusedRowHandle);

                    if (row != null)
                    {
                        string IDtransakcija = row["tra_broj"].ToString();
                        string IDposlovnica = row["po_sifra"].ToString();


                        frmDetalji _frm;
                        foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
                        {
                            if (childForm.GetType() == typeof(frmDetalji))
                            {
                                childForm.Focus();
                                return;
                            }
                        }
                        _frm = new frmDetalji();

                        _frm.IDtransakcija = IDtransakcija;
                        _frm.IDposlovnica = IDposlovnica;
                        _frm.ShowDialog();
                    }

                    btnStavke.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnStavke.Enabled = false;
                }
            }
        }
    }
}
