using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            MyDateTime md = new MyDateTime(14, 3, 2023, 0, 0, 0);
            Console.WriteLine(md);
            MyDateTime md2 = new MyDateTime(23, 6, 2023);
        }
    }
}
