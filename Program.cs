using System;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la opción que desea realizar (1,2 o 3): ");
            string choosedOption = Console.ReadLine();
            if(choosedOption=="1")
            {
            //1.
            ConsoleExercises console = new ConsoleExercises();
            console.AskAge();

            //Pedir nombre, apellido y documento e imprimir toda la información al final.
            } else if(choosedOption=="2")
            {
            //2.
            VariableExercises variable = new VariableExercises();
            variable.Concatenador();
            } else if (choosedOption=="3")
            {            
            //3.
            DataTypeExercises dataType = new DataTypeExercises();
            dataType.ValueSum();
            }
            else
            {
                Console.WriteLine("La opción ingresada no existe.");
            }
        }
    }
}
