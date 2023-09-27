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
