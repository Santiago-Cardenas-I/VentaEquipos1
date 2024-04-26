using GestionDeVentasEquipos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionDeVentasEquipos
{
    public partial class AgregarEquipo : System.Web.UI.Page
    {


        private List<Equipos> listaEquipos = new List<Equipos>();





        protected void Limpiar()
        {
            txtTipoEquipo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtEspecificaciones.Text = string.Empty;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GridViewEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            listaEquipos = Equipos.DatosEquipos();
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4]
                {
                    new DataColumn("Tipo de Equipo", typeof(int)),
                    new DataColumn("Marca", typeof(string)),
                    new DataColumn("Precio", typeof(float)),
                    new DataColumn("Especificaciones", typeof(string)),
                });
                ViewState["Equipos"] = dt;

                if (ViewState["Equipos"] == null)
                {
                    ViewState["Equipos"] = Equipos.DatosEquipos();
                }
            }
        }
            protected void btnAgregar_Click(object sender, EventArgs e)

            {
                string TipoEquipo = txtTipoEquipo.Text;
                string Marca = txtMarca.Text;
                float Precio = Convert.ToSingle(txtPrecio.Text);
                string Especificaciones = txtEspecificaciones.Text;

                Equipos nuevoequipo = new Equipos(TipoEquipo, Marca, Precio, Especificaciones);
                listaEquipos.Add(nuevoequipo);


                DataTable dt = (DataTable)ViewState["Equipos"];
                dt.Rows.Add(TipoEquipo, Marca, Precio, Especificaciones);
                ViewState["Equipos"] = dt;

                GridViewEquipos.DataSource = dt;
                GridViewEquipos.DataBind();
            }
        }
    }
