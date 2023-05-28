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
        public void FetchClassMembers(Type type)
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

            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in type.GetFields())
            {
                Console.WriteLine($"- {field.Name}");
            }
        }
        public object CreateInstance(Type classType, params object[] constructorArgs)
        {
            object instance = null;

            // Get the constructor with matching parameter types
            ConstructorInfo constructor = classType.GetConstructor(GetParameterTypes(constructorArgs));
            if (constructor != null)
            {
                instance = constructor.Invoke(constructorArgs);
            }

            return instance;
        }

        private Type[] GetParameterTypes(object[] parameters)
        {
            Type[] parameterTypes = new Type[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                parameterTypes[i] = parameters[i].GetType();
            }
            return parameterTypes;
        }
    }
}
