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
    public partial class frmRodjendan : Form
    {
        Upiti veza = new Upiti();
        DataTable podacikupci = new DataTable();
        DataTable podaciposlovnice = new DataTable();
        DataTable podacitransakcije = new DataTable();

        string datumOD;
        string datumDO;

        public frmRodjendan()
        {
            InitializeComponent();
        }

        private void frmRodjendan_Load(object sender, EventArgs e)
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

        private void frmRodjendan_KeyDown(object sender, KeyEventArgs e)
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

            if (glStatus.Text != "" && dtOd.Value != null && dtDo.Value != null)
            {                
                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA,kup_brkart,k.kup_sifrakar,k.kup_prezime,k.kup_ime,count(tra_broj) as 'Broj kupnji',"+
                                      "sum(t.tra_iznos) as 'suma' from transakcije t, kupci k where t.kupci_id_kupci = k.id_kupci and "+
                                      "tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' and t.kupci_statkar_ST_SIFRA = '" + glStatus.EditValue + "' "+
                                      "and DATE_FORMAT(k.kup_rodjendan, '%m%d')=substring(t.tra_danisat,5,4) group by 1,2,3,4,5 order by suma desc,4,5", ref podacitransakcije);

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
            else if (glStatus.Text == "" && dtOd.Value != null && dtDo.Value != null)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select t.kupci_statkar_ST_SIFRA,k.kup_sifrakar,k.kup_prezime,k.kup_ime,sum(t.tra_iznos) as 'suma' from transakcije t, "+
                                      "kupci k where t.kupci_id_kupci = k.id_kupci and tra_datum>='" + datumOD + "' and tra_datum<='" + datumDO + "' "+
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

            btnPrikazi.Enabled = true;
        }
    }
}
