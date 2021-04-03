using System;

namespace A133590.Ejercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 37");
            Console.WriteLine("Programa que recibe ingresos hasta que el mismo sea una cadena válida.");
            Console.Write("Por favor, ingrese una cadena: ");
            string ingreso = Console.ReadLine();
            while (ingreso.Length < 10 || ingreso.Length > 20)
            {
                Console.Write("Ingreso inválido, la cadena debe tener de 10 a 20 caracteres, intente nuevamente: ");
                ingreso = Console.ReadLine();
            }
            Console.WriteLine("Ingreso válido.");
            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
