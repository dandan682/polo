using Clase15.Modelos;

/* 
var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "Juancito Perez"
};

Console.WriteLine(miPrimerClase.Nombre);

var miSegundaClase = miPrimerClase;
Console.WriteLine(miPrimerClase.Nombre);

miSegundaClase.Nombre = "Andres Gomez";

Console.WriteLine();
Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);
 */

var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "PEPE"
};

var miSegundaClase = new MiClase
{
    Id = 2,
    Nombre = "QUINO"
};

var miLista = new List<MiClase>();

miLista.Add(miPrimerClase);
miLista.Add(miSegundaClase);

foreach (var item in miLista)
{
    Console.WriteLine(item.Nombre);
    if (item.Id == 1)
    {
        item.Nombre = "ROBERTO";
    }
}
Console.WriteLine(miPrimerClase.Nombre);
Console.WriteLine(miSegundaClase.Nombre);