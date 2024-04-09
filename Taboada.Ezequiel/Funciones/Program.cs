namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = PedirEnteroConRangoV2("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
            Console.WriteLine($"el numero ingresado es: {numero}");



        }

        // que no reciben nada y no retornan nada.
        static void Saludar()
        {
            Console.Write("Ingrese su nombre: ");
            Console.WriteLine($"Bienvenido: {Console.ReadLine()}");
        }

        // crear una funcion que pida el ingreso de un numero entero con un rango maximo y un rango minimo y lo retorne

        static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido = 0;
            string numeroLedido;
            Console.Write(mensaje);
            numeroLedido = Console.ReadLine();
            while (!EsNumerico(numeroLedido) || (int.Parse(numeroLedido) > maximo || int.Parse(numeroLedido) < minimo))
            {
                Console.WriteLine(mensajeError);
                Console.Write(mensaje);
                numeroLedido = Console.ReadLine();
            }
            numeroValido = int.Parse(numeroLedido);
            return numeroValido;
        }

        static bool EsNumerico(string dato)
        {
            bool esNumerico = true;
            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;
        }


        static int PedirEnteroConRangoV2(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido;
            string numeroLedido;
            numeroLedido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLedido, out numeroValido) || (numeroValido > maximo || numeroValido < minimo))
            {
                Console.WriteLine(mensajeError);
                numeroLedido = PedirCadena(mensaje);
            }
            return numeroValido;
        }

        static string PedirCadena(string mensaje)
        {            
            Console.Write(mensaje);          
            return Console.ReadLine();
        }


    }
}
