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
    //Funcion Factorial
    public static void Factorial()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea calcular otro factorial? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
    static double FactorialDe(double numero)
    {
        if (numero == 0)
            return 1;
        double factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
    //Funcion Primos
    public static void Primos()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                Console.WriteLine("Números primos en orden inverso: ");
                for (int i = numero; i >= 2; i--)
                {
                    if (EsPrimo(i))
                        Console.Write(i + " ");
                }
                Console.WriteLine();
                var numerosPrimos = Enumerable.Range(2, numero - 1).Where(EsPrimo);
                double media = numerosPrimos.Average();
                double factorialMedia = FactorialDe(media);
                Console.WriteLine($"Media de los números primos: {media}");
                Console.WriteLine($"Factorial de la media {media} es: {factorialMedia}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }
            Console.Write("¿Desea realizar otra operación en Números Primos? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");
        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;
        if (numero % 2 == 0 || numero % 3 == 0)
            return false;
        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }
        return true;
    }
    //Funcion fivonacci
    public static void Fibonacci()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese la cantidad de iteraciones para la sucesión de Fibonacci: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int iteraciones) && iteraciones > 0)
            {
                int a = 0, b = 1;
                Console.Write("Sucesión de Fibonacci: ");
                for (int i = 0; i < iteraciones; i++)
                {
                    Console.Write(a + " ");
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo mayor que 0.");
            }
            Console.Write("¿Desea generar otra sucesión de Fibonacci? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");
        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
}