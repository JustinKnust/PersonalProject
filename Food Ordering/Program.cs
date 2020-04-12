using System.IO;
using System;
class Program
{
    static void Main ()
    {
        string input;
        //prompt user to enter hamburger or hotdog
        Console.Write("Enter your choice of Hamburger or Hotdog :/t");
        input = Console.ReadLine();
        if (input == "Hamburger")
        {
            String item;
            //prompt the user for the type of hamburger
            Console.Write("What kind of hamburger would you like? Type it below! ");
            item = Console.ReadLine();
            //display the ordered items
            Console.WriteLine("You have ordered : " + item + "" + input);
            Console.WriteLine("Thank you for odering! Come agian.");
        }
        //if the user chooses toppings
        else if (input == "Hotdog")
        {
            int num;
            string toppings;
            //prompt the user for number of toppings
            Console.Write("Enter Number of toppings");
            num = Convert.ToInt32(Console.ReadLine());
            //prompt the user to chose from a list of toppings

            Console.Write("Mustard/Relish/pickles/ketchup/onions/chilli/cheese Enter your choice :/t");
            toppings = Console.ReadLine();
            //display the ordered items
            Console.WriteLine("You have ordered: " + num + "" + toppings + "" + input);
            Console.WriteLine("Thank you for odering! Come again.");
        }
    }
}
