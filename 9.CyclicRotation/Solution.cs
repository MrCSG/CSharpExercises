using System;

namespace _9.CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K){
            int swap=0, i=A.Length-1;
            while(K>0 && i>=0)
            {
                if(i == A.Length-1)
                {
                    swap = A[A.Length-1];
                    i--;
                }else
                {
                    A[i+1] = A[i];
                    i--;
                }
                if(i == 0)
                {
                    A[i+1] = A[i];
                    A[0] = swap;
                    K--;
                    i = A.Length-1;
                }
            }
            /*while(K>0)
            {
                swap = A[A.Length-1];
                for(int i=A.Length-2; i>=0 ; i--)
                {
                    A[i+1] = A[i];
                }
                A[0] = swap;
                K--;
            }*/

            for(i=0 ; i<A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            return A;
        }
    }
}