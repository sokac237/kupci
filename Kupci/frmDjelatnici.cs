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
    public partial class frmDjelatnici : Form
    {
        Upiti veza = new Upiti();
        DataTable podaci = new DataTable();
        
        public frmDjelatnici()
        {
            InitializeComponent();
        }
               
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmDjelatnici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnPokaži_Click(object sender, EventArgs e)
        {
            btnPokazi.Enabled = false;
            try
            {
                veza.ExecuteQuery("select tra_godina,kupci.kup_sifrakar, kupci.kup_ime, kupci.kup_prezime,kupci.po_sifra, poslovnica.po_naziv,kup_telefon1,kup_telefon2," +
                                  "sum(transakcije.tra_iznos) as ukupno," +
                                  "SUM(IF(month(tra_datum)=01, tra_iznos,0)) AS `siječanj`," +
                                  "SUM(IF(month(tra_datum)=02, tra_iznos,0)) AS `veljača`," +
                                  "SUM(IF(month(tra_datum)=03, tra_iznos,0)) AS `ožujak`," +
                                  "SUM(IF(month(tra_datum)=04, tra_iznos,0)) AS `travanj`," +
                                  "SUM(IF(month(tra_datum)=05, tra_iznos,0)) AS `svibanj`," +
                                  "SUM(IF(month(tra_datum)=06, tra_iznos,0)) AS `lipanj`," +
                                  "SUM(IF(month(tra_datum)=07, tra_iznos,0)) AS `srpanj`," +
                                  "SUM(IF(month(tra_datum)=08, tra_iznos,0)) AS `kolovoz`," +
                                  "SUM(IF(month(tra_datum)=09, tra_iznos,0)) AS `rujan`," +
                                  "SUM(IF(month(tra_datum)=10, tra_iznos,0)) AS `listopad`," +
                                  "SUM(IF(month(tra_datum)=11, tra_iznos,0)) AS `studeni`," +
                                  "SUM(IF(month(tra_datum)=12, tra_iznos,0)) AS `prosinac` " +
                                  "from transakcije " +
                                  "left join kupci on transakcije.kupci_id_kupci1=kupci.id_kupci " +
                                  "left outer join poslovnica on kupci.po_sifra=poslovnica.po_sifra " +
                                  "where kupci.statkar_ST_SIFRA='04' and kupci.kup_oib is not null " +
                                  "group by 1,2", ref podaci);

                if (podaci.Rows.Count > 0)
                {
                    dgDjelatnici.DataSource = podaci;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnPokazi.Enabled = true;
        }
                             
    }
}
