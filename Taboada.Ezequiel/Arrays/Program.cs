namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = { 1, 2, 3, 4, 5 };

           Array.Reverse(numeros);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }


        }
        // que devuelven algo y que reciben parametro
        static string PedirCadena(string mensaje)
        {
            string lectura;
            Console.Write(mensaje);
            lectura = Console.ReadLine();
            return lectura;
        }

        static int SumarEnteros(int numeroUno, int numeroDos)
        {

            return numeroUno + numeroDos;
        }

        static int Calculadora(int numeroUno, int numeroDos,char operador)
        {
            int resultado = 0;


            switch (operador)
            {
                case '+':
                    resultado = numeroUno + numeroDos;
                    break; 
                    
                case '-':
                    resultado = numeroUno - numeroDos;
                    break;                    
                case '*':
                    resultado = numeroUno * numeroDos;
                    break;
                case '/':
                    resultado = numeroUno / numeroDos;
                    break;
            }


            return resultado;
        }

    }
}
