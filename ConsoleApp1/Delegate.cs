using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cragy
{
    public delegate void delly(string Message, int dev);

    public class Class16 {
        public static void Main16()
        {
            delly del = new delly(Hello);
            del("resume ", 34);
        }

        public static void Hello(string Message, int dev)
        {
            Console.WriteLine(Message + dev);
        }
    }
}
