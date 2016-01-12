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
    public partial class frmDjeca : Form
    {
        string _svakaID;
        string _OibID;
        Upiti veza = new Upiti();
        Provjera brojoiba = new Provjera();
        DataTable podaci = new DataTable();
        public frmDjeca()
        {
            InitializeComponent();
        }

        public string IDstavke
        {
            get { return _svakaID; }
            set { _svakaID = value; }
        }
        public string IDOib
        {
            get { return _OibID; }
            set { _OibID = value; }
        }

        private void frmDjeca_Load(object sender, EventArgs e)
        {
            try
            {
                veza.ExecuteQuery("select  * from djeca where kup_sifrak = '" + _svakaID + "'", ref podaci);

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

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            btnPrenesi.Enabled = false;
            frmZahtjeviDjeca _frm;
            foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmZahtjeviDjeca))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmZahtjeviDjeca();
            _frm.IDstavke = IDOib;

            DialogResult res = _frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                dtDatumR.Format = DateTimePickerFormat.Short;
                txtIme.Text = _frm.ime;
                txtPrezime.Text = _frm.prezime;
                //txtOIB.Text = _frm.oib;
                dtDatumR.Value = DateTime.Parse(_frm.datumr);
               
            }
            btnPrenesi.Enabled = true;
        }

        private void dtDatumR_ValueChanged(object sender, EventArgs e)
        {
            dtDatumR.Format = DateTimePickerFormat.Short;
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && dtDatumR.Text != " " )
            {
                if (brojoiba.CheckOIB(txtOIB.Text) == false)
                {
                    MessageBox.Show("Neispravan OIB !!!");
                }

                try
                
                {
                    DialogResult result;

                    result = MessageBox.Show("Želite li dodati dijete?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                                                                                               
                        // Create a new row.
                        mpmanDataSet.djecaRow newDjecaRow;
                        newDjecaRow = mpmanDataSet1.djeca.NewdjecaRow();
                        newDjecaRow.dj_ime = txtIme.Text;
                        newDjecaRow.dj_prezime = txtPrezime.Text;
                        newDjecaRow.dj_oib = txtOIB.Text;
                        newDjecaRow.dj_datumrod = dtDatumR.Value;
                        newDjecaRow.kup_sifrak = IDstavke;
                        newDjecaRow.kup_oib = IDOib;                       

                        // Add the row to the Kupci table
                        this.mpmanDataSet1.djeca.Rows.Add(newDjecaRow);

                        // Save the new row to the database
                        this.djecaTableAdapter.Update(this.mpmanDataSet1.djeca);

                        veza.ExecuteQuery("select  * from djeca where kup_sifrak = '" + _svakaID + "'", ref podaci);
                        dgDjeca.DataSource = podaci;

                        txtIme.Text = "";
                        txtPrezime.Text = "";
                        txtOIB.Text = "";
                        dtDatumR.Format = DateTimePickerFormat.Custom;
                        dtDatumR.CustomFormat = " ";
                        //dtDatumR.Text = "";
                                

                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnNovi.Enabled = true;
                }
                                
                
            }
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

                        veza.ExecuteQuery("select  * from djeca where kup_sifrak = '" + _svakaID + "'", ref podaci);
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

        private void frmDjeca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dtDatumR_Enter(object sender, EventArgs e)
        {
            if (dtDatumR.Text == " ")
            {
                dtDatumR.Value = DateTime.Now;    
            }
        }
          
                     
    }
}
