using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    class Builder:IDeveloper//,IComparable<IDeveloper>
    {
        string tool;

        public string Tool { get; set; }
        public Builder(string tool)
        {
            this.tool = tool;
            Tool = tool;
        }


        public void Create()
        {
            Console.WriteLine("Builder with {0} do some work",tool);
        }

        public void Destroy()
        {
            Console.WriteLine("Builder with {0} destroy", tool);
        }
        public int CompareTo(object o)
        {
            Programmer p = o as Programmer;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else
                throw new Exception("Error");
        }

        
    }
}
