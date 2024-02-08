using ReservaVuelo.Data.Clases;
using System.Text.RegularExpressions;

namespace ReservaVuelo.Data
{
	public class GestorRegistros
	{
		public static List<Vuelo> vuelosRegistrados = new List<Vuelo>() {

		new Vuelo(new DateTime(2024, 2, 10, 10, 0, 0), new DateTime(2024, 3, 10, 12, 0, 0), "A1", "Madrid", "Barcelona", EstadoVuelo.Activo, 180, 150, new Avion("Boeing", "737", 200), 150.0f),
		new Vuelo(new DateTime(2024, 1, 10, 10, 0, 0), new DateTime(2024, 1, 11, 12, 0, 0), "A2", "Madrid", "Valencia", EstadoVuelo.Completado, 180, 150, new Avion("Airbus", "A320", 180), 120.0f),
		new Vuelo(new DateTime(2024, 3, 11, 14, 0, 0), new DateTime(2024, 3, 11, 16, 0, 0), "B3", "Sevilla", "Málaga", EstadoVuelo.Activo, 120, 100, new Avion("Boeing", "747", 400), 200.0f),
		 new Vuelo(new DateTime(2024, 3, 12, 20, 0, 0), new DateTime(2024, 3, 13, 2, 0, 0), "C4", "Valencia", "Palma de Mallorca", EstadoVuelo.Cancelado, 150, 0, new Avion("Airbus", "A380", 550), 250.0f),
		 new Vuelo(new DateTime(2024, 3, 14, 8, 0, 0), new DateTime(2024, 3, 14, 10, 0, 0), "D5", "Bilbao", "Santander", EstadoVuelo.Activo, 100, 80, new Avion("Boeing", "787", 350), 180.0f),
		 new Vuelo(new DateTime(2024, 3, 15, 12, 0, 0), new DateTime(2024, 3, 15, 14, 0, 0), "E6", "Granada", "Almería", EstadoVuelo.Retrasado, 60, 40, new Avion("ATR", "72", 70), 80.0f),
		 new Vuelo(new DateTime(2024, 3, 16, 16, 0, 0), new DateTime(2024, 3, 16, 18, 0, 0), "F7", "Zaragoza", "La Coruña", EstadoVuelo.Activo, 150, 120, new Avion("Embraer", "195", 120), 90.0f),
		 new Vuelo(new DateTime(2024, 3, 17, 20, 0, 0), new DateTime(2024, 3, 18, 2, 0, 0), "G8", "Murcia", "Ibiza", EstadoVuelo.Activo, 200, 150, new Avion("Boeing", "737", 200), 150.0f),
		 new Vuelo(new DateTime(2024, 3, 18, 10, 0, 0), new DateTime(2024, 3, 18, 12, 0, 0), "H9", "Tenerife", "Lanzarote", EstadoVuelo.Activo, 180, 160, new Avion("Airbus", "A320", 180), 120.0f)
		};


		public static List<Perfil> perfilesRegistrados = new List<Perfil>(){
  new Perfil("Augusto","1234")
	};

		public static void AddTicketToProfile(Vuelo vuelo, Perfil perfil)
		{
			perfil.AddVuelo(vuelo);
		}
		public static void RemoveTicketToProfile(Vuelo vuelo, Perfil perfil)
		{
			perfil.DeleteVuelo(vuelo);
		}




	}

}

