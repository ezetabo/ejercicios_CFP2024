namespace FuncionesConVEctores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Cargar un vector de enteros de 5 elementos y mostrarlo.
             */
            /*
              Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
             */

            int[] misNumeros = CargarArrayDeEnteros(5);

            int valorSuma = SumaValoresArrayEnteros(misNumeros);

            double promedio = CalcularPromedioArrayEnteros(misNumeros);

            ImprimirArray("Los numeros ingresados son: ", misNumeros);

            Console.WriteLine($"el valor de la suma es: {valorSuma}");

            Console.WriteLine($"el valor del promedio es: {promedio}");



        }

        static /*este es el retorno*/int[] CargarArrayDeEnteros(int cantidad  /*aca sabemos que recibe y se llama parametros*/)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el numero {i + 1} de {cantidad}: ", "EL dato ingresado no es numerico");
            }
            return numeros;
        }

        static int PedirEntero(string mensaje, string mensajeError)
        {
            int numeroValido;
            string numeroLedido;
            numeroLedido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLedido, out numeroValido))
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

        static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }

        static int SumaValoresArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }

            return suma;
        }

        static double CalcularPromedioArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            double resultado;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }

            resultado = (double) suma / misNumeros.Length;

            return resultado;
        }

    }
}
