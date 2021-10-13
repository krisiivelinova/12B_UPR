using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;


namespace Projects_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numburs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numburs.Length; i++)
            {
                int currentNumburs = numburs[i];
                if (currentNumburs % 2 == 0)
                {
                    evenSum += currentNumburs;
                }
                else
                {
                    oddSum += currentNumburs;
                }
             }
            int differene = evenSum - oddSum;
            Console.WriteLine(differene);
        }
    }
}
