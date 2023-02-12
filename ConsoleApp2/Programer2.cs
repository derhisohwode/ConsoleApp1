using System;

namespace importees
{
    public abstract class Abs 
    {
        public abstract void Print();//Abstract method
        public static void Brint()//non abstract method
        {
            Console.WriteLine("rise");
        }

        public int derick;

    }

    interface Abs1 { 
         void deric();

    }

    interface Icompare : Abs1 //interface
    {
        void Prit();
    }

    public class Programer2 : Abs, Icompare //inheritance of a abstract class and interface
    {
        public override void Print()
        {
            Console.WriteLine("ere");
        }
        void  Icompare.Prit()
        {
            Console.WriteLine("ereer");
        }
        public void deric()
        {
            Console.WriteLine("dere");
        }


        public static void Main10()
        {
            Programer2 D1 = new Programer2(); //instantiate
            D1.Print();
            ((Icompare)D1).Prit();
            D1.derick = 10;
            D1.deric();
            Console.WriteLine(D1.derick);
            Brint();


        }

    }
}

