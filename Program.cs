using System;
using System.Collections;
using System.Collections.Generic;


namespace HW_5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IDeveloper[] workers = new IDeveloper[3];

            Programmer Allan = new Programmer("Java");
            Builder Tom = new Builder("hammer");
            Programmer Lisa = new Programmer("C#");
            

            workers[0]=Allan;
            workers[1]=Tom;
            workers[2]=Lisa;

           
            foreach( var a in workers)
            {
                a.Create();
                a.Destroy();
                Console.WriteLine(a.Tool);
            }
            
            //sort by tool
            Array.Sort(workers);

            Console.WriteLine();
            foreach(var a in workers)
            {
                Console.WriteLine(a.Tool);
            }

        }
    }
}
