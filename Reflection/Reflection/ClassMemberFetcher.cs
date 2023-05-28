using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class ClassMemberFetcher
    {
        public static void FetchClassMembers(Type type)
        {
            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine(method.ToString());
            }

            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo constructor in type.GetConstructors())
            {
                Console.WriteLine(constructor.ToString());
            }

            Console.WriteLine("\nProperties:");
            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine(property.ToString());
            }
        }
    }
}
