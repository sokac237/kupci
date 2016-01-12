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
    public partial class frmRacuni : Form
    {
        Upiti veza = new Upiti();
        DataTable podacikupci = new DataTable();
        DataTable podaciposlovnice = new DataTable();
        DataTable podacitransakcije = new DataTable();

        string datumOD;
        string datumDO;

        public frmRacuni()
        {
            InitializeComponent();
        }

        private void frmRacuni_Load(object sender, EventArgs e)
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
                                
                dtOd.Value = DateTime.Today.AddDays(1 - DateTime.Today.Day);
                dtDo.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRacuni_KeyDown(object sender, KeyEventArgs e)
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

            if (glStatus.Text != "" && dtOd.Value != null && dtDo.Value != null && txt2.Text != "" && txt4.Text != "" && txt6.Text != "" && txt8.Text != "" && txt10.Text != "")
            {                
                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select kupci_statkar_ST_SIFRA as `Šifra`,st_naziv as `Naziv`," +
                    "SUM(IF(tra_iznos>=0 and tra_iznos<50, 1,0)) AS `vrijednost1`," +
                    "SUM(IF(tra_iznos>=0 and tra_iznos<50, tra_iznos,0)) AS `suma1`," +
                    "SUM(IF(tra_iznos>=50 and tra_iznos<100, 1,0)) AS `vrijednost2`," +
                    "SUM(IF(tra_iznos>=50 and tra_iznos<100, tra_iznos,0)) AS `suma2`," +
                    "SUM(IF(tra_iznos>=100  and tra_iznos<150, 1,0)) AS `vrijednost3`," +
                    "SUM(IF(tra_iznos>=100  and tra_iznos<150, tra_iznos,0)) AS `suma3`," +
                    "SUM(IF(tra_iznos>=150  and tra_iznos<200, 1,0)) AS `vrijednost4`," +
                    "SUM(IF(tra_iznos>=150  and tra_iznos<200, tra_iznos,0)) AS `suma4`," +
                    "SUM(IF(tra_iznos>=200  and tra_iznos<250, 1,0)) AS `vrijednost5`," +
                    "SUM(IF(tra_iznos>=200  and tra_iznos<250, tra_iznos,0)) AS `suma5`," +
                    "SUM(IF(tra_iznos>=250, 1,0)) AS `vrijednost6`," +
                    "SUM(IF(tra_iznos>=250, tra_iznos,0)) AS `suma6`," +
                    "COUNT(tra_iznos) AS `ukupna vrijednost`," +
                    "SUM(tra_iznos) AS `ukupna suma` " +
                    "from transakcije, statkar " +
                    "where str_to_date(tra_danisat, '%Y%m%d')>='" + datumOD + "' and str_to_date(tra_danisat, '%Y%m%d')<='" + datumDO + "' " +
                    "and kupci_statkar_ST_SIFRA = '" + glStatus.EditValue + "' and kupci_statkar_st_sifra=st_sifra group by 1,2", ref podacitransakcije);

                    //veza.ExecuteQuery("select kupci_statkar_ST_SIFRA as `Šifra`,st_naziv as `Naziv`,SUM(IF(tra_iznos>=0 and tra_iznos<50, 1,0)) AS `vrijednost1`,SUM(IF(tra_iznos>=0 and tra_iznos<50, tra_iznos,0)) AS `suma1`,SUM(IF(tra_iznos>=50 and tra_iznos<100, 1,0)) AS `vrijednost2`,SUM(IF(tra_iznos>=50 and tra_iznos<100, tra_iznos,0)) AS `suma2`,SUM(IF(tra_iznos>=100  and tra_iznos<150, 1,0)) AS `vrijednost3`,SUM(IF(tra_iznos>=100  and tra_iznos<150, tra_iznos,0)) AS `suma3`,SUM(IF(tra_iznos>=150  and tra_iznos<200, 1,0)) AS `vrijednost4`,SUM(IF(tra_iznos>=150  and tra_iznos<200, tra_iznos,0)) AS `suma4`,SUM(IF(tra_iznos>=200  and tra_iznos<250, 1,0)) AS `vrijednost5`,SUM(IF(tra_iznos>=200  and tra_iznos<250, tra_iznos,0)) AS `suma5`,SUM(IF(tra_iznos>=250, 1,0)) AS `vrijednost6`,SUM(IF(tra_iznos>=250, tra_iznos,0)) AS `suma6`,COUNT(tra_iznos) AS `ukupna vrijednost`,SUM(tra_iznos) AS `ukupna suma` from transakcije, statkar where str_to_date(tra_danisat, '%Y%m%d')>='" + datumOD + "' and str_to_date(tra_danisat, '%Y%m%d')<='" + datumDO + "' and kupci_statkar_ST_SIFRA = '" + glStatus.EditValue + "' and kupci_statkar_st_sifra=st_sifra group by 1,2", ref podacitransakcije);

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
            else if (glStatus.Text == "" && dtOd.Value != null && dtDo.Value != null && txt2.Text != "" && txt4.Text != "" && txt6.Text != "" && txt8.Text != "" && txt10.Text != "")
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select kupci_statkar_ST_SIFRA as `Šifra`,st_naziv as `Naziv`," +
                    "SUM(IF(tra_iznos>=0 and tra_iznos<50, 1,0)) AS `vrijednost1`," +
                    "SUM(IF(tra_iznos>=0 and tra_iznos<50, tra_iznos,0)) AS `suma1`," +
                    "SUM(IF(tra_iznos>=50 and tra_iznos<100, 1,0)) AS `vrijednost2`," +
                    "SUM(IF(tra_iznos>=50 and tra_iznos<100, tra_iznos,0)) AS `suma2`," +
                    "SUM(IF(tra_iznos>=100  and tra_iznos<150, 1,0)) AS `vrijednost3`," +
                    "SUM(IF(tra_iznos>=100  and tra_iznos<150, tra_iznos,0)) AS `suma3`," +
                    "SUM(IF(tra_iznos>=150  and tra_iznos<200, 1,0)) AS `vrijednost4`," +
                    "SUM(IF(tra_iznos>=150  and tra_iznos<200, tra_iznos,0)) AS `suma4`," +
                    "SUM(IF(tra_iznos>=200  and tra_iznos<250, 1,0)) AS `vrijednost5`," +
                    "SUM(IF(tra_iznos>=200  and tra_iznos<250, tra_iznos,0)) AS `suma5`," +
                    "SUM(IF(tra_iznos>=250, 1,0)) AS `vrijednost6`," +
                    "SUM(IF(tra_iznos>=250, tra_iznos,0)) AS `suma6`," +
                    "COUNT(tra_iznos) AS `ukupna vrijednost`," +
                    "SUM(tra_iznos) AS `ukupna suma` " +
                    "from transakcije, statkar " +
                    "where str_to_date(tra_danisat, '%Y%m%d')>='" + datumOD + "' and str_to_date(tra_danisat, '%Y%m%d')<='" + datumDO + "' " +
                    "and kupci_statkar_st_sifra=st_sifra group by 1,2", ref podacitransakcije);

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

        private void txt2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt2.Text) <= Convert.ToDouble(txt1.Text))
            {
                txt2.Text = "";
                txt2.Focus();
            }
            else
            {
                txt3.Text = txt2.Text;
                txt4.Focus();
            }

        }

        private void txt4_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt4.Text) <= Convert.ToDouble(txt3.Text))
            {
                txt4.Text = "";
                txt4.Focus();
            }
            else
            {
                txt5.Text = txt4.Text;
                txt6.Focus();
            }
        }

        private void txt6_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt6.Text) <= Convert.ToDouble(txt5.Text))
            {
                txt6.Text = "";
                txt6.Focus();
            }
            else
            {
                txt7.Text = txt6.Text;
                txt8.Focus();
            }
        }

        private void txt8_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt8.Text) <= Convert.ToDouble(txt7.Text))
            {
                txt8.Text = "";
                txt8.Focus();
            }
            else
            {
                txt9.Text = txt8.Text;
                txt10.Focus();
            }
        }

        private void txt10_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt10.Text) <= Convert.ToDouble(txt9.Text))
            {
                txt10.Text = "";
                txt10.Focus();
            }
            
        }
    }
}
