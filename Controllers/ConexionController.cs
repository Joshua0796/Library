using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
//using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ProyectLibrary.Controllers
{
    public class ConexionController
    {
        //string connectionString = "Data Source=JOSHUAPC\\JOSHUAPC;Initial Catalog=BIBLIOTECA;Integrated Security=True";
        //SqlServerConnection cn = new SqlServerConnection(connectionString);

        public static OracleConnection GetConnection()
        {
            string connectionString = "Data Source=JOSHUAPC\\JOSHUAPC;Initial Catalog=BIBLIOTECA;Integrated Security=True";
            OracleConnection cn = new OracleConnection(connectionString);
            
            //SqlServerConnection cn = new SqlServerConnection(connectionString);
            cn.Open();
            return cn;
        }
        
        public static void Dispose(OracleConnection cn) 
        {   
            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
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
