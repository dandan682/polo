using System;
namespace Clase16.Modelo
{
	public class Persona
	{
        private DateTime _fechaNacimiento;

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string FechaNacimiento
        {
            get
            {
                return _fechaNacimiento.ToString("dd/MM/yyyy");
            }
            set
            {

            }
        }

        public string NumeroDeDocumento { get; set; }


        public Persona()
		{
		}
	}
}

