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
    public partial class frmDjecaGodina : Form
    {
        Upiti veza = new Upiti();
        DataTable podacitransakcije = new DataTable();
      
        public frmDjecaGodina()
        {
            InitializeComponent();
        }
        
        private void frmDjecaGodina_Load(object sender, EventArgs e)
        {
            try
            {
                podacitransakcije.Clear();

                veza.ExecuteQuery("select k.kup_brkart,k.kup_prezime,k.kup_ime,d.dj_ime,d.dj_datumrod from kupci k,djeca d " +
                                                      "where k.kup_sifrakar=d.kup_sifrak  and k.statkar_st_sifra='06' and "+
                                                      "d.dj_datumrod <= DATE_SUB(CURDATE(), INTERVAL 24 YEAR) "+
                                                      "order by kup_brkart,d.dj_datumrod", ref podacitransakcije);
                
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

        private void frmDjecaGodina_KeyDown(object sender, KeyEventArgs e)
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
