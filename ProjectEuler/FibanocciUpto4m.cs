using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class FibanocciUpto4m
    {
        private int max;
        private int evenSum = 2;
        public int GetOutput(int maxi)
        {
            max = maxi;
            return RecFibMethod(1, 2);
        }

        private int RecFibMethod (int prev,int current )
        {
            int temp = prev + current;
            if(temp % 2 == 0)
            {
                evenSum += temp;
            }

            if (evenSum < max)
            {
                return RecFibMethod(current, temp);
            }
            else
            {
                return evenSum;
            }
        }
    }
}
