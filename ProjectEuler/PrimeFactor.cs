using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
   public class PrimeFactor
    {
        readonly long no;
        List<int> factorialNo = new List<int>();
        long remaining;
        int factor = 2;
        public PrimeFactor(long no)
        {
             this.no = no;           
        }

        public int GetMaxPrimeFactorNo(long val = 0)
        {
            val = val == 0 ? no : val;
            if(val > 1)
            {
                if(val % factor == 0)
                {
                    factorialNo.Add(factor);
                    remaining = val / factor;
                }
                else
                {
                    factor = nextFactor(++factor);
                    GetMaxPrimeFactorNo(val);
                }
                if(remaining == 1)
                {
                    return factorialNo.Max();
                }
                else
                {
                    factor = 2;
                    GetMaxPrimeFactorNo(remaining);
                   
                }
            }
            return 1;
        }

        bool checkIfBoolean(int no) => Enumerable.Range(1, no).Where(x => no % x == 0).SequenceEqual(new[] { 1, no });

        int nextFactor(int val) => checkIfBoolean(val) ? val : nextFactor(++val);

    }
}
