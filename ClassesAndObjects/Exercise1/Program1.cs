using System;

namespace Exercise1
{
    class Product
    {
        decimal price;
        int amount;
        string name;
        public Product(decimal price, int amount, string name)
        {
            this.price = price;
            this.amount = amount;
            this.name = name;
        }

        public decimal PriceChange
        {
            get
            {
                return price;
            }
            set
            {
                price += value;
            }
        }

        public int AmountChange
        {
            get
            {
                return amount;
            }
            set
            {
                amount += value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void PrintProduct()
        {
                                            //Banana, price 1.10, amount 13
            Console.WriteLine($"{Name}, price {Decimal.Round(PriceChange, 2)}, amount {AmountChange}");
        }

        //public void ChangeQuantity(int amount)
        //{
        //    this.amount += amount;
        //}

        //public void ChangePrice(decimal amount)
        //{
        //    this.price += amount;
        //}
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

            iPhone.PriceChange = -0.01m;
            iPhone.AmountChange = 11;
            iPhone.PrintProduct();

            Console.ReadKey();
        }
    }
}
