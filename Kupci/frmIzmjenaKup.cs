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
    public partial class frmIzmjenaKup : Form
    {
        Upiti veza = new Upiti();
        Provjera brojoiba = new Provjera();
        string sifra;
        string barkod;
        string oibroj;
        string _ime;
        string _prezime;
        string _oib;
        string _svakaID;
        string _brkart,_spol,_datpop;
        int sms,sms2,umirovljenik,umirovljenik2;
        

        public string IDstavke
        {
            get { return _svakaID; }
            set { _svakaID = value; }
        }
        public string Brkart
        {
            get { return _brkart; }
            set { _brkart = value; }
        }

        public string ime
        {
            get
            {
                return _ime;
            }
            set { _ime = value; }
        }
        public string prezime
        {
            get
            {
                return _prezime;
            }
            set { _prezime = value; }
        }
        public string oib
        {
            get
            {
                return _oib;
            }
            set { _oib = value; }
        }
        public string datpop
        {
            get
            {
                return _datpop;
            }
            set { _datpop = value; }
        }
        public string spol
        {
            get
            {
                return _spol;
            }
            set { _spol = value; }
        }
        

        public frmIzmjenaKup()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmIzmjenaKup_KeyDown(object sender, KeyEventArgs e)
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

       
        private void frmIzmjenaKup_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'mpmanDataSet.statkar' table. You can move, or remove it, as needed.
                this.statkarTableAdapter1.Fill(this.mpmanDataSet.statkar);

                DataTable podaciposlovnice = new DataTable();
                veza.ExecuteQuery("SELECT po_sifra as 'Šifra',po_naziv as 'Naziv' from boso2011.poslovnica", ref podaciposlovnice);

                if (podaciposlovnice.Rows.Count > 0)
                {
                    glPoslovnica.Properties.DisplayMember = "Naziv";
                    glPoslovnica.Properties.ValueMember = "Šifra";
                    glPoslovnica.Properties.DataSource = podaciposlovnice;
                }

                //učitavanje postojećeg kupca
                DataTable podacikupci = new DataTable();
                veza.ExecuteQuery("SELECT statkar_ST_SIFRA, kup_mjesto, kup_adresa, kup_telefon1, kup_telefon2, kup_rodjendan, kup_email, kup_sms, po_sifra,"+
                                  "kup_umirovljenik,kup_spol,kup_datpop,kup_posta,kup_siffir,kup_napomena FROM kupci where kup_brkart=" + _brkart + "", ref podacikupci);
                if (podacikupci.Rows.Count > 0)
                {

                    txtIme.Text = _ime;
                    txtPrezime.Text = _prezime;
                    txtOIB.Text = _oib;
                    glStatus.EditValue = podacikupci.Rows[0]["statkar_ST_SIFRA"];
                    dtDatumR.Text = Convert.ToString(podacikupci.Rows[0]["kup_rodjendan"]);
                    txtMjesto.Text = Convert.ToString(podacikupci.Rows[0]["kup_mjesto"]);
                    txtPosta.Text = Convert.ToString(podacikupci.Rows[0]["kup_posta"]);
                    txtAdresa.Text = Convert.ToString(podacikupci.Rows[0]["kup_adresa"]);
                    txtTelefon.Text = Convert.ToString(podacikupci.Rows[0]["kup_telefon1"]);
                    txtMobitel.Text = Convert.ToString(podacikupci.Rows[0]["kup_telefon2"]);
                    txtEmail.Text = Convert.ToString(podacikupci.Rows[0]["kup_email"]);
                    txtSpol.Text = Convert.ToString(podacikupci.Rows[0]["kup_spol"]);
                    txtFirma.Text = Convert.ToString(podacikupci.Rows[0]["kup_siffir"]);
                    txtNapomena.Text = Convert.ToString(podacikupci.Rows[0]["kup_napomena"]);
                    glPoslovnica.EditValue = podacikupci.Rows[0]["po_sifra"];
                    dtDatumP.Text = Convert.ToString(podacikupci.Rows[0]["kup_datpop"]);

                    object izraz = podacikupci.Rows[0]["kup_sms"];
                    if (izraz != DBNull.Value)
                    {
                        sms2 = Convert.ToInt32(podacikupci.Rows[0]["kup_sms"]);

                        if (sms2 == 1)
                        {
                            cbsms.Checked = true;
                        }
                    }

                    object izraz2 = podacikupci.Rows[0]["kup_umirovljenik"];
                    if (izraz2 != DBNull.Value)
                    {
                        umirovljenik2 = Convert.ToInt32(podacikupci.Rows[0]["kup_umirovljenik"]);

                        if (umirovljenik2 == 1)
                        {
                            cbumirovljenik.Checked = true;
                        }
                    }

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

                veza.ExecuteQuery(String.Format("select kup_brkart from kupci where kup_oib={0}", txtOIB.Text), ref KupciOib);
                if (KupciOib.Rows.Count > 0)
                {
                    if (Convert.ToString(KupciOib.Rows[0]["kup_brkart"]) != _brkart)
                    {
                        MessageBox.Show("OIB već postoji !!!");
                        txtOIB.Focus();
                        return;
                    }
                }
            }

            if (txtIme.Text != "" && txtPrezime.Text != "" && glStatus.Text != "" && dtDatumR.Value != null && txtMjesto.Text != "" && txtAdresa.Text != "")
            {
                try
                {
                    DialogResult result;
                    
                    result = MessageBox.Show("Želite li spremiti izmjene?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        
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

                        veza.ExecuteQuery("update kupci " +
                                          "set kup_ime = '" + txtIme.Text + "'," +
                                          "kup_prezime = '" + txtPrezime.Text + "'," +
                                          "kup_oib = '" + txtOIB.Text + "'," +
                                          "statkar_ST_SIFRA = '" + glStatus.EditValue.ToString() + "'," +
                                          "kup_rodjendan = '" + Convert.ToDateTime(dtDatumR.Text).ToString("yyyy-MM-dd") + "'," +
                                          "kup_mjesto = '" + txtMjesto.Text + "'," +
                                          "kup_adresa = '" + txtAdresa.Text + "'," +
                                          "kup_posta = '" + txtPosta.Text + "'," +
                                          "kup_telefon1 = '" + txtTelefon.Text + "'," +
                                          "kup_telefon2 = '" + txtMobitel.Text + "'," +
                                          "kup_email = '" + txtEmail.Text + "'," +
                                          "kup_sms = '" + sms + "'," +
                                          "po_sifra = '" + glPoslovnica.EditValue.ToString() + "'," +
                                          "kup_umirovljenik = '" + umirovljenik + "'," +
                                          "kup_spol = '" + txtSpol.Text + "'," +
                                          "kup_siffir = '" + txtFirma.Text + "'," +
                                          "kup_napomena = '" + txtNapomena.Text + "'," +
                                          "kup_datpop = '" + Convert.ToDateTime(dtDatumP.Text).ToString("yyyy-MM-dd") + "' " +
                                          "where kup_brkart = '" + _brkart + "'");
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

        private void dtDatumP_ValueChanged(object sender, EventArgs e)
        {
            dtDatumP.Format = DateTimePickerFormat.Short;
        }

        private void dtDatumP_Enter(object sender, EventArgs e)
        {
            if (dtDatumP.Text == " ")
            {
                dtDatumP.Value = DateTime.Now;
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
       
    }
}
