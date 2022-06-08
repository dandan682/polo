using System;
namespace Constructores.Modelo
{
	internal class Persona
	{
		public string NombreCompleto { get; set; }
		public string NumeroDocumento { get; set; }
		public int Edad { get; set; }
        public bool EstaCasado { get; set; }

        public Persona()
		{
			Console.WriteLine($"Se ha instanciado una nueva persona");
	    }

		public Persona(string nombreCompleto, string numeroDocumento, int edad, bool estaCasado)
		{
			NombreCompleto = nombreCompleto;
			NumeroDocumento = numeroDocumento;
			Edad = edad;
			EstaCasado = estaCasado;
		}

		public string ObtenerSaludo()
		{
			return $"Hola! Soy {NombreCompleto}";
		}

		public string ObtenerSaludo(string nombrePersonaAQuienSaludar)
		{
			return $"Hola {nombrePersonaAQuienSaludar}, soy {NombreCompleto}";
		}
	}
}