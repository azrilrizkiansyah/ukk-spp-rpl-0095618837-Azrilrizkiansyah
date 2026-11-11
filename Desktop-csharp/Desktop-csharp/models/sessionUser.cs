using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Desktop_csharp.views;

namespace Desktop_csharp.models
{
    internal class sessionUser
    {
       
        public  static int IdPetugas { get; set; }
        public static string Username { get; set; }
        public static string NamaPetugas { get; set; }
        public static string Level { get; set; }
        public  static bool IsLoggedIn { get; set; }

        public static void SetSession(string idPetugas,string username, string namaPetugas, string level )
        {
            IdPetugas = IdPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;

        }
        
        public static void ClearSession()
        {
            IdPetugas = 0;
            Username = null;
            NamaPetugas = null;
            Level = null;
            IsLoggedIn = false;
        }

        public void IsAdmin()
        {
           if(Level == "admin")
            {
                
            }
        }
    }
}
