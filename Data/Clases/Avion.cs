namespace ReservaVuelo.Data.Clases
{
    public class Avion
    {
        public Avion(string nombre, string marca, int anio)
        {
            Nombre = nombre;
            Marca = marca;
            Anio = anio;
        }

        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Anio { get; set; }
    }
}
