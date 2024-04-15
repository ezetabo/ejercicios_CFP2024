using LibreriaDeFunciones;

namespace OtrasFuncionesConArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ingresar números en un vector, pueden ser positivos o negativos. 
             Mostrar los negativos de forma creciente y los positivos de forma decreciente.
             Ejemplo: 
             Vector ingresado: {5, 1, -9, -1, 9, 3, -2, 2}
             Vector ordenado: {-9, -2, -1, 9, 5, 3, 2, 1}
             */

            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(8);

            MisFunciones.OrdenarPorCriterio(misNumeros,true);
            MisFunciones.MostrarPorCriterio("Positivos en forma creciente",misNumeros,true);      


            MisFunciones.OrdenarPorCriterio(misNumeros,false);
            MisFunciones.MostrarPorCriterio("Negativos en forma decreciente", misNumeros, false);



        }
    }
}
