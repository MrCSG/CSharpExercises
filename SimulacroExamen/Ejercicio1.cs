using System;
namespace SimulacroExamen
{
    public class Ejercicio1
    {
        static public void CostoDolar(){
            decimal cotizacion, cantDolar;
            Console.WriteLine("Calcular cuanto va a costar comprar cierta cantidad de Dolares.");
            Console.Write("Cotización actual: ");
            cotizacion = decimal.Parse(Console.ReadLine());
            Console.Write("Cantidad a comprar: ");
            cantDolar = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Necesitará {(cotizacion*cantDolar)*1.05M} AR$ para comprar {cantDolar} U$D.");
        }
    }
}