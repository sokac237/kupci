﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kupci
{
    public partial class frmZalkart : Form
    {
        Upiti veza = new Upiti();
        DataTable podaciposlovnice = new DataTable();
        DataTable podacitransakcije = new DataTable();
        DataTable podacikatalog = new DataTable();

        MySqlConnection connection = new MySqlConnection();
        string ConnectionString;
        MySqlCommand upit1 = new MySqlCommand();

        string datumOD;
        string datumDO;
        string katalog, ipadresa, baza;

        public frmZalkart()
        {
            InitializeComponent();
        }

        private void frmZalkart_Load(object sender, EventArgs e)
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

        private void frmZalkart_KeyDown(object sender, KeyEventArgs e)
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

            if (glPoslovnica.Text != "" && dtOd.Value != null && dtDo.Value != null)
            {

                datumOD = Convert.ToDateTime(dtOd.Text).ToString("yyyyMMdd");
                datumDO = Convert.ToDateTime(dtDo.Text).ToString("yyyyMMdd");

                try
                {
                    //katalog
                    veza.ExecuteQuery("SELECT po_ipadresa,po_katalog from boso2011.poslovnica where po_sifra='" + glPoslovnica.EditValue + "'", ref podacikatalog);
                    ipadresa = Convert.ToString(podacikatalog.Rows[0][0]);
                    baza = Convert.ToString(podacikatalog.Rows[0][1]);
                    katalog = "`" + Convert.ToString(podacikatalog.Rows[0][1]) + "`";

                    connection = new MySqlConnection();
                    ConnectionString = "Server = " + ipadresa + "; Database=" + baza + "; Uid=admin10; Pwd=movema10;";
                    connection.ConnectionString = ConnectionString;

                    connection.Open();

                    podacitransakcije.Clear();

                    MySqlCommand upit1 = new MySqlCommand("select k.kup_sifrak as 'Šifra',k.kup_prezime as 'Prezime',k.kup_ime as 'Ime',sum(z.ra_kolicina*z.ra_cijena) as 'Promet'," +
                                     "SUM(IF(ra_cijena=ra_maloprodcijena, (z.ra_kolicina*z.ra_cijena),0)) AS 'Nema popust',"+
                                     "SUM(IF(ra_cijena<ra_maloprodcijena, (z.ra_kolicina*z.ra_cijena),0)) AS 'Ima popust',"+
                                     "sum(z.ra_ruc) as 'Zarada' from " + katalog + ".zalkart z, " + katalog + ".kupci k where z.tra_kartic = k.kup_brkart "+
                                     "and str_to_date(z.tra_dansat, '%Y%m%d')>='" + datumOD + "' and str_to_date(z.tra_dansat, '%Y%m%d')<='" + datumDO + "' "+
                                     "group by 1,2,3 order by 4 desc", connection);

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
                    btnPrikazi.Enabled = true;
                }

            }           

            btnPrikazi.Enabled = true;
        }
    }
}
