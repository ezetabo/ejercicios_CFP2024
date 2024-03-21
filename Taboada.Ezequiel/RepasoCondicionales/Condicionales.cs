namespace RepasoCondicionales
{
    internal class Condicionales
    {
        static void Main(string[] args)
        {
            int edad = 12;
            string genero = "x";

            if (genero == "mujer")
            {
                if (edad >= 18)
                {
                    Console.WriteLine("es una mujer mayor de edad");
                }
                else
                {
                    Console.WriteLine("es niña");
                }
            }
            else
            {
                Console.WriteLine("no es mujer");
            }


            if (edad < 18 && genero == "mujer")
            {
                Console.WriteLine("es niña");
            }
            else
            {
                //genero sea hombre
                //edad sea mayor o igual a 18
                if (genero == "mujer" && edad >= 18)
                {
                    Console.WriteLine("es una mujer mayor de edad");
                }
                else
                {
                    if (edad < 18)
                    {
                        Console.WriteLine("es menor y no es mujer");
                    }
                    else
                    {
                        Console.WriteLine("es mayor y no es mujer");
                    }
                }
            }

            //Al ingresar una edad menor a 18 años y un estado civil distinto a soltero,
            //mostrar el mensaje: “Es muy pequeño para NO ser soltero”


            if (true)
            {
                if ()
                {

                }
                else
                {
                    if ()
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {
                if ()
                {
                    if ()
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }


        }
    }
}
