using LibreriaDeFunciones;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero =  MisFunciones.PedirEnteroConRangoV2("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
            Console.WriteLine($"el numero ingresado es: {numero}");



        }


    }
}
