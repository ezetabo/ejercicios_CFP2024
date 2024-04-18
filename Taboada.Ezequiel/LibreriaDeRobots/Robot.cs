using System.Drawing;

namespace LibreriaDeRobots
{

    ///******* CASTEOS o CONVERSIONES (EXPLICITAS O IMPLICITAS)  ********/
    //double unDouble = 158.22;
    //int unEntero = 8000;
    //int otroEntero;
    //double otroDouble;
    //otroDouble = unEntero; //-> conversion implicita, no implica perdidad de datos.
    //otroEntero = (int)unDouble; // casteo o conversion explicita, implica posible perdida de datos.
    // se pueden utilizar tanto en asignacion como en operaciones matematicas.

    public class Robot
    {
        //atributos
        string nombre;
        double resistencia;
        double peso;
        Color color;
        int vida;
        public int energia; //public despues se debe crear un get
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

        // ctor de instancia
        public Robot(string nombre, int resistencia, double peso)
        {
            this.nombre = nombre;
            this.resistencia = resistencia;
            this.peso = peso;
            this.color = Color.White;
            this.vida = 100;
            this.energia = 100;
        }

        // ctor static
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
            int golpe = 0;

            // en base a la energia se calcula el golpe        
            if (vida > 0 && energia > 0)
            {
                golpe = Robot.rnd.Next(1, this.energia);
            }

            // por cada ataque pierde energia
            this.energia -= 5;

            //aumentamos el el daño porque vimos que era muy poco
            return golpe * rnd.Next(1,3);
        }

        public void RecibirDanio(int cantidadDaño)
        {

            int dañoTotal = (int)resistencia - cantidadDaño;
            if (dañoTotal < 0)
            {
                this.vida += dañoTotal;
            }

            //la vida no puede ser negativa
            if (this.vida < 0)
            {
                this.vida = 0;
            }

            // por cada golpe recibido bajar resistencia (reciba o no daño)
            this.resistencia = this.resistencia * 0.95;
        }




    }
}
