using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace ProyectLibrary.Controllers
{
    public class ConexionController
    {
        string connectionString = "Data Source=JOSHUAPC\\JOSHUAPC;Initial Catalog=BIBLIOTECA;Integrated Security=True";
        SqlServerConnection cn = new SqlServerConnection();
        
        public static SqlServerConnection GetConnection()
        {
            //string connectionString = "Data Source=JOSHUAPC\\JOSHUAPC;Initial Catalog=BIBLIOTECA;Integrated Security=True";
            //SqlServerConnection cn = new SqlServerConnection();
            cn.Open();
            return cn;
        }
        
        public static void Dispose() 
        {   
            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
                return cn;
            }
        }
        
        /*
        public static void Dispose(SqlConnection cn) 
        {   
            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
                return cn;
            }
        }
        */
        
    }
}
