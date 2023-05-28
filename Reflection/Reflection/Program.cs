using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = 17;
            ClosestEvenNumberFinder finder = new ClosestEvenNumberFinder();
            int closestNum = finder.FindClosestEvenNumber(N);
            Console.WriteLine($"Closest number to {N} with all even digits: {closestNum}");

            N = -33;
            closestNum = finder.FindClosestEvenNumber(N);
            Console.WriteLine($"Closest number to {N} with all even digits: {closestNum}");

            Console.ReadLine();
        }
    }
}
