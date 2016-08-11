using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Stores
    {
        private string departmentStores;

        public Stores()

        {

            departmentStores = Console.ReadLine();

        }
        public void setStoreType()
        {
            Console.WriteLine("Please type one of the following store, then press [Enter] key: Clothing, School Supply, or Grocery");
            departmentStores = Console.ReadLine()
;        }
            public void enterDeparmentStores()
        {

            
            switch (departmentStores)
            {
                case "Clothing":
                    Console.WriteLine("Welcom to Micki's Clothing store.");
                    Console.WriteLine("Would you like to buy an outfit for $40? Yes/No");
                    string userchoice = Console.ReadLine();
                    if (userchoice == "yes")
                    {
                        Console.Write("Congrats, you have purchased an outfit!");
                    }
                    else
                    {
                        Console.WriteLine("Don't forget, you still need an outfit for school.");
                    }
                    if (userchoice == "no")
                    {
                        Console.WriteLine("You decided not to purchase an outfit for school.");
                    }
                    Console.WriteLine(" Have a great day, come back soon.");
                    break;

                case "School Supply":
                    Console.WriteLine("Welcome to Everything School Supplies.");
                    Console.WriteLine("Would you like to buy a brand new backpack for $12? Yes/No");
                    string userStoreChoice = Console.ReadLine();
                    if (userStoreChoice == "yes")
                    {
                        Console.WriteLine("Congrats, you have purchased a brand new backpack!");
                    }
                    else
                    {
                        Console.WriteLine("Don't forget, you still need a backpack for school.");
                    }
                    if (userStoreChoice == "no")
                    {
                        Console.WriteLine("You decided not to purchase a new backpack for school.");
                    }
                    Console.WriteLine(" Best of Luck to you champ");
                    break;

                case "Grocery":
                    Console.WriteLine("Welcome to The Modern Produce.");
                    Console.WriteLine("Would you like to purchase this bag of groceries for $18? Yes/No");
                    userchoice = Console.ReadLine();
                    if (userchoice == "yes")
                    {
                        Console.WriteLine("Congrats, you have purchased a weeks worth of grocery.");
                    }
                    else
                    {
                        Console.WriteLine("Don't forget, you still need food for the week.");
                    }
                    if (userchoice == "no")
                    {
                        Console.WriteLine("You decided not to purchase grocery for the week.");
                    }
                    Console.WriteLine(" Thank you for choosing Modern Porduce, see you soon.");
                    break;

                default:
                    Console.WriteLine("NOT VALID, Please pick a store between: Clothing, School Supply, or Grocery.");
                    break;
            }
        }
        public void RunStory()
        {
            bool keepBuying = true;
            while (keepBuying)
            {
                setStoreType();
                enterDeparmentStores();
                Console.WriteLine("Would you like to buy more things? yes/no");
                string options = Console.ReadLine();
                if (options == "yes")
                {
                    Console.WriteLine();
                }
            
            else if (options == "no")
            {
                keepBuying = false;
            }
        }
        }

     }
}
