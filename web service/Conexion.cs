using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Oracle.DataAccess.Client;
using System.Web.Services;
//using Oracle.DataAccess.Types;
using System.Data;
using System.Data.OracleClient;
//using Newtonsoft.Json;

namespace Webservice
{
    public class Conexion
    {
        OracleConnection conexion;
        string oradb = "data source= xe; password=12345678; user id= SYSTEM"; // establece conexion con el servidor
        public Conexion()
        {
        }

        public void EstablecerConnection()
        {
            conexion = new OracleConnection(oradb);
            conexion.Open();

        }

        public OracleConnection GetConexion()
        {
            return conexion;
        }
    }
}