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
    public partial class About : Page
    {
        int a, b, c;
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
            final = obj.Mostrar_cliente();
            DataTable ds = JObject.Parse(final)["Table"].ToObject<DataTable>();
        }

        protected void BindGrid()
        {
            String final;
            final = obj.Mostrar_cliente();
            DataTable ds = JObject.Parse(final)["Table"].ToObject<DataTable>();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Insert(object sender, EventArgs e)
        {
            string ide = txtId.Text;
            string name = txtName.Text;
            string dir = txtDireccion.Text;
            string cel = txtCelular.Text;
            string usu = txtUsuario.Text;
            string contra = txtContrasena.Text;
            int num_ide = Int32.Parse(ide);
            int num_cel = Int32.Parse(cel);
            obj.Agregar_cliente(num_ide, name, dir, num_cel,usu,contra);

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

            string name = (row.FindControl("txtname") as TextBox).Text;
            string direc = (row.FindControl("txtDireccion") as TextBox).Text;
            string cel = (row.FindControl("txtCelular") as TextBox).Text;
            string usu= (row.FindControl("txtUsuario") as TextBox).Text;
            string contra = (row.FindControl("txtContrasena") as TextBox).Text;
            int num_cel = Int32.Parse(cel);
            
            obj.Actualizar_cliente(customerId, name, direc, num_cel,usu,contra);

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
            obj.Eliminar_cliente(customerId);
            this.BindGrid();
        }


        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
        /*protected void OnDataBound(object sender, EventArgs e)
        {
            GridView1.Rows.Cells[0].Visible = false;
        }*/

    }
}