using System;
namespace Clase16.Modelo
{
	public sealed class Desempleado: Persona
	{
        public string UltimaOcupacion { get; set; }

        public string UltimaEmpresa { get; set; }

        public bool EsDiscapacitado { get; set; }

        public int ObtenerValorDePension()
        {
            if (EsDiscapacitado)
            {
                return 13000;
            }
            else
            {
                return 10000;
            }
        }
    }
}

