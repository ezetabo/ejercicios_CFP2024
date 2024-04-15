namespace Automoviles
{
    public class Auto
    {
        // dos tipos de clases ESTATIC -> no requiere una INSTANCIA
        // DE INSTANCIA
        // atributos
        // marca, modelo, motor, puertas, rodado, color,transmicion, patente
        public string marca;
        public string patente;
        public int modelo;
        public double precio;


        // constructor de mi clase
        public Auto(string marca, string patente, int modelo, double precio)
        {
            this.marca = marca;
            this.patente = patente;
            this.modelo = modelo;
            this.precio = precio;
        }


        //comportamientos -> metodos
        public string TocarBocina()
        {
            return "tuuuuuuuuuuuuuu";
        }



    }
}
