using Lab1JhonsonHumbertoLeivaSalinas.Entidades;
using Lab1JhonsonHumbertoLeivaSalinas.Negocio;

Persona per = new Persona();
ClsPersona clsPersona = new ClsPersona();

Console.Write(@"Bienvenido a su calculador de IMC

Ingrese los siguientes datos para continuar 

Ingrese su Nombre -> ");
per.Nombre = Console.ReadLine();

Console.Write("\nIngrese su edad -> ");
per.Edad = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIngrese su sexo -> ");
per.Sexo = Console.ReadLine();

Console.Write("\nIngrese su peso en Kg. -> ");
per.Peso = Convert.ToDouble(Console.ReadLine());

Console.Write("\nIngrese su altura en metros -> ");
per.Altura = Convert.ToDouble(Console.ReadLine());

Console.Write($@"
Nombre: {per.Nombre} edad: {per.Edad} sexo: {per.Sexo}

Peso: {per.Peso}

Altura: {per.Altura}

Usted {clsPersona.CalcularIMC(per)}

Usted {clsPersona.MayorDeEdad(per)}");