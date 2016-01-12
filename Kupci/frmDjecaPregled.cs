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
    public partial class frmDjecaPregled : Form
    {
       
        Upiti veza = new Upiti();
        DataTable podaci = new DataTable();
        DataTable podacikupci = new DataTable();
        public frmDjecaPregled()
        {
            InitializeComponent();
        }
                

        private void frmDjecaPregled_Load(object sender, EventArgs e)
        {
            
            try
            {
                veza.ExecuteQuery("select * from djeca order by dj_datumrod", ref podaci);

                if (podaci.Rows.Count > 0)
                {
                    dgDjeca.DataSource = podaci;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Želite obrisati dijete ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    System.Data.DataRow row = dgrDjeca.GetDataRow(dgrDjeca.FocusedRowHandle);
                    if (row != null)
                    {
                        string sifrakup = row["kup_sifrak"].ToString();
                        string dijeteime = row["dj_ime"].ToString();
                        veza.ExecuteQuery(@"delete from djeca where kup_sifrak='" + sifrakup + "' and dj_ime='" + dijeteime + "'");

                        MessageBox.Show("Uspješno ste obrisali stavku!");

                        veza.ExecuteQuery("select * from djeca order by dj_datumrod", ref podaci);
                        dgDjeca.DataSource = podaci;

                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDjecaPregled_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgrDjeca_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            System.Data.DataRow row = dgrDjeca.GetDataRow(dgrDjeca.FocusedRowHandle);

            if (row != null)
            {
                string sifrakar = row["kup_sifrak"].ToString();

                if (sifrakar != "")
                {
                    veza.ExecuteQuery("select * from kupci where kup_sifrakar=" + sifrakar + "", ref podacikupci);

                    if (podacikupci.Rows.Count > 0)
                    {
                        lKupac.Text = podacikupci.Rows[0]["kup_prezime"].ToString().Trim() + " " + podacikupci.Rows[0]["kup_ime"].ToString().Trim();
                    }
                }

            }
        }

        private void btnDjecaGodina_Click(object sender, EventArgs e)
        {
            frmDjecaGodina _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmDjecaGodina))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmDjecaGodina();
            _frm.ShowDialog();
        }
                               
                     
    }
}
