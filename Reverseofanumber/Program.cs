using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverseofanumber
{
    //using git 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while(num!=0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;

            }
            Console.WriteLine("Reverse of a number is "+sum);
        }
        //We have added one more line
    }
}
