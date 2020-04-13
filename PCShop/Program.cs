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
                        string storagechk = Console.ReadLine();

                        while (!int.TryParse(storagechk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid option, please select again: \n", storagechk);
                            Console.Write("Please enter correct storage size: ");
                            storagechk = Console.ReadLine();
                        }

                        int storagesize = int.Parse(storagechk);
                        Console.Write("Enter RAM size: ");
                        string ramchk = Console.ReadLine();

                        while (!int.TryParse(ramchk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid option, please select again: \n", ramchk);
                            Console.Write("Please enter correct RAM size: ");
                            ramchk = Console.ReadLine();
                        }

                        int ram = int.Parse(ramchk);
                        Console.Write("Enter computers price: ");
                        string pricechk = Console.ReadLine();

                        while (!int.TryParse(pricechk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid option, please select again: \n", pricechk);
                            Console.Write("Please enter correct price: ");
                            pricechk = Console.ReadLine();
                        }

                        int price = int.Parse(pricechk);
                        Console.Write("Enter quantity: ");
                        string quantitychk = Console.ReadLine();

                        while (!int.TryParse(quantitychk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid option, please select again: \n", quantitychk);
                            Console.Write("Please enter correct quantity: ");
                            quantitychk = Console.ReadLine();
                        }

                        int quantity = int.Parse(quantitychk);
                        Console.Write("Enter number of accessories to add: ");
                        string accessoriesnumchk = Console.ReadLine();

                        while (!int.TryParse(accessoriesnumchk, out int value))
                        {
                            Console.Write("\"{0}\" is not a valid option, please select again: \n", accessoriesnumchk);
                            Console.Write("Please enter correct number of accessories to add: ");
                            accessoriesnumchk = Console.ReadLine();
                        }

                        int accessoriesnum = int.Parse(accessoriesnumchk);
                        string[] accessories;
                        if (accessoriesnum != 0)
                        {
                            accessories = new string[accessoriesnum];
                            for (int i = 0; i < accessoriesnum; i++)
                            {
                                Console.Write("Enter accessory number {0} out of {1}: ", i + 1, accessoriesnum);
                                accessories[i] = Console.ReadLine();
                            }
                        }

                        else accessories = new string[1] {"None"};

                        pcList.Add(new Computer(id, brand, processor, storagetype, storagesize, ram, price, quantity, accessories));
                        id++;
                        Console.Clear();
                        Console.WriteLine("Computer added\n");
                    }

                    if (option == 2)
                    {
                        Console.Clear();
                        if (pcList.Any())
                        {
                            Console.WriteLine("Computers in inventory:");

                            foreach (Computer list in pcList)
                            {
                                Console.WriteLine(list + "\n");
                            }

                            Console.Write("Please select id to delete: ");
                            string delchk = Console.ReadLine();

                            while (!int.TryParse(delchk, out int value))
                            {
                                Console.Write("\"{0}\" is not a valid option, please select again: \n", delchk);
                                Console.Write("Please enter correct ID input: ");
                                delchk = Console.ReadLine();
                            }

                            int del = int.Parse(delchk);
                            var id_del = pcList.SingleOrDefault(x => x.Id == del);
                            if (id_del != null)
                            {
                                pcList.Remove(id_del);
                                Console.Clear();
                                Console.WriteLine("ID {0}: was successfully deleted\n", del);
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("ID not found\n");
                            }
                        }

                        else Console.WriteLine("No computers in inventory\n");
                    }

                    if (option == 3)
                    {
                        Console.Clear();
                        Console.Write("Please select pc brand to find: ");
                        string brand = Console.ReadLine();
                        Console.WriteLine();

                        List<Computer> pcBrand = new List<Computer>();

                        foreach (Computer list in pcList)
                        {
                            if (list.Brand == brand)
                            {
                                pcBrand.Add(list);
                            }
                        }

                        if (pcBrand.Any())
                        {
                            foreach (Computer list in pcBrand)
                            {
                                Console.WriteLine(list + "\n");
                            }
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Brand doesnt exist\n");
                        }
                    }

                    if (option == 4)
                    {
                        Console.Clear();
                        if (pcList.Any())
                        {
                            Console.WriteLine("Computers in inventory:");

                            foreach (Computer list in pcList)
                            {
                                Console.WriteLine(list + "\n");
                            }
                        }

                        else Console.WriteLine("No computers in inventory\n");
                    }

                    if (option == 5)
                    {
                        Console.Clear();
                        int sum = 0;
                        foreach (Computer list in pcList)
                        {
                            sum = sum + list.Price;
                        }

                        Console.Clear();
                        Console.WriteLine("Total computer price is: {0}\n", sum);
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
