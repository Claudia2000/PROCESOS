using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Web.Services;
using Webservice;
using Newtonsoft.Json;

namespace ejemplo
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //Cliente
        [WebMethod(BufferResponse = true)]
        public string Mostrar_cliente()
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Cursor;
            cmd.CommandText = "list_cliente";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("c_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            return JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented);
        }
        [WebMethod(BufferResponse = true)]
        public void Eliminar_cliente(int ide)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value=ide;
            cmd.CommandText = "delete_cliente";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idp", OracleType.Number).Value = param_name.Value;
            cmd.ExecuteNonQuery();    
        }
        [WebMethod(BufferResponse = true)]
        public void Agregar_cliente(int ide, string nombre, string direccion,int celular,string usuario,string contras)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = ide;
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = nombre;
            OracleParameter param_name3 = new OracleParameter();
            param_name3.OracleType = OracleType.VarChar;
            param_name3.Value = direccion;
            OracleParameter param_name4 = new OracleParameter();
            param_name4.OracleType = OracleType.Number;
            param_name4.Value = celular;
            OracleParameter param_name5 = new OracleParameter();
            param_name5.OracleType = OracleType.VarChar;
            param_name5.Value = usuario;
            OracleParameter param_name6 = new OracleParameter();
            param_name6.OracleType = OracleType.VarChar;
            param_name6.Value = contras;
            cmd.CommandText = "add_cliente";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idclientee", OracleType.Number).Value = param_name.Value;
            cmd.Parameters.Add("nombre", OracleType.VarChar).Value = param_name2.Value;
            cmd.Parameters.Add("direccion", OracleType.VarChar).Value = param_name3.Value;
            cmd.Parameters.Add("celular", OracleType.Number).Value = param_name4.Value;
            cmd.Parameters.Add("usuario", OracleType.VarChar).Value = param_name5.Value;
            cmd.Parameters.Add("contras", OracleType.VarChar).Value = param_name6.Value;
            cmd.ExecuteNonQuery();    
        }
        [WebMethod(BufferResponse = true)]
        public void Actualizar_cliente(int ide,string nombre,string direccion,int celular,string usuario,string contras)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = ide;
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = nombre;
            OracleParameter param_name3 = new OracleParameter();
            param_name3.OracleType = OracleType.VarChar;
            param_name3.Value = direccion;
            OracleParameter param_name4 = new OracleParameter();
            param_name4.OracleType = OracleType.Number;
            param_name4.Value = celular;
            OracleParameter param_name5 = new OracleParameter();
            param_name5.OracleType = OracleType.VarChar;
            param_name5.Value = usuario;
            OracleParameter param_name6 = new OracleParameter();
            param_name6.OracleType = OracleType.VarChar;
            param_name6.Value = contras;
            cmd.CommandText = "update_cliente";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idclientee", OracleType.Number).Value = param_name.Value;
            cmd.Parameters.Add("nombre", OracleType.VarChar).Value = param_name2.Value;
            cmd.Parameters.Add("direccion", OracleType.VarChar).Value = param_name3.Value;
            cmd.Parameters.Add("celular", OracleType.Number).Value = param_name4.Value;
            cmd.Parameters.Add("usuario", OracleType.VarChar).Value = param_name5.Value;
            cmd.Parameters.Add("contras", OracleType.VarChar).Value = param_name6.Value;
            cmd.ExecuteNonQuery();
        }
        //Tipo de prenda
        [WebMethod(BufferResponse = true)]
        public string Mostrar_tipo_prenda()
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Cursor;
            cmd.CommandText = "list_tipo_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("c_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            return JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented);
        }
        [WebMethod(BufferResponse = true)]
        public void Eliminar_tipo_prenda(int ide)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = ide;
            cmd.CommandText = "delete_tipo_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idt", OracleType.Number).Value = param_name.Value;
            cmd.ExecuteNonQuery();
        }
        [WebMethod(BufferResponse = true)]
        public void Agregar_tipo_prenda(int idee, string tipo, string descrip)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = idee;
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = tipo;
            OracleParameter param_name3 = new OracleParameter();
            param_name3.OracleType = OracleType.VarChar;
            param_name3.Value = descrip;
            cmd.CommandText = "add_tipo_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idee", OracleType.Number).Value = param_name.Value;
            cmd.Parameters.Add("tipo", OracleType.VarChar).Value = param_name2.Value;
            cmd.Parameters.Add("descrip", OracleType.VarChar).Value = param_name3.Value;
            cmd.ExecuteNonQuery();
        }
        [WebMethod(BufferResponse = true)]
        public void Actualizar_tipo_prenda(int idee, string tipo, string descrip)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = idee;
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = tipo;
            OracleParameter param_name3 = new OracleParameter();
            param_name3.OracleType = OracleType.VarChar;
            param_name3.Value = descrip;
            cmd.CommandText = "update_tipo_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idee", OracleType.Number).Value = param_name.Value;
            cmd.Parameters.Add("tipo", OracleType.VarChar).Value = param_name2.Value;
            cmd.Parameters.Add("descrip", OracleType.VarChar).Value = param_name3.Value;
            cmd.ExecuteNonQuery();
        }
        //Prenda
        [WebMethod(BufferResponse = true)]
        public string Mostrar_prenda()
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Cursor;
            cmd.CommandText = "list_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("c_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            return JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented);
        }
        [WebMethod(BufferResponse = true)]
        public void Eliminar_prenda(int ide)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = ide;
            cmd.CommandText = "delete_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("idp", OracleType.Number).Value = param_name.Value;
            cmd.ExecuteNonQuery();
        }
        [WebMethod(BufferResponse = true)]
        public void Agregar_prenda(int ide, string nombre,float precio,string color,int stock,string talla,int idtipo)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = ide;
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = nombre;
            OracleParameter param_name3 = new OracleParameter();
            param_name3.OracleType = OracleType.Float;
            param_name3.Value = precio;
            OracleParameter param_name4 = new OracleParameter();
            param_name4.OracleType = OracleType.VarChar;
            param_name4.Value = color;
            OracleParameter param_name5 = new OracleParameter();
            param_name5.OracleType = OracleType.Number;
            param_name5.Value = stock;
            OracleParameter param_name6 = new OracleParameter();
            param_name6.OracleType = OracleType.VarChar;
            param_name6.Value = talla;
            OracleParameter param_name7 = new OracleParameter();
            param_name7.OracleType = OracleType.Number;
            param_name7.Value = idtipo;
            cmd.CommandText = "add_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ide", OracleType.Number).Value = param_name.Value;
            cmd.Parameters.Add("nombre", OracleType.VarChar).Value = param_name2.Value;
            cmd.Parameters.Add("precio", OracleType.Float).Value = param_name3.Value;
            cmd.Parameters.Add("color", OracleType.VarChar).Value = param_name4.Value;
            cmd.Parameters.Add("stock", OracleType.Number).Value = param_name5.Value;
            cmd.Parameters.Add("talla", OracleType.VarChar).Value = param_name6.Value;
            cmd.Parameters.Add("idtipo", OracleType.Number).Value = param_name7.Value;
            cmd.ExecuteNonQuery();
        }
        [WebMethod(BufferResponse = true)]
        public void Actualizar_prenda(int ide,string nombre,float precio,string color,int stock,string talla,int idtipo)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Number;
            param_name.Value = ide;
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = nombre;
            OracleParameter param_name3 = new OracleParameter();
            param_name3.OracleType = OracleType.Float;
            param_name3.Value = precio;
            OracleParameter param_name4 = new OracleParameter();
            param_name4.OracleType = OracleType.VarChar;
            param_name4.Value = color;
            OracleParameter param_name5 = new OracleParameter();
            param_name5.OracleType = OracleType.Number;
            param_name5.Value = stock;
            OracleParameter param_name6 = new OracleParameter();
            param_name6.OracleType = OracleType.VarChar;
            param_name6.Value = talla;
            OracleParameter param_name7 = new OracleParameter();
            param_name7.OracleType = OracleType.Number;
            param_name7.Value = idtipo;
            cmd.CommandText = "update_prenda";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("ide", OracleType.Number).Value = param_name.Value;
            cmd.Parameters.Add("nombre", OracleType.VarChar).Value = param_name2.Value;
            cmd.Parameters.Add("precio", OracleType.Float).Value = param_name3.Value;
            cmd.Parameters.Add("color", OracleType.VarChar).Value = param_name4.Value;
            cmd.Parameters.Add("stock", OracleType.Number).Value = param_name5.Value;
            cmd.Parameters.Add("talla", OracleType.VarChar).Value = param_name6.Value;
            cmd.Parameters.Add("idtipo", OracleType.Number).Value = param_name7.Value;
            cmd.ExecuteNonQuery();
        }
        [WebMethod(BufferResponse = true)]
        public int Login(String usuario, String contra)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_usu = new OracleParameter();
            param_usu.OracleType = OracleType.VarChar;
            param_usu.Value = usuario;

            OracleParameter param_contra = new OracleParameter();
            param_contra.OracleType = OracleType.VarChar;
            param_contra.Value = contra;

            cmd.Connection = conn.GetConexion();
            cmd.CommandText = "loginn";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("usuario", OracleType.VarChar).Value = param_usu.Value;
            cmd.Parameters.Add("contras", OracleType.VarChar).Value = param_contra.Value;
            cmd.Parameters.Add("rpt", OracleType.Number).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            int respuesta = int.Parse(cmd.Parameters["rpt"].Value.ToString());
            return respuesta;
        }
        [WebMethod(BufferResponse = true)]
        public string Generar_reporte(String tipo)
        {
            Conexion conn = new Conexion();
            conn.EstablecerConnection();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn.GetConexion();

            OracleParameter param_name = new OracleParameter();
            param_name.OracleType = OracleType.Cursor;
            cmd.CommandText = "reporte1";
            OracleParameter param_name2 = new OracleParameter();
            param_name2.OracleType = OracleType.VarChar;
            param_name2.Value = tipo;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("c_cursor", OracleType.Cursor).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("tipo", OracleType.VarChar).Value = param_name2.Value;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);
            return JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented);

        }
    }
}
