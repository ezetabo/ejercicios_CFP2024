namespace RepasoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color = "asadsd";




            switch (color)
            {
                case "rojo":
                    Console.WriteLine("no puede avanzar");

                    break;
                case "amarillo":
                    Console.WriteLine("precaucion");
                    break;
                case "verde":
                    Console.WriteLine("puede avanzar");
                    break;
                default:
                    Console.WriteLine("no es un color valido del semaforo");
                    break;
            }




        }
    }
}
