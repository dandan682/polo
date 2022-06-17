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

/*
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
 */

var primerPersona = new Persona
{
    Apellido = "Mateos",
    Nombre   = "Joaquin"
};


var primerDocente = new Docente
{
    Salario  = 70000,
    Apellido = "Ferreyra",
    Nombre = "Juan Pablo"

};

var primerAlumno = new Alumno
{
    Legajo = 1234,
    Apellido = "Rodriguez",
    Nombre = "Ricardo"
};

var personas = new List<Persona>();
personas.Add(primerPersona);
personas.Add(primerDocente);
personas.Add(primerAlumno);

foreach (var persona in personas)
{
    Console.WriteLine(persona.Nombre);
    if (persona.GetType() == typeof(Docente))
    {
        var docente = (Docente)persona;
        Console.WriteLine($"  {docente.Salario}");
    }
}