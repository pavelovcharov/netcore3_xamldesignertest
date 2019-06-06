using System;
using System.Reflection;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            var assembly = Assembly.LoadFrom("TestControl.dll");

            foreach(var type in assembly.GetExportedTypes()) {
                var attrs = type.GetCustomAttributesData();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
