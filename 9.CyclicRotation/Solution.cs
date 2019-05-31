using System;

namespace _9.CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K){
            int swap;
            while(K>0)
            {
                swap = A[A.Length-1];
                for(int i=A.Length-2; i>=0 ; i--)
                {
                    A[i+1] = A[i];
                }
                A[0] = swap;
                K--;
            }

            for(int i=0 ; i<A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            return A;
        }
    }
}