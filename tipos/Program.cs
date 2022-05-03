// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte numeroByte = 0;
bool datoFalso = false;
bool datoVerdadero = true;

int numeroEntero = 0;
long numeroLong= 2000;
double numeroDouble = 300.123;
decimal numeroDecimal = 0;
float numeroFloat = 400;

string texto = "Cadena";
Console.Write("Escriba un texto > ");
texto = Console.ReadLine();
Console.WriteLine("Texto: " + texto);
Console.WriteLine(Convert.ToInt32(texto));