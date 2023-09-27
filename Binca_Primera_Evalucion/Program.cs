using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Evaluacion
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool Continuar = true;
            while (Continuar == true) {
                Console.WriteLine("Biemvenido al menu multiprograma seleccione la accion que desea");
                Console.WriteLine(@"
                1- Pares e Impares
                2- Tabla de multiplicar
                3- Factorial de un número
                4- Números Primos
                5- Sucesión de Fibonacci
                6- Salir
                ");
                var ops= Herramientas.input_int("Digite su elccion con los numeros del 1 al6: ");
                switch (ops)
                {
                    case 1:
                    Ejercicios.pares();
                    break;
                    case 2:
                    Ejercicios.Tabla();
                    break;
                    case 3:
                    Ejercicios.Factorial();
                    break;
                    case 4:
                    Ejercicios.Primos();
                    break;
                    case 5:
                    Ejercicios.Fibonacci();
                    break;
                    default:
                    Console.WriteLine("Digite una opcion valida: ");
                    Console.Readkey();
                        break;
                }
            }
        }
    }
}
