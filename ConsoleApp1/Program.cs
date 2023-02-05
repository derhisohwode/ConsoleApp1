using Crag;
using imported;
using System.Runtime.InteropServices;
using static Crag.Class1;
using static Con.Class2;

namespace clasp
{
    public class practice
    {
        static float a = 3.12F;
        int _b ;
        int _c;
        public practice(int c, int b) { 
            this._c = c;
            this._b = b;
        }

        public float Prite()
        {
            return (a * this._b)/this._c;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Start:
            Programer.Main();
            Console.WriteLine("Enter a number from 0 - 100");
            string dra = Console.ReadLine();
            int drag = int.Parse(dra);
            practice D1 = new practice(5, drag);
            float result = D1.Prite();
            Console.WriteLine($"result is {result}");
            if (result <= 5)
            {
                
                Main2();
            } else
            {
                Main2();
            }

            Console.WriteLine("Enter a number from 0 - 100");
            string dra1 = Console.ReadLine();
            int drag1 = int.Parse(dra1);
            practice D2 = new practice(drag1, 10);
            float result1 = D2.Prite();
            Console.WriteLine($"result is {result1}");
            if (result1 <= 5)
            { 
                Main1();
            }
            else
            {
                Main2();
            }

            Console.WriteLine("wanna go again: yes or no");
            string ans = Console.ReadLine().ToUpper();
            if (ans == "YES")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("Thank you");
            }

        }
    }
}