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
    public partial class frmSms : Form
    {
        Upiti veza = new Upiti();
        DataTable podacikupci = new DataTable();
        DataTable podacimjesta = new DataTable();
        
        public frmSms()
        {
            InitializeComponent();
        }

        private void frmSms_Load(object sender, EventArgs e)
        {
            
            try
            {
                veza.ExecuteQuery("select distinct mj_naziv as 'Naziv' from boso2011.mjesto order by mj_naziv", ref podacimjesta);

                if (podacimjesta.Rows.Count > 0)
                {
                    glMjesto.Properties.DisplayMember = "Naziv";
                    glMjesto.Properties.ValueMember = "Naziv";
                    glMjesto.Properties.DataSource = podacimjesta;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSms_KeyDown(object sender, KeyEventArgs e)
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
        
        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            btnPrikazi.Enabled = false;

            if (glMjesto.Text != "" && cbsms.Checked==true)
            {                
                               
                try
                {
                    veza.ExecuteQuery("select kup_brkart,st_naziv,kup_prezime,kup_ime,kup_oib,kup_telefon1,kup_telefon2,kup_email,kup_rodjendan,kup_vazido from kupci left join statkar on statkar.st_sifra=kupci.statkar_ST_SIFRA where kup_sms=1 and kup_mjesto = '" + glMjesto.EditValue + "'", ref podacikupci);

                    if (podacikupci.Rows.Count > 0)
                    {

                        dgPregled.DataSource = podacikupci;
                                              
                        
                    }
                }
                    
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnPrikazi.Enabled = true;
                }

            }
            else if (glMjesto.Text != "" && cbsms.Checked == false)
            {
                
                try
                {
                    veza.ExecuteQuery("select kup_brkart,st_naziv,kup_prezime,kup_ime,kup_oib,kup_telefon1,kup_telefon2,kup_email,kup_rodjendan,kup_vazido from kupci left join statkar on statkar.st_sifra=kupci.statkar_ST_SIFRA where kup_mjesto = '" + glMjesto.EditValue + "' and (kup_sms=0 or kup_sms is null)", ref podacikupci);

                    if (podacikupci.Rows.Count > 0)
                    {
                        dgPregled.DataSource = podacikupci;
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
