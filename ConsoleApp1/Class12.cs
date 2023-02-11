using Crag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface Igreat //interface
    {
        void Print();
    }
    interface Igreater //interface
    {
        void Printer();
        void Print();
}

    public struct ccream : Igreat, Igreater //inheritance
{
         void Igreat.Print() //explicit interface implementation
        {
            Console.WriteLine("gretness");
        }

        void Igreater.Print() //explicit interface implementation
    {
            Console.WriteLine("gretness extra");
        }
        void Igreater.Printer() //explicit interface implementation
    {
            Console.WriteLine("gretness super-extra");
        }


}
public class cream : Igreat, Igreater //inheritance
    {
        public void Print() //default interface implementation
    {
            Console.WriteLine("gretness is me");
        }
        public void Printer() //default interface implementation
    {
            Console.WriteLine("gretness is me!!");
        }

}



public class Class12
    {
        public static void Main9()
        {
        ccream d;
        d = new ccream();
        cream c = new cream();
        ((Igreat)d).Print();
        ((Igreater)d).Print();
        ((Igreater)d).Printer();

        ((Igreat)c).Print();
        ((Igreater)c).Print();
        ((Igreater)c).Printer();
    }
    }
