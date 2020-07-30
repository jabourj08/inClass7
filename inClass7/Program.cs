using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace inClass7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers[0] = 8;
            numbers.Insert(1, 12);
            numbers.Add(6);
            numbers.Add(100);
            numbers.Add(999);

            Console.WriteLine("For Loop");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Foreach Loop");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }




            //Think of a hash table, or dictionary, as an object that draws a line from a key to a value
            Console.WriteLine();
            Console.WriteLine("***** HASH TABLE EXAMPLE *****");

            Hashtable ht = new Hashtable();
            //1) keys map to the same value
            //2) a key may ONLY map to a single value

            ht.Add(1, "John");
            //ht.Add(1-3, "Timmy");
            ht.Add(2, "John");
            ht.Add("crazy", true);
            ht.Add("002", "Paul");
            ht.Add(3, true);
            ht.Add(0, false);
            ht.Add(-1, "error");

            foreach (object k in ht.Keys)
            {
                Console.WriteLine();
                Console.WriteLine("Key: " + k);
                Console.WriteLine("Value: " + ht[k]);
            }

            //Dictionary Example
            Console.WriteLine();
            Console.WriteLine("***** DICTIONARY EXAMPLE *****");
            Dictionary<string, bool> goodFoodDictionary = new Dictionary<string, bool>();

            goodFoodDictionary.Add("Egg Salad", false);
            goodFoodDictionary.Add("Pasta", true);
            goodFoodDictionary.Add("Peaunt Butter and Jelly", true);
            goodFoodDictionary.Add("Asparagus", false);

            foreach(string key in goodFoodDictionary.Keys)
            {
                Console.WriteLine("Key: " + key);
                Console.WriteLine("Value: " + goodFoodDictionary[key]);
                Console.WriteLine();
            }
            */
            List<string> partyGuests = new List<string>();

            AddGuest(partyGuests);
            RemoveGuest(partyGuests);

            bool cont = true;
            while (cont)
            Console.WriteLine(CanAttendParty(partyGuests));

        }

        public static void AddGuest(List<string> partyGuests)
        {
            bool cont = true;
            string answer = "";
            

            while (cont)
            {
                
                Console.WriteLine("Please enter a name to add to the guest list.");
                string name = Console.ReadLine();

                partyGuests.Add(name);

                Console.WriteLine("Would you like to add another name? y/n");
                answer = Console.ReadLine();

                if (answer[0] == 'n')
                {
                    cont = false;
                }
                else
                {
                    cont = true;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Your guests are as follows: ");
            foreach (string name in partyGuests)
            {
                Console.WriteLine(name);
            }
        }

        public static void RemoveGuest(List<string> partyGuests)
        {
            bool cont = true;
            string answer = "";

            while (cont)
            {

                Console.WriteLine("If there is someone you need to remove from the Guest List, enter their name. Otherwise just hit the return key.");
                string name = Console.ReadLine();

                partyGuests.Remove(name);

                Console.WriteLine("Would you like to remove another name? y/n");
                answer = Console.ReadLine();

                if (answer[0] == 'n')
                {
                    cont = false;
                }
                else
                {
                    cont = true;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Your guests are as follows: ");
            foreach (string name in partyGuests)
            {
                Console.WriteLine(name);
            }
        }

        public static bool CanAttendParty(List<string> partyGuests)
        {
            bool canAttend = true;
            string answer = "";

            Console.WriteLine("Enter a name to check if that guest can attend the party.");
            string name = Console.ReadLine();

            if (partyGuests.Contains(name))
            {
                string vowels = "aeiou";
                int numOfVowels = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (name[i] == vowels[j])
                        {
                            numOfVowels++;
                        }
                    }
                }

                if (numOfVowels > 1 && Char.IsUpper(name[0]))
                {
                    canAttend = true;
                }
                else
                {
                    canAttend = false;
                }

            }

            return canAttend;
        }
    }
}
