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
    public partial class frmRangLista : Form
    {
        Upiti veza = new Upiti();
        DataTable podacikupci = new DataTable();
        DataTable podaciposlovnice = new DataTable();
        DataTable podacitransakcije = new DataTable();
        
        string datumOD;
        string datumDO;
               
        public frmRangLista()
        {
            InitializeComponent();
        }

        private void frmRangLista_Load(object sender, EventArgs e)
        {
            
            try
            {
                veza.ExecuteQuery("SELECT st_sifra as 'Šifra',st_naziv as 'Naziv' from statkar", ref podacikupci);

                if (podacikupci.Rows.Count > 0)
                {
                    glStatus.Properties.DisplayMember = "Naziv";
                    glStatus.Properties.ValueMember = "Šifra";
                    glStatus.Properties.DataSource = podacikupci;
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

        private void frmRangLista_KeyDown(object sender, KeyEventArgs e)
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

            if (glStatus.Text != "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null && cboib.Checked == false && cbiznos.Checked == false)
            {                
                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +  
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and " +
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.kupci_statkar_ST_SIFRA1 = '" + glStatus.EditValue + "' group by 1,2,3,4,5,6 order by suma desc", ref podacitransakcije);

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
            else if (glStatus.Text != "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null && cboib.Checked == false && cbiznos.Checked == true)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and " +
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.kupci_statkar_ST_SIFRA1 = '" + glStatus.EditValue + "' group by 1,2,3,4,5,6 "+
                                      "having sum(t.tra_iznos)>='" + txtIznosOd.Text + "' and sum(t.tra_iznos)<='" + txtIznosDo.Text + "' order by suma desc", ref podacitransakcije);

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
            else if (glStatus.Text != "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null && cboib.Checked == true && cbiznos.Checked == false)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and k.kup_oib<>'' and " +
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.kupci_statkar_ST_SIFRA1 = '" + glStatus.EditValue + "' group by 1,2,3,4,5,6 order by suma desc", ref podacitransakcije);

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
            else if (glStatus.Text != "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null && cboib.Checked == true && cbiznos.Checked == true)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and k.kup_oib<>'' and " +
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.kupci_statkar_ST_SIFRA1 = '" + glStatus.EditValue + "' group by 1,2,3,4,5,6 "+
                                      "having sum(t.tra_iznos)>='" + txtIznosOd.Text + "' and sum(t.tra_iznos)<='" + txtIznosDo.Text + "' order by suma desc", ref podacitransakcije);

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
            else if (glStatus.Text != "" && glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null && cbiznos.Checked == false)
            {
                                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and "+
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.kupci_statkar_ST_SIFRA1 = '" + glStatus.EditValue + "' and t.po_sifra = '" + glPoslovnica.EditValue + "' "+
                                      "group by 1,2,3,4,5,6 order by suma desc", ref podacitransakcije);
                    
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
            else if (glStatus.Text != "" && glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null && cbiznos.Checked == true)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and " +
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.kupci_statkar_ST_SIFRA1 = '" + glStatus.EditValue + "' and t.po_sifra = '" + glPoslovnica.EditValue + "' " +
                                      "group by 1,2,3,4,5,6 "+
                                      "having sum(t.tra_iznos)>='" + txtIznosOd.Text + "' and sum(t.tra_iznos)<='" + txtIznosDo.Text + "' order by suma desc", ref podacitransakcije);

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
            else if (glStatus.Text == "" && glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null && cbiznos.Checked == false)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and "+
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.po_sifra = '" + glPoslovnica.EditValue + "' group by 1,2,3,4,5,6 order by suma desc", ref podacitransakcije);
                    
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
            else if (glStatus.Text == "" && glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null && cbiznos.Checked == true)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and "+
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "and t.po_sifra = '" + glPoslovnica.EditValue + "' group by 1,2,3,4,5,6 "+
                                      "having sum(t.tra_iznos)>='" + txtIznosOd.Text + "' and sum(t.tra_iznos)<='" + txtIznosDo.Text + "' order by suma desc", ref podacitransakcije);
                    
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
            else if (glStatus.Text == "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null && cbiznos.Checked == false)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and "+
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "group by 1,2,3,4 order by suma desc", ref podacitransakcije);

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
            else if (glStatus.Text == "" && glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null && cbiznos.Checked == true)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA1,k.kup_sifrakar,k.kup_prezime,k.kup_ime,k.kup_mjesto,k.kup_adresa," +
                                      "sum(t.tra_iznos) as 'suma',count(t.tra_broj) as 'broj' " +
                                      "from transakcije t, kupci k where t.kupci_id_kupci1 = k.id_kupci and " +
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' " +
                                      "group by 1,2,3,4 "+
                                      "having sum(t.tra_iznos)>='" + txtIznosOd.Text + "' and sum(t.tra_iznos)<='" + txtIznosDo.Text + "' order by suma desc", ref podacitransakcije);

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

        private void cbiznos_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbiznos.Checked)
            {
                label5.Visible = true;
                label6.Visible = true;
                txtIznosOd.Visible = true;
                txtIznosDo.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                txtIznosOd.Visible = false;
                txtIznosDo.Visible = false;
            }
        }

            

    }
}
