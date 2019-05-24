using System;
namespace _7.Iteration
{
    internal class Solution
    {

        public int solution(int N){
            string binary = Convert.ToString(N,2);
            Console.WriteLine(binary);
            int quantity = 0, maxZeros = 0;
            for(int i=1; i<binary.Length ; i++)
            {
                if(binary[i] == '0')
                {
                    quantity++;
                }
                else
                {
                    if(quantity > maxZeros)
                    {
                        maxZeros = quantity;
                    }
                    quantity = 0;
                }
            }
            return maxZeros;
        }
    }
}