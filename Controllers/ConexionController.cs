using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Oracle.ManagedDataAccess.Client;

namespace ProyectLibrary.Controllers
{
    public class ConexionController
    {
        string connectionString = "Data Source=JOSHUAPC\\JOSHUAPC;Initial Catalog=BIBLIOTECA;Integrated Security=True";
        SqlServerConnection cn = new SqlServerConnection(connectionString);

        cn.Open();

        return cn;


        public void Dispose() 
        {
            cn.Close();
            return cn;
        }
        
    }
}