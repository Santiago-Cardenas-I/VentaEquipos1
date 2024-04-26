using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDeVentasEquipos.Clases
{
    public class Impresora : Equipos
    {
        private string TipoConexion;
        private string Resolucion;
        public Impresora(string Marca, string Especificaciones, float Precio, string tipoConexion, string resolucion, string TipoEquipo)
           : base(Marca, Especificaciones, Precio , TipoEquipo)
        {
            TipoConexion1 = tipoConexion;
            Resolucion1 = resolucion;
        }

        public string TipoConexion1 { get => TipoConexion; set => TipoConexion = value; }
        public string Resolucion1 { get => Resolucion; set => Resolucion = value; }
    }
}