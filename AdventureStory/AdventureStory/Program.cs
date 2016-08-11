using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName;

            Console.WriteLine("Enter your character's name ");
            characterName = Console.ReadLine();

            Console.WriteLine("Hi, {0}.[ENTER]", characterName);
            Console.ReadLine();
            Console.WriteLine("You'll be starting school in a week. [ENTER]");
            Console.ReadLine();
            Console.WriteLine("So you'll have to go to the store to get a few items. [ENTER]");
            Console.ReadLine();
            Console.WriteLine("What you will need is: a backpack, a new outfit, and some grocery. [ENTER]");
            Console.ReadLine();
            Console.WriteLine("Let's get started. [ENTER]");
            Stores stores = new Stores();
            stores.RunStory();
            Console.WriteLine("{0}, you're now ready to go back to school.", characterName);
            Console.ReadLine();


          

        }

    }
}
