using PhoneBookApp.Models;
using PhoneBookApp.Services;

namespace PhoneBookApp.Helpers
{
    public static class ContactActions
    {
        public static void AddContact(PhoneBook phoneBook)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Enter Email: ");
            string email = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Enter Address: ");
            string address = Console.ReadLine()?.Trim() ?? "";

            List<string> missingFields = new();
            if (string.IsNullOrWhiteSpace(name)) missingFields.Add("Name");
            if (string.IsNullOrWhiteSpace(phone)) missingFields.Add("Phone Number");
            if (string.IsNullOrWhiteSpace(email)) missingFields.Add("Email");
            if (string.IsNullOrWhiteSpace(address)) missingFields.Add("Address");

            if (missingFields.Count > 0)
            {
                Console.WriteLine($"Contact not created. Missing: {string.Join(", ", missingFields)}");
                return;
            }

            // Phone validation
            if (!phone.All(char.IsDigit))
            {
                Console.WriteLine("Phone Number must contain only digits.");
                return;
            }
            if (phone.Length < 7)
            {
                Console.WriteLine("Phone Number must be at least 7 digits long.");
                return;
            }

            phoneBook.AddContact(new Contact
            {
                Name = name,
                PhoneNumber = phone,
                Email = email,
                Address = address
            });

            Console.WriteLine("Contact added successfully!");
        }

        public static void ViewContacts(PhoneBook phoneBook)
        {
            var contacts = phoneBook.GetSortedContacts();
            if (contacts.Count == 0) Console.WriteLine("No contacts available.");
            else contacts.ForEach(c => Console.WriteLine(c));
        }

        public static void UpdateContact(PhoneBook phoneBook)
        {
            Console.Write("Enter Name of contact to update: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter New Name: ");
            string newName = Console.ReadLine() ?? "";
            Console.Write("Enter New Phone: ");
            string newPhone = Console.ReadLine() ?? "";
            Console.Write("Enter New Email: ");
            string newEmail = Console.ReadLine() ?? "";
            Console.Write("Enter New Address: ");
            string newAddress = Console.ReadLine() ?? "";

            bool updated = phoneBook.UpdateContact(name, new Contact
            {
                Name = newName,
                PhoneNumber = newPhone,
                Email = newEmail,
                Address = newAddress
            });

            Console.WriteLine(updated ? "✅ Contact updated!" : "Contact not found.");
        }

        public static void DeleteContact(PhoneBook phoneBook)
        {
            Console.Write("Enter Name of contact to delete: ");
            string name = Console.ReadLine() ?? "";
            bool deleted = phoneBook.DeleteContact(name);
            Console.WriteLine(deleted ? "✅ Contact deleted!" : "Contact not found.");
        }

        public static void SearchContact(PhoneBook phoneBook)
        {
            Console.Write("Enter name or phone to search: ");
            string keyword = Console.ReadLine() ?? "";
            var results = phoneBook.SearchContact(keyword);

            if (results.Count == 0) Console.WriteLine("No matching contacts.");
            else results.ForEach(c => Console.WriteLine(c));
        }

        public static void ViewSingleContact(PhoneBook phoneBook)
        {
            Console.Write("Enter Name or Phone Number of the contact: ");
            string input = Console.ReadLine()?.Trim() ?? "";

            var contact = phoneBook.GetContact(input);

            if (contact == null)
                Console.WriteLine(" Contact not found.");
            else
                Console.WriteLine($" Contact found:\n{contact}");
        }
    }
}
