using LibreriaDeRobots;
using System.Drawing;

namespace testeoDeRobots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot("robotito", 50, 30);
            Robot r2 = new Robot("chat", 20, 15);
            Robot r3 = new Robot("bestia", 100, 90);
            Robot r4 = new Robot("robotito2", 5, 3);
            Robot r5 = new Robot("mazinger", 500, 150);


            Console.WriteLine(r1.RobotToString());
            Console.WriteLine(r2.RobotToString());
            Console.WriteLine(r3.RobotToString());
            Console.WriteLine(r4.RobotToString());
            Console.WriteLine(r5.RobotToString());

        


            r3.RecibirDanio(r1.Atacar());

            Console.WriteLine(r3.GetVida());


        }
    }
}
