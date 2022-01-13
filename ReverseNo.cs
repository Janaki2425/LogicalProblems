using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNo
    {
        public static void ReverseNumber()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
    

