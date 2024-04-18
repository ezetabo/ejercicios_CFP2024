using System.Drawing;
using System.Reflection.Metadata;

namespace LibreriaDeRobots
{
    ///******* CASTEOS o CONVERSIONES (EXPLICITAS O IMPLICITAS)  ********/
    //double doble1 = 158.22;
    //int entero2 = 8000;
    //int entero;
    //double doble;
    //doble = entero2; //-> un casteo o concersion del tipo implicita, no implica perdidad de datos.
    //entero = (int)doble1; // un casteo o version del explicita, implica posible perdida de datos.
    //// se pueden utilizar tanto en asignacion como en operaciones mateticas.
    public class Robot
    {
        //atributos
        string nombre;
        double resistencia;
        double peso;
        Color color;
        int vida;
        public int energia;
        static Random rnd;




        // setters
        public bool SetColor(Color nuevoColor)
        {
            bool logroCambiar = false;

            if (nuevoColor == Color.Black || nuevoColor == Color.Blue || nuevoColor == Color.Yellow)
            {
                this.color = nuevoColor;
                logroCambiar = true;
            }

            return logroCambiar;
        }


        // getters
        public Color GetColor()
        {
            return color;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public double GetPeso()
        {
            return peso;
        }

        public double Getresistencia()
        {
            return resistencia;
        }

        public int GetVida()
        {
            return vida;
        }

        // ctor
        public Robot(string nombre, int resistencia, double peso)
        {
            this.nombre = nombre;
            this.resistencia = resistencia;
            this.peso = peso;
            this.color = Color.White;
            this.vida = 100;
            this.energia = 100;
        }

        static Robot()
        {
            Robot.rnd = new Random();
        }

        // metodos
        public string RobotToString()
        {
            return $"Nombre: {nombre} - vida: {vida} - Peso: {peso}kg - resistencia: {resistencia} - Color: {color.Name}";
        }



        public int Atacar()
        {
            // el golpe supera un rango de daño, resta mas energia.
            int golpe = 0;
            // por cada ataque pierde energia

            // en base a la energia se potencia el golpe        

            if (vida > 0 && energia > 0)
            {
                golpe = Robot.rnd.Next(1, this.energia);
            }
            this.energia -= 5;

            return golpe * rnd.Next(1,3);
        }

        public void RecibirDanio(int cantidadDaño)
        {
            // por cada golpe recibido bajar resistencia (haga o no daño)

            int dañoTotal = (int)resistencia - cantidadDaño;
            if (dañoTotal < 0)
            {
                this.vida += dañoTotal;
            }

            if (this.vida < 0)
            {
                this.vida = 0;
            }

            this.resistencia = this.resistencia * 0.95;
        }




    }
}
