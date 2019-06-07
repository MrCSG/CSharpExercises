using System;
namespace SimulacroExamen
{
    public class Ejercicio2
    {
        static public void MayorElemento(){
            int i, j, max=0, iMax=0, jMax=0;
            Console.Write("Cantidad de filas: ");
            i = Int32.Parse(Console.ReadLine());
            Console.Write("Cantidad de columnas: ");
            j = Int32.Parse(Console.ReadLine());
            int[,] array = new int[i,j];
            for( i=0; i<array.GetLength(0); i++)
            {
                for( j=0; j<array.GetLength(1); j++)
                {
                    array [i,j] = Int32.Parse(Console.ReadLine());
                    //Random r = new Random();
                    //array [i,j] = r.Next(0,100);
                }
            }
            for( i=0; i<array.GetLength(0); i++)
            {
                for( j=0; j<array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]}, ");
                    if (array[i,j] > max)
                    {
                        max = array[i,j];
                        iMax = i;
                        jMax = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"El mayor valor es {max} y se encontró pro primera vez en la fila {iMax} y la columna {jMax}.");
        }
    }
}