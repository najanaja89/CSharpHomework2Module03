using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework2Module03.git
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                string menu = "";
                Console.WriteLine("Press 1 to calculate count of spaces in strings");
                menu = Console.ReadLine();

                if (menu == "1") {
                    Console.WriteLine("Enter string, press '.' start calculate count of spaces ");
                    string temp = "";
                    string countOfSpace = "";
                    int count = 0;
                    while (temp != ".")
                    {
                        temp = Console.ReadLine();
                        countOfSpace += temp;
                        count = countOfSpace.Count(Char.IsWhiteSpace);
                    }
                    Console.WriteLine("Entered string is " + countOfSpace);
                    Console.WriteLine("Count of spaces is {0}", count);
                }
            }
            Console.ReadLine();
        }
    }
}
