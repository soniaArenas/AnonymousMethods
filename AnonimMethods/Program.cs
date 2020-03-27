using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimMethods
{
    class Program
    {
        delegate void Printer(string s);
        static void Main(string[] args)
        {
            
            Printer printer = DoWork;
            Printer printer2 = delegate(string k){ Console.WriteLine(k); };

            //Instantiate the delgate type using an anonymous method
            Printer p = delegate (string j)
            {
                Console.WriteLine(j);

            };
            // Results from the anonymous delegate call
            p("The delegate using the anonymous method is called");

            //The delegate instantiation using a named method
            p = DoWork;

            //Results from the old style delegate call
            p("The delegate using the named method is called");

        }
        static void DoWork(string k)
        {
            Console.WriteLine(k);
        }

    }
}
