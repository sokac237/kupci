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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void šifarnikKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKupci _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmKupci))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmKupci();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            //ssNazivFirme.Text = "Copyright © Informatika FORTUNO d.o.o. Vukovar";
            frmLogin _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmLogin))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmLogin();
            _frm.ShowDialog();
            _frm.TopMost = true;
                        
        }
                

        private void djecaPoGodištuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDjecaPregled _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmDjecaPregled))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmDjecaPregled();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void transakcijeKupcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransakcije _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmTransakcije))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmTransakcije();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void karticePoZahtjevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzradaKartice _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmIzradaKartice))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmIzradaKartice();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void rangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRangLista _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmRangLista))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmRangLista();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void kupnjeNaRođendanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRodjendan _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmRodjendan))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmRodjendan();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void strukturaRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRacuni _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmRacuni))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmRacuni();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void prodajaPoRGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdajaRG _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmProdajaRG))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmProdajaRG();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void zaradaPoArtikluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdajaArtik _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmProdajaArtik))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmProdajaArtik();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void frmGlavna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                DialogResult result;
                result = MessageBox.Show("Želite prijenos podataka u excel?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    Form activeChild = this.ActiveMdiChild;
                    // If there is an active child form, find the active control, which
                    // in this example should be a RichTextBox.
                    if (activeChild != null)
                    {
                        try
                        {
                            DevExpress.XtraGrid.GridControl tablica = (DevExpress.XtraGrid.GridControl)activeChild.ActiveControl;
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

        
        private void obračunToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmObracun _frm;
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType() == typeof(frmObracun))
                    {
                        childForm.Focus();
                        return;
                    }
                }
                _frm = new frmObracun();
                _frm.MdiParent = this;
                _frm.Show();
            
        }

        private void zaradaPoKupcuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZalkart _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmZalkart))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmZalkart();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void pregledPoMjestuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSms _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmSms))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmSms();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void stavkeRačunaPoStatusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStavkeRacuna _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmStavkeRacuna))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmStavkeRacuna();
            _frm.MdiParent = this;
            _frm.Show();
        }

        private void djelatniciPoMjesecimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDjelatnici _frm;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frmDjelatnici))
                {
                    childForm.Focus();
                    return;
                }
            }
            _frm = new frmDjelatnici();
            _frm.MdiParent = this;
            _frm.Show();
        }
        
    }
}
