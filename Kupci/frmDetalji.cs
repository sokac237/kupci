using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartXLS;

namespace Kupci
{
    public partial class frmDetalji : Form
    {
        string _transakcijaID;
        string _poslovnicaID;
        Upiti veza = new Upiti();
        DataTable podacitransakcije = new DataTable();
        DataTable podacikatalog = new DataTable();
        string katalog, ipadresa, baza;
        MySqlConnection connection = new MySqlConnection();
        string ConnectionString;
        MySqlCommand upit1 = new MySqlCommand();

        public frmDetalji()
        {
            InitializeComponent();
        }

        public string IDtransakcija
        {
            get { return _transakcijaID; }
            set { _transakcijaID = value; }
        }
        public string IDposlovnica
        {
            get { return _poslovnicaID; }
            set { _poslovnicaID = value; }
        }

        private void frmDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                //katalog
                veza.ExecuteQuery("SELECT po_ipadresa,po_katalog from boso2011.poslovnica where po_sifra='" + _poslovnicaID + "'", ref podacikatalog);
                ipadresa = Convert.ToString(podacikatalog.Rows[0][0]);
                baza = Convert.ToString(podacikatalog.Rows[0][1]);
                katalog = "`" + Convert.ToString(podacikatalog.Rows[0][1]) + "`";

                connection = new MySqlConnection();
                ConnectionString = "Server = " + ipadresa + "; Database=" + baza + "; Uid=admin10; Pwd=movema10;";
                connection.ConnectionString = ConnectionString;

                connection.Open();

                podacitransakcije.Clear();

                MySqlCommand upit1 = new MySqlCommand("select a.ar_sifra as 'Šifra', a.ar_naziv as 'Naziv',z.ra_kolicina as 'Količina',z.ra_cijena as 'Cijena',"+
                                         "sum(z.ra_kolicina*z.ra_cijena) as 'Promet' , " +
                                         "sum(z.ra_ruc) as 'Zarada' from " + katalog + ".zalkart z, " + katalog + ".artik a , " + katalog + ".kupci k " +
                                         "where z.ar_sifra = a.ar_sifra and k.kup_brkart=z.tra_kartic and z.tra_broj='" + _transakcijaID + "' " +
                                         "group by 1,2", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(upit1);
                upit1.ExecuteNonQuery();

                adapter.Fill(podacitransakcije);

                if (podacitransakcije.Rows.Count > 0)
                {
                    dgTransakcije.DataSource = podacitransakcije;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }          

        private void frmDetalji_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DevExpress.XtraGrid.GridControl tablica = dgTransakcije;
                        if (tablica != null)
                        {
                            // Put the selected text on the Clipboard.
                            //Clipboard.SetDataObject(tablica.DataSource);
                            WorkBook m_book = new WorkBook();

                            //Export DataTable.
                            if (tablica.DataSource != null)
                            {
                                m_book.ImportDataTable((DataTable)tablica.DataSource, true, 1, 1, -1, -1);
                            }
                            else
                            {
                                MessageBox.Show("Nema podataka za export u excel!", "Error");
                                return;
                            }

                            //Saving the workbook to disk.
                            m_book.write("C:\\Podaci\\Podaci.xls");


                            //Message box confirmation to view the created spreadsheet.
                            if (MessageBox.Show("Želite li pogledati podatke?", "Dokument je kreiran",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                                == DialogResult.Yes)
                            {
                                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                                System.Diagnostics.Process.Start("C:\\Podaci\\Podaci.xls");
                            }

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Morate selektirati tablicu !!!");
                    }

                }
            }
        }
                             
    }
}
