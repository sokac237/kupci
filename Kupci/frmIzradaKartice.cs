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
    public partial class frmIzradaKartice : Form
    {
        Upiti veza = new Upiti();
        DataTable podacikupci = new DataTable();
        DataTable podaciposlovnice = new DataTable();
        

        string datumOD;
        string datumDO;
        

        public frmIzradaKartice()
        {
            InitializeComponent();
        }

        private void frmIzradaKartice_Load(object sender, EventArgs e)
        {
            
            try
            {
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

        private void frmIzradaKartice_KeyDown(object sender, KeyEventArgs e)
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

            if (glPoslovnica.Text == "" && dtOd.Value != null && dtDo.Value != null)
            {                
                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select kup_brkart,kup_prezime,kup_ime,kup_oib,kup_dankar,k.po_sifra,po_naziv from kupci k,boso2011.poslovnica p where k.po_sifra=p.po_sifra and kup_dankar>='" + datumOD + "' and kup_dankar<='" + datumDO + "'", ref podacikupci);

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
            else if (glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null)
            {
                                
                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    veza.ExecuteQuery("select kup_brkart,kup_prezime,kup_ime,kup_oib,kup_dankar,k.po_sifra,po_naziv from kupci k,boso2011.poslovnica p where k.po_sifra=p.po_sifra and kup_dankar>='" + datumOD + "' and kup_dankar<='" + datumDO + "' and k.po_sifra = '" + glPoslovnica.EditValue + "'", ref podacikupci);

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
