using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorMart
{
    class Product
    {
        private string name;
        private int quantity;
        private double price;
        private string category;
        private static int totalProducts;

        static List<Product> inventory = new List<Product>();

        public override string ToString()
        {
            return category + "\t\t" + name + "\t\t" + quantity + "\t\t" + price + "\n";
        }

        public Product() { }

        static Product()
        {
            inventory.Add(new Product("Dairy", "Milk", 200, 3.99));
            inventory.Add(new Product("Produce", "Apple", 300, 0.99));
            inventory.Add(new Product("Frozen", "Pizza", 400, 11.99));
            inventory.Add(new Product("Beauty", "Shampoo", 500, 7.99));
            inventory.Add(new Product("Meat", "Ribeye", 600, 25.99));
        }

        public Product(string pCategory, string pName, int pQuantity, double pPrice)
        {
            category = pCategory;
            name = pName;
            quantity = pQuantity;
            price = pPrice;

            totalProducts = totalProducts + pQuantity;
        }

        public string getProductCategory()
        {
            return category;
        }

        public string getProductName()
        {
            return name;
        }

        public int getProductQuantity()
        {
            return quantity;
        }

        public double getProductPrice()
        {
            return price;
        }

        public static int getProductTotal()
        {

            return totalProducts;
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Product Manager");
            Console.WriteLine();
            Console.WriteLine("1. Add a product");
            Console.WriteLine("2. Display inventory list");
            Console.WriteLine("3. Search for a product");
            Console.WriteLine("4. Display total quantity of products");
            Console.WriteLine("5. Exit");

            return 1;
        }

        public static void DisplayTotalQuantity()
        {
            int t = Product.getProductTotal();
            Console.WriteLine("Total Quantity = {0}", t);
            Console.ReadLine();
        }

        public static void DisplayInventory()
        {
            Console.WriteLine("\nCategory\tProduct\t\tQuantity\tPrice");
            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (Product p in inventory)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
        }

        public void AddProduct()
        {
            Console.Write("\nPlease enter the product category: ");
            string ctgry = Console.ReadLine();
            Console.Write("\nPlease enter the product name: ");
            string nme = Console.ReadLine();
            Console.Write("\nPlease enter the quantity delivered: ");
            int qty = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter the product price: ");
            double prc = double.Parse(Console.ReadLine());

            inventory.Add(new Product(ctgry, nme, qty, prc));

            Console.WriteLine("\n-----{0} added to inventory-----\n", nme);
        }

        public void SearchInventory()
        {
            Console.Write("\nPlease enter product name: ");
            string pname = Console.ReadLine();

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].name.Contains(pname))
                    {
                        Console.WriteLine("\n{0} was found!\n", pname);
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nItem not found.");
                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}


