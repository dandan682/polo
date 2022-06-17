using System;
namespace Clase16.Modelo
{
	public class Persona
	{
        private DateTime _fechaNacimiento;
        private int _numeroDeDocumento;

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
                _fechaNacimiento = Convert.ToDateTime(value);
            }
        }

        public string NumeroDeDocumento
        {
            get
            {
                return _numeroDeDocumento.ToString();
            }
            set
            {
                _numeroDeDocumento = int.TryParse();
            }
        }


        public Persona()
		{
		}
	}
}

