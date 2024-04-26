namespace GestionDeVentasEquipos.Clases
{
    public class Monitores : Equipos
    {
        private string TipoConexionPantallas;
        private string ResolucionPantallas;

        public Monitores(string tipoConexionPantallas, string resolucionPantallas, string Marca, string TipoEquipo, string Especificaciones, float Precio)
            : base(Marca, TipoEquipo, Precio , Especificaciones)
        {
            TipoConexionPantallas = tipoConexionPantallas;
            ResolucionPantallas = resolucionPantallas;
        }

        public string TipoConexionPantallas1 { get => TipoConexionPantallas; set => TipoConexionPantallas = value; }
        public string ResolucionPantallas1 { get => ResolucionPantallas; set => ResolucionPantallas = value; }
    }
}