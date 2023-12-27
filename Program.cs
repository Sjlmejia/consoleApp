// See https://aka.ms/new-console-template for more information
using Humanizer;
Console.WriteLine("Por favor, ingrese su nombre: ");
var nombre = Console.ReadLine();
Console.WriteLine("Por favor, ingrese su apellido: ");
var apellido = Console.ReadLine();
Console.WriteLine("Por favor, ingrese su edad: ");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola {nombre} {apellido}, tu edad es {edad.ToWords(new System.Globalization.CultureInfo("es"))} años");
