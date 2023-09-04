namespace Agregacion;

class Program
{
    static void Main(string[] args)
    {

        int result;

        static int Sumar(int numero1, int numero2)
        {

            return numero1 + numero2;

        }
        result = Sumar(10, 8);

        Console.WriteLine("resultado" + result);


    }
}

