using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;


namespace Projects_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());     
            }
            Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
