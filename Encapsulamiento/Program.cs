using Encapsulamiento.Modelo;

var miAuto = new Auto();

Console.WriteLine("Estamos creando un nuevo Auto. Ingrese Tipo de Motor:");
var tipoMotor = Console.ReadLine();

miAuto.TipoDeMotor = null;

Console.WriteLine(miAuto.TipoDeMotor);