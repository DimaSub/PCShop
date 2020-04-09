using System;
using System.Collections.Generic;
using System.Linq;

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
            List<Computer> pcList = new List<Computer>();
            int id = 0;

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
                        Console.Write("Enter computer brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter processor type: ");
                        string processor = Console.ReadLine();
                        Console.Write("Enter storage type: ");
                        string storagetype = Console.ReadLine();
                        Console.Write("Enter storage size: ");
                        int storagesize = int.Parse(Console.ReadLine());
                        Console.Write("Enter RAM size: ");
                        int ram = int.Parse(Console.ReadLine());
                        Console.Write("Enter computers price: ");
                        int price = int.Parse(Console.ReadLine());
                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        pcList.Add(new Computer(id, brand, processor, storagetype, storagesize, ram, price, quantity));
                        id++;
                        Console.Clear();
                        Console.WriteLine("Computer added\n");
                    }

                    if (option == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Computers in inventory:");

                        foreach (Computer list in pcList)
                        {
                            Console.WriteLine(list+"\n");
                        }

                        Console.Write("Please select id to delete: ");
                        int del = int.Parse(Console.ReadLine());
                        var id_del = pcList.SingleOrDefault(x => x.Id == del);
                        if (id_del != null)
                        {
                            pcList.Remove(id_del);
                            Console.Clear();
                            Console.WriteLine("ID: {0} was successfully deleted\n", del);
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ID not found\n");
                        }
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
