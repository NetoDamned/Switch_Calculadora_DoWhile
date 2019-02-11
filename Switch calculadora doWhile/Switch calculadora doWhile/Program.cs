using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_calculadora_doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            float opcion, valor1, valor2;
            string linea;

            do

            {

                Console.WriteLine("MENÚ");
                Console.WriteLine("");
                Console.WriteLine("1.- Elige la opción 1 para SUMAR 2 valores");
                Console.WriteLine("2.- Elige la opción 2 para RESTAR 2 valores");
                Console.WriteLine("3.- Elige la opción 3 para MULTIPLICAR 2 valores");
                Console.WriteLine("4.- Elige la opción 4 para DIVIDIR 2 valores");
                Console.WriteLine("5.- Elige la opción 5 para terminar el programa");

                linea = Console.ReadLine();
                opcion = float.Parse(linea);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elegiste la opción 1");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor1 = float.Parse(linea);
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor2 = float.Parse(linea);
                        Console.WriteLine("La SUMA de ambos valores es:");
                        Console.WriteLine(valor1 + valor2);
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine("Elegiste la opción 2");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor1 = float.Parse(linea);
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor2 = float.Parse(linea);
                        Console.WriteLine("La RESTA de ambos valores es:");
                        Console.WriteLine(valor1 - valor2);
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Elegiste la opción 3");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor1 = float.Parse(linea);
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor2 = float.Parse(linea);
                        Console.WriteLine("La MULTIPLICACIÓN de ambos valores es:");
                        Console.WriteLine(valor1 * valor2);
                        Console.WriteLine("");
                        break;

                    case 4:
                        Console.WriteLine("Elegiste la opción 4");
                        Console.WriteLine("");
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor1 = float.Parse(linea);
                        Console.WriteLine("Ingresa el primer valor");
                        linea = Console.ReadLine();
                        valor2 = float.Parse(linea);
                        Console.WriteLine("La DIVISIÓN de ambos valores es:");
                        Console.WriteLine(valor1 / valor2);
                        Console.WriteLine("");
                        break;

                    case 5:
                        Console.WriteLine("Elegiste la opción 5");
                        Console.WriteLine("");
                        Console.WriteLine("Gracias por usar nuestro programa");
                        Console.WriteLine("");
                        break;

                }
            }
            while (opcion != 5);

            Console.ReadKey();

        }
    }
}
