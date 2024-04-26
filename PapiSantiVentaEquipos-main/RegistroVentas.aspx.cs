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
    public partial class impresoras : System.Web.UI.Page
    {
        private int contador = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            // inicializa el contador de ventas en 0.
            ViewState["ContadorVentas"] = 0;
        }

       

        protected void ddlProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (ddlProductos.SelectedValue)
            {
                case "portatil":
                    ddlMemorias.Visible = true;
                    ddlSSD.Visible = true;
                    ddlMarcaPc.Visible = true;
                    break;
                case "impresora":
                    ddlResolucionImpresora.Visible = true;
                    ddlMarcaImpresora.Visible = true;
                    break;
                case "monitor":
                    ddlResolucionPantalla.Visible = true;
                    ddlMarcaMonitor.Visible = true;
                    break;
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            
            string productoSeleccionado = ddlProductos.SelectedValue;
            string memoriaSeleccionada = ddlMemorias.SelectedValue;
            string ssdSeleccionado = ddlSSD.SelectedValue;
            string resolucionPantalla = ddlResolucionPantalla.SelectedValue;
            string marcaMonitor = ddlMarcaMonitor.SelectedValue;
            string resolucionImpresion = ddlResolucionImpresora.SelectedValue;
            string marcaImpresora = ddlMarcaImpresora.SelectedValue;
            string marcaPc = ddlMarcaPc.SelectedValue;


            
            if (productoSeleccionado == "portatil")
            {
                lblResultado.Text = $"Has seleccionado: {productoSeleccionado}, {marcaPc}, {" memoria:" + memoriaSeleccionada}, {" disco solido:" + ssdSeleccionado}";
            }
            else if (productoSeleccionado == "impresora")
            {
                lblResultado.Text = $"Has seleccionado: {productoSeleccionado}, {resolucionImpresion}, {marcaImpresora}";
            }
            else if (productoSeleccionado == "monitor")
            {
                lblResultado.Text = $"Has seleccionado: {productoSeleccionado}, {resolucionPantalla}, {marcaMonitor}";
            }


            
            int contadorVentas = (int)ViewState["ContadorVentas"];
            contadorVentas++;
            ViewState["ContadorVentas"] = contadorVentas;

            lblContador.Text = contadorVentas.ToString();


        }

        }
    }

