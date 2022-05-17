// Generar numero aleatorio y compara con un numero dado por el usuario
// El programa termina si el numero del usuario es igual al numero aleatorio

Console.Clear();

//Genera numero aleatorio
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

int numeroUsuario = 0;
int intentos = 0;

do
{
    Console.WriteLine();
    Console.Write("Ingrese un numero entre 1 y 20: ");
    var entradaUsuario = Console.ReadLine();

    numeroUsuario = Convert.ToInt32(entradaUsuario);
    intentos += 1;

    Console.WriteLine();

    if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("<<< El numero es muy chico. Intente de nuevo.");
    }
    else if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine(">>> El numero es muy grande. Intente de nuevo.");
    }
    else
    {
        Console.Write("=== FELICITACIONES === Has adivinado  el numero " +
                      "secreto que era " + numeroSecreto);
        Console.WriteLine(". Lo has logrado en " + intentos + " intentos!!");
    }
}
while (numeroUsuario != numeroSecreto);

Console.WriteLine();
Console.WriteLine("Presione cualquier tecla...");
Console.ReadKey();
 