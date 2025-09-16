using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using WebbShopMR.ProductData;


namespace WebbShopMR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool Running = true;

            List<Product> inventory = new List<Product>
            {
                new Book{Name = "Book1", Brand = "Book.Brand", Author = "William", Price = 199.95},
                new Clothing{Name = "", Brand = "", Size = "S", Price = 199.95},
                new Electronics{Name = "S22", Brand = "Samsung", WarrantyYears = 3, Price = 8999.95},
            };


            while(Running == true)
            {
                Console.Clear();
                Console.WriteLine("=== Tamims WebShop Admin Panel ===");
                Console.WriteLine("[1] Add Product");
                Console.WriteLine("[2] Show all products");
                Console.WriteLine("[3] Amount of Products");
                Console.WriteLine("[4] Total value");
                Console.WriteLine("[5] Change Global Discount");
                Console.WriteLine("[6] Quit");



                int Choice = int.Parse(Console.ReadLine()!);

                switch(Choice)
                {
                    case 1:
                        Console.WriteLine("=== Add Product ===");
                        AddProductsMenu(inventory);
                        break;


                    case 2:
                        Console.WriteLine("=== Showing All Products ===");
                        ShowAllProducts(inventory);
                        Console.WriteLine("Press any key to contonue");
                        Console.ReadKey();
                        break;


                    case 3:
                        Console.WriteLine($"{Product.TotalCount}");

                        break;


                    case 4:
                        Console.WriteLine("");
                        CalculateTotalValue(inventory);
                        break;


                    case 5:
                        Console.WriteLine("=== Change Global Discount ===");
                        ChangeGlobalDiscount();
                        Console.WriteLine("The discount is now added to all the products\nPress enter to continue");
                        Console.ReadKey();
                        break;


                    case 6:
                        Console.WriteLine("You chose 6");
                        Running = false;
                        break;


                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }


        static void AddProductsMenu(List<Product> inventory)
        {
            Console.WriteLine("[1] Book");
            Console.WriteLine("[2] Electronics");
            Console.WriteLine("[3] Clothing");

            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Book b = new Book();
                    FillCommonFields(b);
                    Console.Write("Author: ");
                    b.Author = Console.ReadLine()!;
                    inventory.Add(b);
                    break;

                case 2:
                    Electronics e = new Electronics();
                    FillCommonFields(e);
                    Console.Write("Warranty (Years): ");
                    e.WarrantyYears = int.Parse(Console.ReadLine());
                    inventory.Add(e);
                    break;

                case 3:
                    Clothing c = new Clothing();
                    FillCommonFields(c);
                    Console.Write("Size: ");
                    c.Size = Console.ReadLine();
                    inventory.Add(c);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
        static void FillCommonFields(Product p)
        {
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Brand: ");
            p.Brand = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine()); //This does not work because it is double
        }

        static void ShowAllProducts(List<Product> products)
        {
            foreach(Product p in products)
            {
                Console.WriteLine(p.ProductDetails());
            }
        }
        static double CalculateTotalValue(List<Product> inventory)
        {
            double sum = 0;
            foreach(Product p in inventory)
            {
                sum += p.Price;
            }

            Console.WriteLine($"The Total of all your products is: {sum} Dollars\nPress any button to continue:");
            Console.ReadKey();
            return sum;
        }
        static void ChangeGlobalDiscount()
        {
            Console.Write("New discount in %");
            double percent = int.Parse(Console.ReadLine()!);
            Product.SetGlobalDiscount(percent);
        }
        
    }
}
