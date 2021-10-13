
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;

namespace Projects_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", arr.Reverse()));



        }
    }
}
