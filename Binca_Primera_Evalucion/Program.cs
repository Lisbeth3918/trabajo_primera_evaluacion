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
//Clase Herramientas
class Herramientas
{
    public static int input_int (string msg){
        int resul;
        Console.Write(msg);
        var conclusion= int32.TryParse(Console.WriteLine(), out resul);
        if (conclusion == false){
            Console.WriteLine("Digite un enero valido: ");
            resul= input_int(msg);
        }
        return resul;
    }
}
//Clase ejercicios
class Ejercicios
{   
    //Funcion Pares
    public static void pares()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            int n, par = 0, impar = 0, sumapar = 0, sumaimpar = 0;
            Console.WriteLine("Digite un numero");
            n = Convert.ToInt32(Console.ReadLine());
            //Operacion con los numeros pares
            Console.WriteLine("numeros pares");
            for (int i = 1; i <=n; i++)
            {
                if (i%2 ==0)
                {
                    Console.Write("{0}|", i);
                    sumapar += i;
                    par++;
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("La suma de los numeros pares es: " + sumapar);
            Console.WriteLine("el total de los numeros pares es: " + par);
            //Operacion con los numeros impares
            Console.Write("\n\n");
            Console.WriteLine("numeros impares");
            for (int i = 1; i <=n; i++)
            {
                if (i%2 != 0)
                {
                    Console.Write("{0}|", i);
                    sumaimpar += i;
                    impar++;
                }
            }
            Console.Write("\n\n");
            Console.WriteLine("La suma de los numeros impares es: " + sumaimpar);
            Console.WriteLine("el total de los numeros impares es: " + impar);
            Console.Write("¿Desea ingreasar otro numero para realizar otra operacion? (si/no): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "si");
        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
    //Funcion Tablas
    public static void Tabla()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Por Favor Ingrese un número: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{numero}x{i} = {numero * i}");
                }
            }
            else
            {
                Console.WriteLine("caracter incorrecto, favor ingresar otro.");
            }

            Console.Write("¿Desea ingreasar otro numero para realizar otra operacion? (si/no): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "si");
        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
