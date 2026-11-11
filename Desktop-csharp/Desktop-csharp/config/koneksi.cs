using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Desktop_csharp.config
{
    internal class koneksi
    {
        public static string konfigurasi = "server=localhost;username=root;port=3306;database=db_spp_sekolah_xii;password=";

        public static MySqlConnection Getconnection()
        {
           
            MySqlConnection koneksi = new MySqlConnection(konfigurasi);
            try 
            { 
                koneksi.Open();
                return null;
                
            } 
            catch(Exception e)
            {
                MessageBox.Show("koneksi gagal coba cek kembali koneksi Anda",e.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return null;
        }
        
    }
}
