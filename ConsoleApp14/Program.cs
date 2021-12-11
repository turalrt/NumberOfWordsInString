using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14 /*tapsiriq 4*/
{
    internal class Program
    {
        public static void Main()
        {
            string str = ("This is Code Academy");
            int i = 0;
            int wordcount = 1;
            while (i < str.Length)
            {
                /* ' ' - bosluq; \n - yeni setr; */  
                if (str[i] == ' ' || str[i] == '\n')
                {
                    wordcount++;
                }
                i++;
            }
            Console.WriteLine("Total number of words in the string is: {0}",wordcount);
        }
    }
}
