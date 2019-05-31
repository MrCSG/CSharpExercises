using System;

namespace _8.OddOcurrencesInArray
{
    public class Solution
    {
        public int solution(int[] A){
            int show = 0;
            bool isPaired;
            for(int i=0 ; i<A.Length ; i++)
            {
                isPaired = false;
                for(int j=0; j<A.Length ; j++)
                {
                    if (A[i] == A[j] && i != j)
                    {
                        isPaired = true;
                    }
                }
                if(!isPaired)
                {
                    show = A[i];
                }
            }
            return show;
        }
    }
}