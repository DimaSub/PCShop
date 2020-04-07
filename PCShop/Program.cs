using System;
using System.Collections.Generic;

namespace PCShop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int exit = 0;
            string menu = "Please input your option ->" +
                          "\n\n1->Add new computer" +
                          "\n2->Remove computer" +
                          "\n3->Print computer list by Company Name" +
                          "\n4->Print list of the computers" +
                          "\n5->Calculate the total price of the computers" +
                          "\n6->Еxit\n";

            while (exit != 6)
            {
                Console.WriteLine(menu);
                Console.Write("Please select an option: ");
                string optionchk = Console.ReadLine();

                while (!int.TryParse(optionchk, out int value))
                {
                    Console.Clear();
                    Console.Write("\"{0}\" is not a valid option, please select again: \n\n",optionchk);
                    Console.WriteLine(menu);
                    Console.Write("Please select an option: ");
                    optionchk = Console.ReadLine();
                }

                int option = int.Parse(optionchk);

                if (option > 0 && option < 7)
                {
                    if (option == 1)
                    {
                        Console.Clear();
                    }

                    if (option == 2)
                    {
                        Console.Clear();
                    }

                    if (option == 3)
                    {
                        Console.Clear();
                    }

                    if (option == 4)
                    {
                        Console.Clear();
                    }

                    if (option == 5)
                    {
                        Console.Clear();
                    }

                    if (option == 6)
                    {
                        exit = option;
                        Console.Clear();
                        Console.WriteLine("Thank you for using our software");
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("\"{0}\" is not a valid option, please select again\n", option);
                }
            }
        }
    }
}
