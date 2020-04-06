using System;
using System.Collections.Generic;

namespace PCShop
{
    public class Computer
    {
        public Computer(int id, string brand, string processor, string storagetype, int storagesize, int ram, int price, int quantity)
        {
            this.id = id;
            this.brand = brand;
            this.processor = processor;
            this.storagetype = storagetype;
            this.storagesize = storagesize;
            this.ram = ram;
            this.price = price;
            this.quantity = quantity;
        }

        private int id;
        private string brand;
        private string processor;
        private string storagetype;
        private int storagesize;
        private int ram;
        private int price;
        private int quantity;
        //private List<Accessories> accessories;

        public int Id { get => id; set => id = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Processor { get => processor; set => processor = value; }
        public string Storagetype { get => storagetype; set => storagetype = value; }
        public int Storagesize { get => storagesize; set => storagesize = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }


}
