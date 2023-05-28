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


            //UC3 & UC3
            // Create an instance of FindClosestEvenNumber using reflection
            object defaultInstance = fetcher.CreateInstance(type);
            object parameterizedInstance = fetcher.CreateInstance(type, 42);

            // Check if the instances are created successfully
            if (defaultInstance != null)
            {
                Console.WriteLine("Default instance of FindClosestEvenNumber created using reflection.");
            }

            if (parameterizedInstance != null)
            {
                Console.WriteLine("Parameterized instance of FindClosestEvenNumber created using reflection.");
            }

            // Invoke the FindClosestEven method on the instance using reflection
            object result = fetcher.InvokeMethod(parameterizedInstance, "FindClosestEvenNumber", 17);

            // Check if the method invocation was successful and print the result
            if (result != null)
            {
                Console.WriteLine("Method invoked successfully. Result: " + result);
            }

            Console.ReadLine();

        }
    }
}
