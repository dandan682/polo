// Gestor de personas (empleados, desempleados, jubilados)
// Insertar personas en una base de datos, mostrar datos de una determinada persona o
// de todas las personas.
using Clase16.Modelo;
using Clase16.Repositorio;

var repositorio = new RepositorioDePersonas();

var usuarioNombre = "Ezeqiel";
var usuarioApellido = "Etchecoin";

repositorio.Insertar(new Empleado
{
    Nombre = usuarioNombre,
    Apellido = usuarioApellido
});
