using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var obj =new MultiplesOf3And5();
            Console.WriteLine(obj.GetMultiples());
            Console.ReadLine();
        }
    }
}
