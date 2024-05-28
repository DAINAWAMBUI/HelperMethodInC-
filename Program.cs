using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args) 
        {
            //string myValue = superSecretFormula("world");
            string myValue = superSecretFormula("My World");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }
        private static string superSecretFormula()
        {
            return ("Hello World");
        }
        private static string superSecretFormula(string name)
        {
            return string.Format("Hello, {0}!" , name);
        }
    }
}
