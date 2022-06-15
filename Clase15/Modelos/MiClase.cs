using System;
namespace Clase15.Modelos
{
	public class MiClase
	{
        public int Id { get; set; }
        public string Nombre { get; set; }

        public MiClase()
		{
		}
	}
}


/*
var miLista = new List<MiClase>();
miLista.Add(miPrimerClase);
miLista.Add(miSegundaClase);

foreach (var item in miLista)
{
    Console.WriteLine((item.Nombre);
    if (item.Id == 1)
    {
        item.Nombre = "ROBERTO";
    }
}
Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);
*/