using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReflectionTest.Test();

            string path = @"D:\Visual Studio\Assignment\CollectionProblem\CollectionProblem\bin\Debug\CollectionProblem.dll";

            Assembly assembly = Assembly.LoadFile(path);

            Type[] types = assembly.GetTypes();
            foreach(var type  in types)
            {
                Console.WriteLine("Class: " + type.Name);

                MethodInfo[] methods = type.GetMethods();
                foreach(MethodInfo method in methods)
                {
                    Console.WriteLine("--Method:  " + method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(ParameterInfo param in parameters)
                    {
                        Console.WriteLine("---- Parameters:  " + param.Name + ":" + param.ParameterType);
                    }
                }
            }
        }
    }
}
