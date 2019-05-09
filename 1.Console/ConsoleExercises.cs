using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){
            Console.WriteLine("¿Cuántos años tenes?: ");
            string age = Console.ReadLine();
            Console.WriteLine("Wow, no pareces de " + age + " años \n");
            //Pedir nombre, apellido y documento e imprimir toda la información al final.
            string nameU="", lastNameU="", dni="";
            Console.WriteLine("Ingrese sus datos personales:");
            Console.Write("Nombre/s: ");
            nameU = Console.ReadLine();
            Console.Write("Apellido/s: ");
            lastNameU = Console.ReadLine();
            Console.Write("DNI: ");
            dni = Console.ReadLine();
            Console.WriteLine($"\nUsted es {nameU} {lastNameU} con DNI n° {dni}.");
            
            Console.ReadLine();
        }
    }
}