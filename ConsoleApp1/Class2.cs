using Crag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con
{
    public class Class3
    {
        string word = "Result is greater than 5";
        public string print()
        {
            return word;
        }
    }

    public class Class2
    {
        public static void Main2()
        {
            Class3 W3 = new Class3();
            string say = W3.print();
            Console.WriteLine(say);
        }
    }
}
