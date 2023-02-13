using System;
using System.Net.Http.Headers;

namespace exported
{
    interface Iclutch
    {
        void display();
    }

    public class gear : Iclutch
    {
        public void display() 
        {
            Console.WriteLine("I");
        }
    }
    interface Iblutch
    {
        void bisplay();
    }

    public class gear1 : Iblutch
    {
        public void bisplay()
        {
            Console.WriteLine("I2");
        }
    }

    public class AB : Iblutch, Iclutch
    {
        gear A = new gear();//instance
        gear1 B = new gear1();//instance
        public void bisplay()//implemenation
        {
            B.bisplay();
        }
        public void display()//implemenation
        {
            A.display();
        }

    }


    public class Programerclone
    {
        public static void Main15()
        {
            AB G = new AB();//instance
            G.display();
            G.bisplay();

        }
    }
}

