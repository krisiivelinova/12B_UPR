﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numburs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numburs.Length; i++) 
            {
                int currentNumburs = numburs[i];
                if (currentNumburs % 2 ==0)
                {
                    sum += currentNumburs;
                }
                Console.WriteLine(sum);

        }
    }
}
