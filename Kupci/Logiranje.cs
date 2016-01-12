﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kupci
    {
    public partial class frmLogin : Form
    {
        Upiti veza = new Upiti();
               

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Logiranje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtKorisnickoIme_Enter(object sender, EventArgs e)
        {
            txtKorisnickoIme = sender as TextBox;
            if (txtKorisnickoIme != null)
                txtKorisnickoIme.SelectAll();
        }

        private void txtLozinka_Enter(object sender, EventArgs e)
        {
            txtLozinka = sender as TextBox;
            if (txtLozinka != null)
                txtLozinka.SelectAll();
        }

        private void Prijava()
        {
            DataTable Korisnik = new DataTable();

            veza.ExecuteQuery("SELECT * from boso2011.operater", ref Korisnik);
            if (Korisnik.Rows.Count <= 0)
            {
                MessageBox.Show("Nema autoriziranih korisnika! Dodajte korisnika u bazu.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //autorizacija
            {
                DataTable dt = new DataTable();
                veza.ExecuteQuery("select * from boso2011.operater where  op_sifra = '" + txtKorisnickoIme.Text + "' AND op_lozinka = '" + txtLozinka.Text + "'", ref dt);

                if (dt.Rows.Count > 0 && dt.Rows[0][1].ToString() == txtKorisnickoIme.Text && dt.Rows[0][2].ToString() == txtLozinka.Text && dt.Rows[0][5].ToString() == "True")
                {
                    Global.Korisnik = Convert.ToString(dt.Rows[0][3] + " " + dt.Rows[0][4].ToString());
                    Global.KorisnikID = dt.Rows[0][0].ToString();
                    Global.NivoKorisnika = dt.Rows[0][6].ToString();

                    
                    if (Convert.ToInt32(Global.NivoKorisnika) > 4)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nemate prava za rad u programu!");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Niste upisali točne korisničke podatke!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                    txtKorisnickoIme.Focus();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Prijava();
        }

      
    }
}
