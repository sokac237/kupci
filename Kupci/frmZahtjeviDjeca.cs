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
    public partial class frmZahtjeviDjeca : Form
    {
        Upiti veza = new Upiti();
        DataTable podaci = new DataTable();
        string oibroj;
        string _ime;
        string _prezime;
        string _oib;
        string _datumr;
        string _svakaID;
        string dijeteime;

        public string IDstavke
        {
            get { return _svakaID; }
            set { _svakaID = value; }
        }
       
        public string ime
        {
            get 
            {
                return _ime; 
            }
        }
        public string prezime
        {
            get
            {
                return _prezime;
            }
        }
        public string oib
        {
            get
            {
                return _oib;
            }
        }
        
        public string datumr
        {
            get
            {
                return _datumr;
            }
        }
                

        public frmZahtjeviDjeca()
        {
            InitializeComponent();
        }

        private void frmZahtjeviDjeca_Load(object sender, EventArgs e)
        {
            try
            {
                veza.ExecuteQuery("select  * from zahtjevidjeca where OIB = '" + _svakaID + "'", ref podaci);

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
                System.Data.DataRow row = dgrDjeca.GetDataRow(dgrDjeca.FocusedRowHandle);
                if (row != null)
                {
                    oibroj = row["OIB"].ToString();
                    dijeteime = row["ime"].ToString();
                    veza.ExecuteQuery(@"delete from zahtjevidjeca where OIB='" + oibroj + "' and ime='" + dijeteime + "'");
                    
                    MessageBox.Show("Uspješno ste obrisali stavku!");

                    veza.ExecuteQuery("select  * from zahtjevidjeca where OIB = '" + _svakaID + "'", ref podaci);
                    dgDjeca.DataSource = podaci;           
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            System.Data.DataRow row = dgrDjeca.GetDataRow(dgrDjeca.FocusedRowHandle);
                        
            _ime = row["ime"].ToString();
            _prezime = row["prezime"].ToString();
            _oib = row["oib"].ToString();
            _datumr = row["datumrod"].ToString();
            
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void dgKupci_DoubleClick(object sender, EventArgs e)
        {
            btnPrenesi.PerformClick();
        }

        private void zahtjevidjecaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zahtjevidjecaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mpmanDataSet1);

        }
            
    }
}
