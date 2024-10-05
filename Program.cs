using System;
using System.Collections.Generic;

namespace OnlineMarketing
{
    class Program
    {
        public static List<string> cart = new List<string>();  //creating list

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add dress to cart");
                Console.WriteLine("2. Remove dress from cart");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)      //switch case
                {
                    case 1:
                        AddDressToCart();
                        break;
                    case 2:
                        RemoveDressFromCart();
                        break;
                    case 3:
                        ViewCart();
                        break;
                    case 4:
                        Console.WriteLine("Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddDressToCart()           //creating addDressToCart Method
        {
            Console.Write("Enter the dress name: ");
            string dressName = Console.ReadLine();
            cart.Add(dressName);
            Console.WriteLine("Successfully added to the cart.");
        }

        static void RemoveDressFromCart()    //creating removeDressFromCart method
        {
            Console.Write("Enter the dress name to remove: ");
            string dressName = Console.ReadLine();
            if (cart.Remove(dressName))
            {
                Console.WriteLine("Successfully removed from the cart.");
            }
            else
            {
                Console.WriteLine("Dress not found in the cart.");
            }
        }

        static void ViewCart()                       //creating ViewCart mathod
        {
            Console.WriteLine("Your cart contains:");
            foreach (string dress in cart)
            {
                Console.WriteLine(dress);
            }
        }
    }
}