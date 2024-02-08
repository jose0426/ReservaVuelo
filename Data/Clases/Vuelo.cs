namespace ReservaVuelo.Data.Clases
{
	public class Vuelo
	{
		private int _ultimoId = 0;
		public Vuelo(DateTime fechaSalida, DateTime fechaLlegada, string puertaEmbarque, string lugarSalida, string lugarDestino, string estado, int asientoMaximo, int asientoDisponible, Avion avion, float precio, string? Url = @"/Img/AvionDeFrente.png")
		{
			FechaSalida = fechaSalida;
			FechaLlegada = fechaLlegada;
			PuertaEmbarque = puertaEmbarque;
			LugarSalida = lugarSalida;
			LugarDestino = lugarDestino;
			Estado = estado;
			AsientoMaximo = asientoMaximo;
			AsientoDisponible = asientoDisponible;
			this.avion = avion;
			Precio = precio;
			IdAvion = SetId();
			UrlImage = Url;
		}

		public int IdAvion { get; }
        public string UrlImage { get; set; }
        public DateTime FechaSalida { get; set; }
		public DateTime FechaLlegada { get; set; }
		public string PuertaEmbarque { get; set; }
		public string LugarSalida { get; set; }
		public string LugarDestino { get; set; }
		public string Estado { get; set; }
		public int AsientoMaximo { get; set; }
		public int AsientoDisponible { get; set; }
		public Avion avion { get; set; }
		public float Precio { get; set; }

		public int SetId()
		{
			_ultimoId++;
			return _ultimoId;
		}
	}
	public struct EstadoVuelo
	{
		public const string Activo = "Activo";
		public const string Cancelado = "Cancelado";
		public const string Retrasado = "Retrasado";
		public const string Completado = "Completado";
	}
}
