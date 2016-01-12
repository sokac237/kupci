using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartXLS;

namespace Kupci
{
    public partial class frmZahtjevi : Form
    {
        Upiti veza = new Upiti();
        DataTable podaci = new DataTable();
        string oibroj;
        string _ime;
        string _prezime;
        string _oib;
        string _status;
        string _datumr;
        string _mjesto;
        string _adresa;
        string _telefon;
        string _mobitel;
        string _email;
        int _sms,_umirovljenik;
        string _napomena,_po_sifra,_spol;
        string imekup, prezimekup, datumrodkup, vrijemeobrade;
        

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
        public string status
        {
            get
            {
                return _status;
            }
        }
        public string datumr
        {
            get
            {
                return _datumr;
            }
        }
        public string mjesto
        {
            get
            {
                return _mjesto;
            }
        }
        public string adresa
        {
            get
            {
                return _adresa;
            }
        }
        public string telefon
        {
            get
            {
                return _telefon;
            }
        }
        public string mobitel
        {
            get
            {
                return _mobitel;
            }
        }
        public string email
        {
            get
            {
                return _email;
            }
        }
        public int sms
        {
            get
            {
                return _sms;
            }
        }
        public string napomena
        {
            get
            {
                return _napomena;
            }
        }
        public int umirovljenik
        {
            get
            {
                return _umirovljenik;
            }
        }
        public string po_sifra
        {
            get
            {
                return _po_sifra;
            }
        }
        public string spol
        {
            get
            {
                return _spol;
            }
        }


        public frmZahtjevi()
        {
            InitializeComponent();
        }

        private void frmZahtjevi_Load(object sender, EventArgs e)
        {
            try
            {
                veza.ExecuteQuery("SELECT z.po_sifra,p.po_naziv, ka_sifra, nova, postojeca, ime, prezime, datumrod, mjesto, adresa, telefon, mobitel, sms, email,"+
                                  "napomena, vrijemezah, obrada, vrijemeobrade, OIB, umirovljenik, spol, brkart,dodatni,brkartdod FROM zahtjevi z,poslovnica p "+
                                  "WHERE z.po_sifra=p.po_sifra and obrada=0", ref podaci);

                dgKupci.DataSource = podaci;


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
                result = MessageBox.Show("Želite ukloniti korisnika ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);
                if (row != null)
                {
                    //oibroj = row["OIB"].ToString();
                    imekup = row["ime"].ToString();
                    prezimekup = row["prezime"].ToString();
                    datumrodkup = Convert.ToDateTime(row["datumrod"].ToString()).ToString("yyyyMMdd");
                    //vrijemeobrade = Convert.ToDateTime;

                    //veza.ExecuteQuery(@"delete from zahtjevi where OIB=" + oibroj + "");
                    veza.ExecuteQuery(@"update zahtjevi set obrada=1, vrijemeobrade=now() "+
                                       "where ime='" + imekup + "' and prezime='" + prezimekup + "' and datumrod='" + datumrodkup + "'");

                    MessageBox.Show("Uspješno ste uklonili stavku!");

                    veza.ExecuteQuery("SELECT z.po_sifra,p.po_naziv, ka_sifra, nova, postojeca, ime, prezime, datumrod, mjesto, adresa, telefon, mobitel, sms, email," +
                                  "napomena, vrijemezah, obrada, vrijemeobrade, OIB, umirovljenik, spol, brkart,dodatni,brkartdod FROM zahtjevi z,poslovnica p " +
                                  "WHERE z.po_sifra=p.po_sifra and obrada=0", ref podaci);

                    dgKupci.DataSource = podaci; 
                    
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

        private void btnPrenesi_Click(object sender, EventArgs e)
        {
            System.Data.DataRow row = dgBon.GetDataRow(dgBon.FocusedRowHandle);

            //provjera da li postoji kartica u bazi
            string brkartice = row["brkart"].ToString();
            if (brkartice != "")
            {
                DataTable KupciKartica = new DataTable();

                veza.ExecuteQuery("select kup_brkart from kupci where kup_brkart=" + brkartice + "", ref KupciKartica);
                if (KupciKartica.Rows.Count > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Kartica sa tim brojem već postoji !!! Želite li nastaviti dalje ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            //if (row != null)
            //    {
                    
            //        imekup = row["ime"].ToString();
            //        prezimekup = row["prezime"].ToString();
            //        datumrodkup = Convert.ToDateTime(row["datumrod"].ToString()).ToString("yyyyMMdd");

            //        veza.ExecuteQuery(@"update zahtjevi "+
            //                           "set obrada=1 "+
            //                           "where ime='" + imekup + "' and prezime='" + prezimekup + "' and datumrod='" + datumrodkup + "'");

            //    }
                


            _ime = row["ime"].ToString();
            _prezime = row["prezime"].ToString();
            _oib = row["oib"].ToString();
            _status = row["ka_sifra"].ToString();
            _datumr = row["datumrod"].ToString();
            _mjesto = row["mjesto"].ToString();
            _adresa = row["adresa"].ToString();
            _telefon = row["telefon"].ToString();
            _mobitel = row["mobitel"].ToString();
            _email = row["email"].ToString();
            _sms = Convert.ToInt32(row["sms"].ToString());
            _napomena = row["napomena"].ToString();
            _spol = row["spol"].ToString();
            _umirovljenik = Convert.ToInt32(row["umirovljenik"].ToString());
            _po_sifra = row["po_sifra"].ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void dgKupci_DoubleClick(object sender, EventArgs e)
        {
            btnPrenesi.PerformClick();
        }

        private void frmZahtjevi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                        try
                        {
                            DevExpress.XtraGrid.GridControl tablica = dgKupci;
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

        private void btnSvi_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSvi.Text == "Prikaži sve")
                {
                    veza.ExecuteQuery("SELECT z.po_sifra,p.po_naziv, ka_sifra, nova, postojeca, ime, prezime, datumrod, mjesto, adresa, telefon, mobitel, sms, email," +
                                      "napomena, vrijemezah, obrada, vrijemeobrade, OIB, umirovljenik, spol, brkart,dodatni,brkartdod FROM zahtjevi z,poslovnica p " +
                                      "WHERE z.po_sifra=p.po_sifra", ref podaci);
                    btnSvi.Text = "Sakrij obrađene";
                }
                else
                {
                    veza.ExecuteQuery("SELECT z.po_sifra,p.po_naziv, ka_sifra, nova, postojeca, ime, prezime, datumrod, mjesto, adresa, telefon, mobitel, sms, email," +
                                  "napomena, vrijemezah, obrada, vrijemeobrade, OIB, umirovljenik, spol, brkart,dodatni,brkartdod FROM zahtjevi z,poslovnica p " +
                                  "WHERE z.po_sifra=p.po_sifra and obrada=0", ref podaci);
                    btnSvi.Text = "Prikaži sve";
                }

                dgKupci.DataSource = podaci;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
               
            
    }
}
