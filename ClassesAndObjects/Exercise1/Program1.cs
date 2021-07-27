using System;

namespace Exercise1
{
    class Product
    {
        decimal Price;
        int Amount;
        string Name;
        public Product(decimal price, int amount, string name)
        {
            this.Price = price;
            this.Amount = amount;
            this.Name = name;
        }

        public void PrintProduct()
        {
                                            //Banana, price 1.1, amount 13
            Console.WriteLine($"{Name}, price {Decimal.Round(Price, 2)}, amount {Amount}");
        }

        public void ChangeQuantity(int amount)
        {
            this.Amount += amount;
        }

        public void ChangePrice(decimal amount)
        {
            this.Price += amount;
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Product mouse, iPhone, Epson;

            mouse = new Product(70.00m, 14, "Logitech mouse");
            iPhone = new Product(999.99m, 3, "iPhone 5s");
            Epson = new Product(440.46m, 1, "Epson EB-U05");

            mouse.PrintProduct();
            iPhone.PrintProduct();
            Epson.PrintProduct();
            
            Console.WriteLine("\n change:");

            iPhone.ChangePrice(-0.01m);
            iPhone.ChangeQuantity(11);
            iPhone.PrintProduct();

            Console.ReadKey();
        }
    }
}
