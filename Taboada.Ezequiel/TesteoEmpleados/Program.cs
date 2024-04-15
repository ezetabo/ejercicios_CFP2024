using LibreriaDePersonas;

namespace TesteoEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado primerEmpleado = new Empleado(1, "Juan", "Perez");
            Empleado segundoEmpleado = new Empleado(2, "Analia", "Sanchez", 230000, "Gerencia");



            Console.WriteLine(primerEmpleado.InformarDatos());
            Console.WriteLine(segundoEmpleado.InformarDatos());


            Console.WriteLine($"Consulto sueldo empleado 2: {segundoEmpleado.GetSueldo()}");

            Console.WriteLine($"Consulto sueldo empleado 1: {primerEmpleado.GetSueldo()}");

            primerEmpleado.SetSueldo(200000);

            Console.WriteLine($"Consulto sueldo empleado 1 despues de usar SET: {primerEmpleado.GetSueldo()}");

        }
    }
}
