using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            int firstValue=0, secondValue=0;
            bool canParseValue;
            Console.WriteLine("Ingrese un valor a sumar:");
            //var firstValue = Console.ReadLine();
            //int firstValue = Convert.ToInt32(Console.ReadLine());
            canParseValue = Int32.TryParse(Console.ReadLine(),out firstValue);
            if (canParseValue)
            {
                Console.WriteLine("Ingrese otro valor a sumar:");
                //var secondValue = Console.ReadLine();
                //int secondValue = Int32.Parse(Console.ReadLine());
                canParseValue = Int32.TryParse(Console.ReadLine(),out secondValue);
                if(canParseValue)
                {
                    Console.WriteLine("El resultado de la suma es: {0}", firstValue + secondValue);
                }
                else
                {
                    Console.WriteLine("El segundo valor no es un número.");
                }
            }
            else
            {
                Console.WriteLine("El primer valor no es un número.");
            }
        }
    }
}