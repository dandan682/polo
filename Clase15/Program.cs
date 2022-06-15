using Clase15.Modelos;


var miPrimerClase = new MiClase
{
    Id = 1,
    Nombre = "Juancito Perez"
};

Console.WriteLine(miPrimerClase.Nombre);

var miSegundaClase = miPrimerClase;
Console.WriteLine(miSegundaClase.Nombre);

