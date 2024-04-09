namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*             
             Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas,
            los siguientes datos: marca y cantidad. El precio de cada lamparita es de $150 (Sin importar la marca).
                El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.

                A.      Si compra 6 lamparitas o más, tiene un descuento del 50%.
                B.      Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, 
                        el descuento es del 30%.
                C.      Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, 
                        y si es de otra marca el descuento es del 20%.
                D.      Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, 
                         si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
                E.       Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
                         Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, 
                        y si corresponde total de ingresos brutos y total a pagar.                       
             */

            int cantidaLamparas = 0;
            string marcaLamparas = "";
            double descuento;

            if (cantidaLamparas > 5)
            {
                //descuento del 50%
            }
            else
            {
                if (cantidaLamparas == 5)
                {
                    if (marcaLamparas == "ArgentinaLuz")
                    {
                        //descuento del 40%
                    }
                    else
                    {
                        //descuento del 30%
                    }
                }
                else
                {
                    if (cantidaLamparas == 4)
                    {
                        if (marcaLamparas == "ArgentinaLuz" || marcaLamparas == "FelipeLamparas")
                        {
                            //descuento 25
                        }
                        else
                        {
                            //descuento 20
                        }
                    }
                    else
                    {
                        //D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, 
                        // si es “FelipeLamparas se hace un descuento del 10 % y si es otra marca, 5 %.
                        if (cantidaLamparas == 3)
                        {
                            if (marcaLamparas == "ArgentinaLuz")
                            {
                                //descuento del 15%
                            }
                            else
                            {
                                if (marcaLamparas == "FelipeLamparas")
                                {
                                    //descuento 10
                                }
                                else
                                {
                                    //descuento 5%
                                }
                            }
                        }
                        else
                        {
                            //descuento 0
                        }
                    }
                }
            }



            //descuento = 85 * 10.2;



            Console.WriteLine($"el valor del double es: {descuento}");










        }       

    }
}
