using PhoneBookApp.Models;
using PhoneBookApp.Services;
using PhoneBookApp.Helpers;

class Program
{
    static void Main()
    {
        PhoneBook phoneBook = new PhoneBook();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Phone Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("3. View Single Contact"); 
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Search Contact");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");


            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    ContactActions.AddContact(phoneBook);
                    break;
                case "2":
                    ContactActions.ViewContacts(phoneBook);
                    break;
                case "3":
                    ContactActions.ViewSingleContact(phoneBook);
                    break;
                case "4":
                    ContactActions.UpdateContact(phoneBook);
                    break;
                case "5":
                    ContactActions.DeleteContact(phoneBook);
                    break;
                case "6":
                    ContactActions.SearchContact(phoneBook);
                    break;
                case "7": exit = true; break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }


}
