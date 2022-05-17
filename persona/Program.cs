// Clase 5 Pide nombre de persona.
// Pregunta si quiere continuar.
// 
var respuesta = "S";
do
{
    Console.Clear();

    Console.WriteLine("Ingresa tu nombre: ");
    var nombrePersona = Console.ReadLine();
    Console.WriteLine("!Hola " + nombrePersona + "!");

    Console.WriteLine("¿Quiere continuar? S para si, N para no. ");
    respuesta = Console.ReadLine();
}
while (respuesta.ToUpper() == "S");

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente.");
}
else if(respuesta.ToUpper() != "S")
{
    Console.WriteLine("Opcion no valida.");
}

Console.ReadKey();