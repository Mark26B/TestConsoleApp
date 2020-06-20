using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> persons = new List<Human>();

            persons.Add(new Human("Hamar", "Hajashkid", 78, "green"));
            persons.Add(new Human("Abdul", "Hajashkid", 53, "brown"));
            persons.Add(new Human("Muhhamed", "Hajashkid", 26, "green"));
            persons.Add(new Human("Jared", "White", 19, "blue"));

            persons[1].SetAge(15);
            
            foreach(var person in persons)
            {
                person.Introduce();
            }

            // Now the bank accounts
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add();
        }
    }
}
