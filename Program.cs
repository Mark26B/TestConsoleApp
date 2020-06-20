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

            //persons[1].SetAge(15);
            
            foreach(var person in persons)
            {
                person.Introduce();
            }

            // Now the bank accounts
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Hamar", 7643, "EUR"));
            //accounts[0].Owner = "Hamar";
            //accounts[0].Number = "0001";
            //accounts[0].Created = DateTime.Now;
            //accounts[0].Balance = 8245;
            //accounts[0].Currency = "EUR";
            accounts[0].PrintInfo();
            accounts.Add(new BankAccount("Abdul", 318, "EUR"));
            accounts[1].PrintInfo();
        }
    }
}
