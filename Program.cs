using System;
using System.Collections;
using System.Collections.Generic;


namespace HW_5
{
    class Program
    {
        static void PrintCollection(List<IDeveloper> workers)
        {
            foreach (var item in workers)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<IDeveloper> workers = new List<IDeveloper>();

            Programmer Allan = new Programmer("Java");
            Builder Tom = new Builder("hammer");
            Programmer Lisa = new Programmer("C#");
            /////

            workers.Add(Allan);
            workers.Add(Tom);
            workers.Add(Lisa);

            PrintCollection(workers);
            foreach( var a in workers)
            {
                a.Create();
                a.Destroy();
                Console.WriteLine(a.Tool);
            }

            


        }
    }
}
