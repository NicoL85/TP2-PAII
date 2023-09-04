
//namespace Agregacion;
class Ej2
{
    static void Main(string[] args)
    {


        string cadenas;


        static string Cortar(string cadena)
        {
            if (cadena.Length >= 4)
            {
                cadena = cadena.Substring(0, 4);

            }
            return cadena;

        }
        cadenas = Cortar("HolaMundo");
        Console.WriteLine("Cortar cadena : " + cadenas);



    }

}
