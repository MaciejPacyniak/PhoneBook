using System;

namespace PhoneBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello in PhoneBook app");
            Console.WriteLine("1 - Add contact");
            Console.WriteLine("2 - Display contact by number");
            Console.WriteLine("3 - Display all contacts");
            Console.WriteLine("4 - Search contact");
            Console.WriteLine("x - insert to exit");
            Console.Write("Select:");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert Name");
                        var inputName = Console.ReadLine();
                        Console.WriteLine("Insert number");
                        var inputNumber = Console.ReadLine();
                        var contact = new Contact(inputName, inputNumber);
                        phoneBook.AddContact(contact);
                        break;
                    case "2":
                        Console.WriteLine("Insert number");
                        var inputNumber2 = Console.ReadLine();
                        phoneBook.DisplayContact(inputNumber2);
                        break;
                    case "3":
                        phoneBook.DisplayAll();
                        break;
                    case "4":
                        Console.WriteLine("Insert phrase");
                        var inputNumber3 = Console.ReadLine();
                        phoneBook.DisplayContact(inputNumber3);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
                Console.Write("Select:");
                userInput = Console.ReadLine();
            }
        }
    }
}
