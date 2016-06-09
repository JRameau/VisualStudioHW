using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorMart
{
    class ProductManager
    {
        static void Main(string[] args)
        {
            int menu = 0;
            int num;
          

            do
            {
                menu = Product.DisplayMenu();
                Console.Write("\nPlease enter a number: ");
                num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 1:
                        Product a = new Product();
                        a.AddProduct();
                        break;

                    case 2:
                   
                        Product.DisplayInventory();
                        break;

                    case 3:

                        Product s = new Product();
                        s.SearchInventory();
                        break;

                    case 4:

                        Product.DisplayTotalQuantity();
                        break;

                    case 5:

                        break;
                }
            }
            while (num != 5);

            

            

            

           
               
              
            //list of unspecified size to store each product
            //List<Product> inventory = new List<Product>(); 

            //Product[] storeProducts = new Product[5]; //array to store each product

            /* inventory.Add(new Product("Dairy", "Milk", 100, 3.99));
             inventory.Add(new Product("Produce", "Apple", 100, 0.99));
             inventory.Add(new Product("Frozen", "Pizza", 100, 11.99));
             inventory.Add(new Product("Beauty", "Shampoo", 100, 7.99));
             inventory.Add(new Product("Meat", "Ribeye", 100, 25.99)); 


             Console.WriteLine("Category\tProduct\t\tPrice\t\tQuantity");
             Console.WriteLine("-------------------------------------------------------------------------");

             //Menu item 1: loop to display list of inventory
             //Product.displayInventory();          
             foreach (Product p in inventory) 
             {
                 Console.WriteLine(p.ToString());                
             }
             Console.ReadLine();



             //Menu item 2: method called to display total quantity of products
             int t = Product.getProductTotal(); 
             Console.WriteLine("Total Quantity = {0}", t);
             Console.ReadLine();


             //Menu item 3: Add a new product to store inventory
             Console.WriteLine("Please enter the product category:");
             string ctgry = Console.ReadLine();
             Console.WriteLine("Please enter the product name:");
             string nme = Console.ReadLine();
             Console.WriteLine("Please enter the quantity delivered:");
             int qty = int.Parse(Console.ReadLine());
             Console.WriteLine("Please enter the product price:");
             double prc = double.Parse(Console.ReadLine());


             inventory.Add(new Product(ctgry, nme, qty, prc));

             Console.WriteLine("{0} added to inventory!", nme);
             Console.ReadLine();
             Console.WriteLine("Printing updated inventory list....._");
             Console.ReadLine();
             foreach (Product p in inventory) 
             {
                 Console.WriteLine(p.ToString());                
             }
             Console.ReadLine();

             //Menu item 4: Search for a specific product
             Console.WriteLine("Please enter the item name you want to lookup");
             string name = Console.ReadLine();

             for (int i = 0; i < inventory.Count; i++)
             {
                 //if (inventory[i].Contains(name))
                 if (inventory[i].Equals(name))
                 {
                     Console.WriteLine("{0} was found!", name);
                     Console.ReadKey();
                 }
                 else
                 {
                     Console.WriteLine("Item not found. Please enter 2 to add item to inventory");
                     Console.ReadLine();
                     break;
                 }
                 */                
            }
            
        }
    }

    
