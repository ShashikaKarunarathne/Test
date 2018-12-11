using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code18
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial tute = new Tutorial();
            tute.SetTute(1 ,"Software Engineering");
            Console.Write(tute.GetID());
            Console.Write(tute.GetTute());
            Console.ReadKey();
        }
    }
}
