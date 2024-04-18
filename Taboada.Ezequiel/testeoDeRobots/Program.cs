using LibreriaDeRobots;
using System.Drawing;
using System.Security.AccessControl;

namespace testeoDeRobots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot("robotito", 50, 30);
            Robot r3 = new Robot("bestia", 100, 90);

            int dañoEmitido;
            int round = 1;
           
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"**********   ROUND {round}°   ************");              
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{r3.GetNombre()} tiene {r3.GetVida()} puntos de vida");
                Console.WriteLine($"La resistencia de {r3.GetNombre()} es de {r3.Getresistencia()} puntos");
                dañoEmitido = r1.Atacar();
                Console.WriteLine($"{r1.GetNombre()} lanzo un golpe de: {dañoEmitido}");
                r3.RecibirDanio(dañoEmitido);
                Console.WriteLine($"{r3.GetNombre()} quedo con {r3.GetVida()} puntos de vida");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{r1.GetNombre()} tiene {r1.GetVida()} puntos de vida");
                Console.WriteLine($"La resistencia de {r1.GetNombre()} es de {r1.Getresistencia()} puntos");
                dañoEmitido = r3.Atacar();
                Console.WriteLine($"{r3.GetNombre()} lanzo un golpe de: {dañoEmitido}");
                r1.RecibirDanio(dañoEmitido);
                Console.WriteLine($"{r1.GetNombre()} quedo con {r1.GetVida()} puntos de vida");


                round++;
            } while ((r3.GetVida() > 0 && r1.energia > 0) && (r1.GetVida() > 0 && r3.energia > 0));



            Console.ForegroundColor = ConsoleColor.White;
            if (r3.GetVida() >  r1.GetVida() )
            {
                Console.WriteLine($"El ganador es {r3.GetNombre()}");
            }
            else
            {
                Console.WriteLine($"El ganador es {r1.GetNombre()}");
            }




        }
    }
}
