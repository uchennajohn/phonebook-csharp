using PhoneBookApp.Models;

namespace PhoneBookApp.Services
{
    public class PhoneBook
    {
        private List<Contact> contacts = new();

        // Add a new contact
        public void AddContact(Contact contact) => contacts.Add(contact);

        // View all contacts
        public List<Contact> GetAllContacts() => contacts;

        // Update a contact
        public bool UpdateContact(string name, Contact updatedContact)
        {
            var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact == null) return false;

            contact.Name = updatedContact.Name;
            contact.PhoneNumber = updatedContact.PhoneNumber;
            contact.Email = updatedContact.Email;
            contact.Address = updatedContact.Address;
            return true;
        }

        // Delete a contact
        public bool DeleteContact(string name)
        {
            var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact == null) return false;

            contacts.Remove(contact);
            return true;
        }

        // Search contact
        public List<Contact> SearchContact(string keyword)
        {
            return contacts.Where(c =>
                c.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                c.PhoneNumber.Contains(keyword)).ToList();
        }

        // Optional: Sort contacts
        public List<Contact> GetSortedContacts()
        {
            return contacts.OrderBy(c => c.Name).ToList();
        }

        public Contact? GetContact(string nameOrPhone)
        {
            return contacts.FirstOrDefault(c =>
                c.Name.Equals(nameOrPhone, StringComparison.OrdinalIgnoreCase) ||
                c.PhoneNumber.Equals(nameOrPhone));
        }
    }
}
