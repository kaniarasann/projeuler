using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {           
            //var obj =new MultiplesOf3And5();
            //Console.WriteLine(obj.GetMultiples());
            //Console.ReadLine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            //var obj = new FibanocciUpto4m();
            //Console.WriteLine(obj.GetOutput(4000000));
            var obj = new PrimeFactor(600851475143);
            Console.WriteLine(obj.GetMaxPrimeFactorNo());
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
