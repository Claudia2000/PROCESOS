using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Visual
{
    public partial class Prenda : Page
    {
        Visual.ServiceReference3.WebService1SoapClient obj = new Visual.ServiceReference3.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        protected void btnList_Click(object sender, EventArgs e)
        {
            String final;
            final = obj.Mostrar_prenda();
            DataTable ds = JObject.Parse(final)["Table"].ToObject<DataTable>();
        }

        protected void BindGrid()
        {
            String final;
            final = obj.Mostrar_prenda();
            DataTable ds = JObject.Parse(final)["Table"].ToObject<DataTable>();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void Insert(object sender, EventArgs e)
        {
            string ide = txtId.Text;
            string prenda = txtPrenda.Text;
            string precio = txtPrecio.Text;
            string color = txtColor.Text;
            string stock = txtStock.Text;
            string talla = txtTalla.Text;
            string tipo = txtIdTipo.Text;
            float precio1 = float.Parse(precio);
            int num_ide = Int32.Parse(ide);
            int num_tipo = Int32.Parse(tipo);
            int num_stock = Int32.Parse(stock);
            obj.Agregar_prenda(num_ide, prenda,precio1,color,num_stock,talla,num_tipo);

            this.BindGrid();
        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }
        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int customerId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string prend = (row.FindControl("txtPrenda") as TextBox).Text;
            float prec = float.Parse((row.FindControl("txtPrecio") as TextBox).Text);
            
            string color = (row.FindControl("txtColor") as TextBox).Text;
            string stock = (row.FindControl("txtStock") as TextBox).Text;
            int stock1 = Int32.Parse(stock);
            string talla = (row.FindControl("txtTalla") as TextBox).Text;
            string idtip = (row.FindControl("txtIdTipo") as TextBox).Text;
            int idtipo = Int32.Parse(idtip);
            obj.Actualizar_prenda(customerId, prend, prec,color,stock1,talla,idtipo);

            GridView1.EditIndex = -1;
            this.BindGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            GridView1.EditIndex = -1;
            this.BindGrid();
        }
        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int customerId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            obj.Eliminar_prenda(customerId);
            this.BindGrid();
        }


        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}