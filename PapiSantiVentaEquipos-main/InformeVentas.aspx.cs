using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionDeVentasEquipos
{
    public partial class InformeVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = ddlProductos.SelectedValue;
            string memoriaSeleccionada = ddlMemorias.SelectedValue;
            string ssdSeleccionado = ddlSSD.SelectedValue;
            string resolucionPantalla = ddlResolucionPantalla.SelectedValue;
            string marcaMonitor = ddlMarcaMonitor.SelectedValue;
            string resolucionImpresion = ddlResolucionImpresora.SelectedValue;
            string marcaImpresora = ddlMarcaImpresora.SelectedValue;
            string marcaPc = ddlMarcaPc.SelectedValue;
            string estado = ddlEstado.SelectedValue;


            if (productoSeleccionado == "portatil")
            {
                lblResultado.Text = $"Has seleccionado: {productoSeleccionado}, {marcaPc}, {" memoria:" + memoriaSeleccionada}, {" disco solido:" + ssdSeleccionado}, {" estado:"+estado}";
            }
            else if (productoSeleccionado == "impresora")
            {
                lblResultado.Text = $"Has seleccionado: {productoSeleccionado}, {resolucionImpresion}, {marcaImpresora}, { "estado:"+estado}";
            }
            else if (productoSeleccionado == "monitor")
            {
                lblResultado.Text = $"Has seleccionado: {productoSeleccionado}, {resolucionPantalla}, {marcaMonitor}, {"estado:"+estado}";
            }
        }

        protected void ddlProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlProductos.SelectedValue)
            {
                case "portatil":
                    ddlMemorias.Visible = true;
                    ddlSSD.Visible = true;
                    ddlMarcaPc.Visible = true;
                    ddlEstado.Visible = true;

                    break;
                case "impresora":
                    ddlResolucionImpresora.Visible = true;
                    ddlMarcaImpresora.Visible = true;
                    ddlEstado.Visible = true;

                    break;
                case "monitor":
                    ddlResolucionPantalla.Visible = true;
                    ddlMarcaMonitor.Visible = true;
                    ddlEstado.Visible = true;
                    break;
            }
        }
    }
}