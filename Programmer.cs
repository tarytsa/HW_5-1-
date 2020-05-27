using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    class Programmer: IDeveloper, IComparable
    {
        string language;
        public string Tool { get; set; }

        public Programmer(string Language)
        {
            language = Language;
            Tool = Language;
        }
        public void Create()
        {
            Console.WriteLine("Programmer in {0} create a new project",language);
        }
        public void Destroy()
        {
            Console.WriteLine("Programmer in {0} destroy a  project", language);
        }

        public int CompareTo(object o)
        {
            Builder p = o as Builder;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else
                throw new Exception("Error");
        }

    }
}
