using System;
using System.Collections.Generic; //Обовязково добавити!!!

namespace Ex5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<plane> st_man = new Stack<plane>();
            plane fellow = new plane("private", "Airbus A320neo", 850, 6);
            st_man.Push(fellow);
            st_man.Push(new plane("private", "Boeing 777X", 900, 7));
            st_man.Push(new plane("private", "Boeing 737MAX.", 915, 9 ));
            try
            {
                Console.WriteLine(st_man.Peek());
                st_man.Pop();
                Console.WriteLine(st_man.Peek());
                st_man.Pop();
                Console.WriteLine(st_man.Peek());
                st_man.Pop();
                Console.WriteLine(st_man.Peek());
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }
            Console.WriteLine("Finish!");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
