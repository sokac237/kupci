using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using FastReport;
using System.Threading;

namespace Kupci
{
    public partial class frmKupci : Form
    {        
        Upiti veza = new Upiti();
        DataTable podaci = new DataTable();
        DataTable tablica = new DataTable();
        DataTable koverta = new DataTable();
        DataTable kartice = new DataTable();
        DataTable oznake = new DataTable();
        int topRowIndex;
        int focus;
                
        public frmKupci()
        {
            InitializeComponent();
            
            //Thread th = new Thread(new ThreadStart(DoSplash));
            //th.Start();
            //Thread.Sleep(3000);
            //th.Abort();
            ////Thread.Sleep(1000);
        }

        

        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmNoviKup _frm;
            foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmNoviKup))
                {
                    childForm.Focus();
                    return;
                }
            }
            
            _frm = new frmNoviKup();
            
            DialogResult res = _frm.ShowDialog();
            if (res == DialogResult.OK)
            {
                veza.ExecuteQuery("SELECT kup_brkart,kup_sifrakar,kup_oib,kup_prezime,kup_ime,po_sifra,kup_status,kup_datpop,statkar_st_sifra FROM kupci order by kup_brkart", ref podaci);
                dgKupci.DataSource = podaci;

                dgrKupci.MoveLast();
            }
                       
           
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDjeca_Click(object sender, EventArgs e)
        {
            if (dgrKupci.RowCount > 0)
            {
                try
                {
                    System.Data.DataRow row = dgrKupci.GetDataRow(dgrKupci.FocusedRowHandle);

                    if (row != null)
                    {
                        string IDstavke = row["kup_sifrakar"].ToString();
                        string IDOib = row["kup_oib"].ToString();


                        frmDjeca _frm;
                        foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
                        {
                            if (childForm.GetType() == typeof(frmDjeca))
                            {
                                childForm.Focus();
                                return;
                            }
                        }
                        _frm = new frmDjeca();
                        
                        _frm.IDstavke = IDstavke;
                        _frm.IDOib = IDOib;
                        _frm.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            if (dgrKupci.RowCount > 0)
            {
                try
                {
                    topRowIndex = dgrKupci.TopRowIndex;
                    focus = dgrKupci.FocusedRowHandle;
                    System.Data.DataRow row = dgrKupci.GetDataRow(dgrKupci.FocusedRowHandle);

                    if (row != null)
                    {
                        string IDstavke = row["kup_sifrakar"].ToString();
                        string brkart = row["kup_brkart"].ToString();


                        frmIzmjenaKup _frm;
                        foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
                        {
                            if (childForm.GetType() == typeof(frmIzmjenaKup))
                            {
                                childForm.Focus();
                                return;
                            }
                        }
                        _frm = new frmIzmjenaKup();

                        _frm.IDstavke = IDstavke;
                        _frm.Brkart = brkart;
                        _frm.ime = row["kup_ime"].ToString();
                        _frm.prezime = row["kup_prezime"].ToString();
                        _frm.oib = row["kup_oib"].ToString();
                        _frm.datpop = row["kup_datpop"].ToString();
                        //_frm.status = row["statkar_st_sifra"].ToString();
                        //_frm.datumr = row["kup_rodjendan"].ToString();
                        //_frm.mjesto = row["kup_mjesto"].ToString();
                        //_frm.adresa = row["kup_adresa"].ToString();
                        //_frm.telefon = row["kup_telefon1"].ToString();
                        //_frm.mobitel = row["kup_telefon2"].ToString();
                        
                        DialogResult res = _frm.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            //this.kupciupitTableAdapter.Fill(this.mpmanDataSet1.kupciupit);
                            //veza.ExecuteQuery("SELECT kup_brkart, kup_sifrakar, kup_prezime, kup_ime, kup_oib, kup_status, statkar_ST_SIFRA, kup_mjesto, kup_adresa, kup_telefon1, kup_telefon2, kup_rodjendan FROM kupci order by kup_brkart", ref podaci);

                            veza.ExecuteQuery("SELECT kup_brkart,kup_sifrakar,kup_oib,kup_prezime,kup_ime,po_sifra,kup_status,kup_datpop,statkar_st_sifra FROM kupci order by kup_brkart", ref podaci);
                            dgKupci.DataSource = podaci;

                            dgrKupci.TopRowIndex = topRowIndex;
                            dgrKupci.SelectRow(focus);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgKupci_DoubleClick(object sender, EventArgs e)
        {
            btnIzmjena.PerformClick();
        }

        private void btnDodatni_Click(object sender, EventArgs e)
        {
            if (dgrKupci.RowCount > 0)
            {
                try
                {
                    System.Data.DataRow row = dgrKupci.GetDataRow(dgrKupci.FocusedRowHandle);

                    if (row != null)
                    {
                        string brkart = row["kup_sifrakar"].ToString();

                        frmDodatniKup _frm;
                        foreach (Form childForm in frmGlavna.ActiveForm.MdiChildren)
                        {
                            if (childForm.GetType() == typeof(frmDodatniKup))
                            {
                                childForm.Focus();
                                return;
                            }
                        }

                        _frm = new frmDodatniKup();
                        _frm.Brkart = brkart;

                        DialogResult res = _frm.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            veza.ExecuteQuery("SELECT kup_brkart,kup_sifrakar,kup_oib,kup_prezime,kup_ime,po_sifra,kup_status,kup_datpop,statkar_st_sifra FROM kupci order by kup_brkart", ref podaci);
                            dgKupci.DataSource = podaci;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void dgrKupci_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            System.Data.DataRow row = dgrKupci.GetDataRow(dgrKupci.FocusedRowHandle);

            if (row != null)
            {
                string status = row["kup_status"].ToString();
                if (status == "N")
                    btnDodatni.Enabled = true;
                else
                    btnDodatni.Enabled = false;

            }

            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Želite obrisati korisnika ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    topRowIndex = dgrKupci.TopRowIndex;
                    
                    System.Data.DataRow row = dgrKupci.GetDataRow(dgrKupci.FocusedRowHandle);
                    if (row != null)
                    {
                        string sifrakar = row["kup_sifrakar"].ToString();
                        string brkart = row["kup_brkart"].ToString();

                        veza.ExecuteQuery(@"delete from kupci where kup_sifrakar=" + sifrakar + " and kup_brkart=" + brkart + "");

                        MessageBox.Show("Uspješno ste obrisali stavku !");

                        veza.ExecuteQuery("SELECT kup_brkart,kup_sifrakar,kup_oib,kup_prezime,kup_ime,po_sifra,kup_status,kup_datpop,statkar_st_sifra FROM kupci order by kup_brkart", ref podaci);
                        dgKupci.DataSource = podaci;

                        dgrKupci.TopRowIndex = topRowIndex;
                        
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

                       

        private List<int> SelectedRows = new List<int>(); 

        private void frmKupci_Load(object sender, EventArgs e)
        {
         
            try
            {
                veza.ExecuteQuery("SELECT kup_brkart,kup_sifrakar,kup_oib,kup_prezime,kup_ime,po_sifra,kup_status,kup_datpop,statkar_st_sifra FROM kupci order by kup_brkart", ref podaci);

                dgKupci.DataSource = podaci;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void dgrKupci_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if (e.IsGetData) e.Value = SelectedRows.Contains(e.RowHandle);
            //else if (e.IsSetData)
            //{
            //    if (Convert.ToBoolean(e.Value))
            //    {
            //        if (!SelectedRows.Contains(e.RowHandle)) SelectedRows.Add(e.RowHandle);
            //    }
            //    else if (SelectedRows.Contains(e.RowHandle)) SelectedRows.Remove(e.RowHandle);
            //}
        }
       

        private void btnKartica_Click(object sender, EventArgs e)
        {
            btnKartica.Enabled = false;

            try
            {
                tablica.Columns.Clear();
                tablica.Columns.Add("Broj kartice", typeof(string));
                tablica.Columns.Add("Prezime", typeof(string));
                tablica.Columns.Add("Ime", typeof(string));
                                

                for (int i = 0; i < dgrKupci.RowCount; i++)
                {
                    DataRow row = dgrKupci.GetDataRow(i);

                    if (row != null)
                    {
                        object unboundValue = dgrKupci.GetRowCellValue(i, "ispis");
                        bool dane = Convert.ToBoolean(unboundValue);
                    
                        if (dane == true)
                        {
                            String brkart = Convert.ToString(row["kup_brkart"]);
                            String prezime = Convert.ToString(row["kup_prezime"]);
                            String ime = Convert.ToString(row["kup_ime"]);

                            tablica.Rows.Add(brkart,prezime,ime);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnKartica.Enabled = true;
            }

            printaj();

            // uklanjanje oznaka za ispis

            DialogResult result;
            result = MessageBox.Show("Želite li ukloniti oznake za ispis ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dgrKupci.RowCount; i++)
                {
                    DataRow row = dgrKupci.GetDataRow(i);

                    if (row != null)
                    {
                        object unboundValue = dgrKupci.GetRowCellValue(i, "ispis");
                        bool dane = Convert.ToBoolean(unboundValue);

                        if (dane == true)
                        {
                            unboundValue = !(bool)unboundValue;
                            dgrKupci.SetRowCellValue(i, "ispis", unboundValue);
                        }
                    }
                }

                MessageBox.Show("Uspješno ste uklonili oznake !");
            }


            btnKartica.Enabled = true;
                        
        }


        private void printaj()
        {
            
                try
                {
                    //string skladisteBroj = txtSkladiste.Text;
                    //string brojNarudzbe = txtBrojNarudzbe.Text;
                    //string trgovina = txtNazivTrgovine.Text;
                    //string trgovinasifra = txtSifraTrgovine.Text;
                    //veza.ExecuteQuery("select poslovnica.po_ID, poslovnica.po_sifra, poslovnica.po_naziv, mjesto.mj_naziv, poslovnica.po_asortiman, poslovnica.po_cjenik from poslovnica, mjesto where mjesto.mj_ID = poslovnica.mjesto_mj_ID and poslovnica.po_aktivna = 1 and poslovnica.po_datumZatvaranja is null and (poslovnica.vp_sifra = 300 or  poslovnica.vp_sifra =200) and (poslovnica.po_cjenik <> '' or poslovnica.po_asortiman <> '') order by poslovnica.po_sifra asc", ref artikli);

                    
                        //create dataset 
                        DataSet FDataSet = new DataSet();

                        tablica.TableName = "Kupci";
                            

                        FDataSet.Tables.Add(tablica);

                        // create report instance
                        Report report = new Report();

                        System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                        string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                        report.Load(baseDir + "/report/Kartica.frx");

                        report.RegisterData(FDataSet);

                        //report.Design();
                        report.Show();
                        //report.ShowPrepared();
                        report.Dispose();
                        tablica = new DataTable();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void DoSplash()
        {
            frmSplash sp = new frmSplash();
            sp.ShowDialog();
        }

        private void btnKoverta_Click(object sender, EventArgs e)
        {
            btnKoverta.Enabled = false;

            try
            {
                tablica.Columns.Clear();
                tablica.Columns.Add("Ime", typeof(string));
                tablica.Columns.Add("Prezime", typeof(string));
                tablica.Columns.Add("Adresa", typeof(string));
                tablica.Columns.Add("Posta", typeof(string));
                tablica.Columns.Add("Mjesto", typeof(string));


                for (int i = 0; i < dgrKupci.RowCount; i++)
                {
                    DataRow row = dgrKupci.GetDataRow(i);

                    if (row != null)
                    {
                        object unboundValue = dgrKupci.GetRowCellValue(i, "ispis");
                        bool dane = Convert.ToBoolean(unboundValue);

                        if (dane == true)
                        {
                            String brkart = Convert.ToString(row["kup_brkart"]);
                            String prezime = Convert.ToString(row["kup_prezime"]);
                            String ime = Convert.ToString(row["kup_ime"]);

                            veza.ExecuteQuery("SELECT kup_adresa,kup_posta,kup_mjesto FROM kupci where kup_brkart=" + brkart + "", ref koverta);

                            if (koverta.Rows.Count > 0)
                            {
                                String adresa = Convert.ToString(koverta.Rows[0][0]);
                                String posta = Convert.ToString(koverta.Rows[0][1]);
                                String mjesto = Convert.ToString(koverta.Rows[0][2]);
                                
                                tablica.Rows.Add(ime,prezime,adresa,posta,mjesto);
                                //MessageBox.Show(adresa+posta+mjesto);
                            }
                                                  
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnKartica.Enabled = true;
            }

            printajkoverte();

            // uklanjanje oznaka za ispis

            DialogResult result;
            result = MessageBox.Show("Želite li ukloniti oznake za ispis ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dgrKupci.RowCount; i++)
                {
                    DataRow row = dgrKupci.GetDataRow(i);

                    if (row != null)
                    {
                        object unboundValue = dgrKupci.GetRowCellValue(i, "ispis");
                        bool dane = Convert.ToBoolean(unboundValue);

                        if (dane == true)
                        {
                            unboundValue = !(bool)unboundValue;
                            dgrKupci.SetRowCellValue(i, "ispis", unboundValue);    
                        }
                    }
                }

                MessageBox.Show("Uspješno ste uklonili oznake !");
            }

            btnKoverta.Enabled = true;
        }

        private void printajkoverte()
        {

            try
            {
                //create dataset 
                DataSet FDataSet = new DataSet();

                tablica.TableName = "Koverte";

                FDataSet.Tables.Add(tablica);

                // create report instance
                Report report = new Report();

                System.Reflection.Assembly a = System.Reflection.Assembly.GetEntryAssembly();
                string baseDir = System.IO.Path.GetDirectoryName(a.Location);

                report.Load(baseDir + "/report/Koverta.frx");

                report.RegisterData(FDataSet);

                //report.Design();
                report.Show();
                //report.ShowPrepared();
                report.Dispose();
                tablica = new DataTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOznaci_Click(object sender, EventArgs e)
        {
            try
            {                
                System.Data.DataRow row = dgrKupci.GetDataRow(dgrKupci.FocusedRowHandle);
                if (row != null)
                {
                    string sifrakar = row["kup_sifrakar"].ToString();
                    string brkart = row["kup_brkart"].ToString();

                    veza.ExecuteQuery(@"update kupci set kup_ispis=1  where kup_sifrakar=" + sifrakar + " and kup_brkart=" + brkart + "");
                                                            
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIspisKartice_Click(object sender, EventArgs e)
        {
            btnIspisKartice.Enabled = false;

            try
            {
                tablica.Columns.Clear();
                tablica.Columns.Add("Broj kartice", typeof(string));
                tablica.Columns.Add("Prezime", typeof(string));
                tablica.Columns.Add("Ime", typeof(string));
                
                veza.ExecuteQuery("SELECT kup_brkart,kup_ime,kup_prezime FROM kupci where kup_ispis=1", ref kartice);


                foreach (DataRow row in kartice.Rows)
                {
                    String brkart = row["kup_brkart"].ToString();
                    String prezime = row["kup_prezime"].ToString();
                    String ime = row["kup_ime"].ToString();

                    tablica.Rows.Add(brkart, prezime, ime);
                }
                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnIspisKartice.Enabled = true;
            }

            printaj();

            // uklanjanje oznaka za ispis

            DialogResult result;
            result = MessageBox.Show("Želite li ukloniti oznake za ispis ???", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {

                veza.ExecuteQuery("UPDATE Kupci SET kup_ispis=0 where kup_ispis=1", ref oznake);

                MessageBox.Show("Uspješno ste uklonili oznake !");
            }


            btnIspisKartice.Enabled = true;
        }
            
        
    }  
    
}
