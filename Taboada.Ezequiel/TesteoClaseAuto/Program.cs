using Automoviles;

namespace TesteoClaseAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto autoUno = new Auto("Ford", "AD132AD", 2022, 10500.25);

            Console.WriteLine(autoUno.TocarBocina());


            Console.WriteLine($"marca:{autoUno.marca} patente:{autoUno.patente}  modelo:{autoUno.modelo}  precio:{autoUno.precio}");



        }
    }
}
