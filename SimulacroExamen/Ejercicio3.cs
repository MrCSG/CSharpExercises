using System;
using System.Collections.Generic;
namespace SimulacroExamen
{
    public class Ejercicio3
    {
        public static void Figuras(){
            float s1,s2,s3,bShape,h;
            string name;
            List<Shapes> myShapes = new List<Shapes>();

            Console.WriteLine("Ingrese los datos del primer triángulo:");
            Console.Write("Nombre: ");
            name = Console.ReadLine();
            Console.Write("Lado 1: ");
            s1 = float.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            s2 = float.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            s3 = float.Parse(Console.ReadLine());
            Console.Write("Su base: ");
            bShape = float.Parse(Console.ReadLine());
            Console.Write("Su altura: ");
            h = float.Parse(Console.ReadLine());
            Triangle triangle1 = new Triangle(name, s1, s2, s3, bShape, h);

            Console.WriteLine("Ingrese los datos del segundo triángulo:");
            Console.Write("Nombre: ");
            name = Console.ReadLine();
            Console.Write("Lado 1: ");
            s1 = float.Parse(Console.ReadLine());
            Console.Write("Lado 2: ");
            s2 = float.Parse(Console.ReadLine());
            Console.Write("Lado 3: ");
            s3 = float.Parse(Console.ReadLine());
            Console.Write("Su base: ");
            bShape = float.Parse(Console.ReadLine());
            Console.Write("Su altura: ");
            h = float.Parse(Console.ReadLine());
            Triangle triangle2 = new Triangle(name, s1, s2, s3, bShape, h);

            Console.WriteLine("Ingrese los datos del rectángulo:");
            Console.Write("Nombre: ");
            name = Console.ReadLine();
            Console.Write("Lado 1 o base: ");
            bShape = float.Parse(Console.ReadLine());
            Console.Write("Lado 2 o altura: ");
            h = float.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(name, bShape, h);

            myShapes.Add(triangle1);
            myShapes.Add(triangle2);
            myShapes.Add(rectangle);

            foreach(Shapes figura in myShapes)
            {
                Console.WriteLine($"La figura \"{figura.name}\" tiene un área de {figura.Area()} y un perímetro de {figura.Perimeter()}.");
            }

        }
    }
}