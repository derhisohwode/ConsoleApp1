using imported;
using importee;
using importees;
using exported;
using System.Runtime.InteropServices;
using static Crag.Class1;
using static Con.Class2;
using static Conso.Class13;
using static Consol.Class14;
using static ClassInterface;
using Consol;
using static Class17;
using static Class18;
using static Class19;
using static Class12;
using static Cragy.Class16; 


namespace clasp
{
    public class practice
    {
        static float a = 3.12F;
        int _b ;
        int _c;
        public practice(int c, int b) //constructor
        { 
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
            Main8();
            Main16();
            Main9();
            Main17();
            Main18();
            Main19();
            ProgramerProps.Main11();
            Programer2.Main10();
            Programerclone.Main15();
            Programer.Main();
            Console.WriteLine("Enter a number from 0 - 100");
            string dra = Console.ReadLine();
            int drag = int.Parse(dra);
            practice D1 = new practice(5, drag); //using the constructor
            float result = D1.Prite();
            Console.WriteLine($"result is {result}");
            if (result <= 5)
            {

                Main2();

            }
            else
            {
                Main2();
            }

            Console.WriteLine("Enter a number from 0 - 100");
            string dra1 = Console.ReadLine();
            int drag1 = int.Parse(dra1);
            practice D2 = new practice(drag1, 10);
            float result1 = D2.Prite();
            Main6();
            Main7();
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