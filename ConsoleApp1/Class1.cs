using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crag
{
    public class Class2
    {
        string word = "Result is less than 5";
        public string print()
        {
            return word;
        }
    }

    public class Class1 {
        public static void Main1()
        {
            Class2 W3 = new Class2();
            string say = W3.print();
            Console.WriteLine(say);
        }
    }
}
