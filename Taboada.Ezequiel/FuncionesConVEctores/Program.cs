using LibreriaDeFunciones;

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

            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(5);

            int valorSuma = MisFunciones.SumaValoresArrayEnteros(misNumeros);

            double promedio = MisFunciones.CalcularPromedioArrayEnteros(misNumeros);

            MisFunciones.ImprimirArray("Los numeros ingresados son: ", misNumeros);

            Console.WriteLine($"el valor de la suma es: {valorSuma}");

            Console.WriteLine($"el valor del promedio es: {promedio}");
                   

            MisFunciones.ImprimirArrayAlreves("imprimiendo array alreves", misNumeros);


        }

    }
}
