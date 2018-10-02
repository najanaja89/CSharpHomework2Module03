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
            while (true)
            {
                string menu = "";
                Console.WriteLine("Press 1 to calculate count of spaces in strings");
                Console.WriteLine("Press 2 to calculate happy number of ticket");
                Console.WriteLine("Press 3 to change font to upper case");
                Console.WriteLine("Press 4 for task four");
                Console.WriteLine("Press 5 for task five");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.WriteLine("Enter string, press '.' start calculate count of spaces ");

                    string temp = "";
                    string countOfSpace = "";
                    int count = 0;

                    while (temp != ".")
                    {
                        temp = Console.ReadLine();
                        countOfSpace += temp;
                        count = countOfSpace.Count(Char.IsWhiteSpace);

                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] == '.') temp = ".";
                        }
              
                    }
                    Console.WriteLine();
                    Console.WriteLine("Entered string is " + countOfSpace);
                    Console.WriteLine("Count of spaces is {0}", count);
                }

                else if (menu == "2")
                {
                    string ticketNum = "";

                    while (ticketNum.Length != 6)
                    {
                        Console.WriteLine("Enter number of ticket (6 digits) ");
                        ticketNum = Console.ReadLine();
                        if (ticketNum.Length != 6) Console.WriteLine("Count of digits must equal 6!");

                        int ticketNumInt = 0;
                        bool result = int.TryParse(ticketNum, out ticketNumInt);
                        if (result == false)
                        {
                            Console.WriteLine("Ticket number must have a numbers!");
                            ticketNum = "";
                        }
                    }

                    int numOneInt = Convert.ToInt32(ticketNum[0]);
                    int numTwoInt = Convert.ToInt32(ticketNum[1]);
                    int numThreeInt = Convert.ToInt32(ticketNum[2]);
                    int numFourInt = Convert.ToInt32(ticketNum[3]);
                    int numFiveInt = Convert.ToInt32(ticketNum[4]);
                    int numSixInt = Convert.ToInt32(ticketNum[5]);

                    Console.WriteLine();

                    if ((numOneInt + numTwoInt + numThreeInt) == (numFourInt + numFiveInt + numSixInt)) Console.WriteLine("Ticket is Happy!");
                    else Console.WriteLine("Ticket is not  Happy(");

                }

                else if (menu == "3")
                {
                    Console.WriteLine("Enter string to convert");
                    string input = Console.ReadLine();
                    string output = "";
                    Console.WriteLine();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] >= 65 && input[i] <= 90)
                        {
                            output += Convert.ToChar(input[i] + 32);
                        }
                        else if (input[i] >= 97 && input[i] <= 122)
                        {
                            output += Convert.ToChar(input[i] - 32);
                        }
                        else output += Convert.ToChar(input[i]);
                    }
                    Console.WriteLine(output);
                }

                else if (menu == "4")
                {
                   
                    string stringA = "";
                    string stringB = "";
                    int intA = 0;
                    int intB = 0;
                    int row = 0;
                    int temp = 0;

                    while (stringA == "" || stringB == "")
                    {
                        Console.WriteLine("Enter num A value: ");
                        stringA = Console.ReadLine();
                        Console.WriteLine("Enter num B value: ");
                        stringB = Console.ReadLine();

                        bool result = int.TryParse(stringA, out intA);
                        if (result == false)
                        {
                            Console.WriteLine("Enter numeric value!");
                            stringA = "";
                        }

                        result = int.TryParse(stringB, out intB);
                        if (result == false)
                        {
                            Console.WriteLine("Enter numeric value!");
                            stringB = "";
                        }

                        if (intA > intB)
                        {
                            Console.WriteLine("num A value must be less than num B!");
                            stringA = "";
                        }

                        if (intA <= 0)
                        {
                            Console.WriteLine("num A must unsigned!");
                            stringA = "";
                        }
                    }
                    row = intB - intA;
                    row++;
                    temp = intA;
                    int[,] intArray = new int[row, intB];
                    Console.WriteLine();
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < temp; j++)
                        {
                            intArray[i, j] = temp;
                            Console.Write(intArray[i, j] + " ");
                        }
                        temp++;
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

                else if (menu == "5")
                {
                    string stringN = "";
                    int intN;

                    while (stringN == "")
                    {
                        Console.WriteLine("Enter N value: ");
                        stringN = Console.ReadLine();
                       

                        bool result = int.TryParse(stringN, out intN);
                        if (result == false)
                        {
                            Console.WriteLine("Enter numeric value!");
                            stringN = "";
                        }

                        if (intN <= 0)
                        {
                            Console.WriteLine("num N must unsigned!");
                            stringN = "";
                        }

                    }
                    Console.WriteLine();
                    char[] arrayChar = stringN.ToCharArray();
                    Array.Reverse(arrayChar);
                    Console.WriteLine(arrayChar);
                }
            }
            Console.ReadLine();
        }
    }
}
