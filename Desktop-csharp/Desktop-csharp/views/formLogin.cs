using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_csharp.config;
using MySql.Data.MySqlClient;

namespace Desktop_csharp.views
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterPetugas pindah =  new FormRegisterPetugas();
            pindah.FormClosed += Pindah_FormClosed;
            pindah.Show();
            this.Hide();
        }

        private void Pindah_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Focus();
            }
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Focus();
            }
            MySqlConnection conn = koneksi.Getconnection();
            try 
            { 
                
            } 
            catch ()
            {

            }
                
        }
    }
}
