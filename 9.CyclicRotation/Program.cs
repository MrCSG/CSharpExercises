using System;

namespace _9.CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] array = new[]{3, 8, 9, 7, 6};
            array = sol.solution(array,3);
            for(int i=0; i<array.Length ; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
