using System.Collections.Generic;

namespace GestionDeVentasEquipos.Clases
{
    public class Equipos
    {
        protected string Marca { get; set; }
        protected float Precio { get; set; }
        protected string Especificaciones { get; set; }
        protected string TipoEquipo { get; set; }

        public Equipos(string tipoEquipo, string marca, float precio, string especificaciones)
        {
            TipoEquipo = tipoEquipo;
            Marca = marca;
            Precio = precio;
            Especificaciones = especificaciones;
        }

        public static List<Equipos> DatosEquipos()
        {
            List<Equipos> equipos = new List<Equipos>();

            // Agregar datos estáticos de portátiles
            equipos.Add(new Equipos("Portátil", "Dell", 1200f, "15 pulgadas, 8GB RAM, 256GB SSD"));
            equipos.Add(new Equipos("Portátil", "HP", 1100f, "13 pulgadas, 16GB RAM, 512GB SSD"));
            equipos.Add(new Equipos("Portátil", "Lenovo", 1000f, "14 pulgadas, 12GB RAM, 1TB HDD"));

            // Agregar datos estáticos de impresoras
            equipos.Add(new Equipos("Impresora", "Epson", 300f, "Impresión a color, WiFi, escáner"));
            equipos.Add(new Equipos("Impresora", "HP", 250f, "Impresión láser, blanco y negro, USB"));
            equipos.Add(new Equipos("Impresora", "Canon", 200f, "Impresión a color, inalámbrica, compacta"));

            // Agregar datos estáticos de monitores
            equipos.Add(new Equipos("Monitor", "Samsung", 400f, "27 pulgadas, 4K, IPS"));
            equipos.Add(new Equipos("Monitor", "LG", 350f, "24 pulgadas, Full HD, LED"));
            equipos.Add(new Equipos("Monitor", "Dell", 500f, "32 pulgadas, QHD, curvo"));

            return equipos;
        }
    }
}


