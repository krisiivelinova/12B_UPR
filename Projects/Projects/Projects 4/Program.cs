using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;

namespace Projects_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sethurday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(days[day - 1]);

            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
