using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            int N = 17;
            ClosestEvenNumberFinder finder = new ClosestEvenNumberFinder();
            int closestNum = finder.FindClosestEvenNumber(N);
            Console.WriteLine($"Closest number to {N} with all even digits: {closestNum}");

            N = -33;
            closestNum = finder.FindClosestEvenNumber(N);
            Console.WriteLine($"Closest number to {N} with all even digits: {closestNum}");

            //UC2
            ClassMemberFetcher fetcher = new ClassMemberFetcher();
            Type type = typeof(ClosestEvenNumberFinder);
            fetcher.FetchClassMembers(type);


            //UC3
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            if (constructor != null)
            {
                object emptyObject = constructor.Invoke(null);
                Console.WriteLine("Empty object of ClosestEvenNumberFinder class created using reflection.");
            }
            else
            {
                Console.WriteLine("Default constructor not found. Failed to create an empty object.");
            }

            

            Console.ReadLine();

        }
    }
}
