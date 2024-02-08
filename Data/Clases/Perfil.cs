namespace ReservaVuelo.Data.Clases
{
	public class Perfil
	{
		public Perfil(string nombre, string password)
		{
			Nombre = nombre;
			Password = password;
			Vuelos = new List<Vuelo>();
		}

		public string Nombre { get; set; }
		public string Password { get; set; }
		private List<Vuelo> Vuelos { get; }

		public List<Vuelo> GetVuelos()
		{
			return Vuelos;
		}
		public void AddVuelo(Vuelo add)
		{
			Vuelos.Add(add);
			add.AsientoDisponible -= 1;
		}
		public void DeleteVuelo(Vuelo remove)
		{
			Vuelos.Remove(remove);
			remove.AsientoDisponible += 1;

		}
	}
}
