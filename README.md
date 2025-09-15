# Phone Book Console Application (C#)

A simple console-based phone book application built in **C#** to manage contacts.  
This project demonstrates the use of **OOP principles**, collections (`List<T>`), LINQ, and console interaction.



 How to Run the Application

1. Clone this repository:
   ```bash
   git clone <your-repo-link>
2. Navigate into the project folder:
   cd PhoneBookApp
3. Build the project:
   dotnet build
4. Run the application:
   dotnet run

   Features Implemented

Add Contact

Create new contacts with Name, Phone Number, Email, and Address.

Prevents creating a contact if any field is empty.

Validates phone number (must contain only digits and be at least 7 digits long).

View All Contacts

Displays all contacts in the phone book.

Contacts are shown in alphabetical order by name.

View Single Contact (Extra Feature)

Search and view one contact by either name or phone number.

Update Contact

Edit an existing contact’s details.

Delete Contact

Remove a contact by name.

Search Contact

Search for contacts by name or phone number.

Supports partial matches (e.g., typing Jo matches "John" and "Joseph").

Exit

Closes the application safely.





Extra Features Added (Beyond Requirements)

Input Validation

Ensures no contact can be created with missing fields.

Phone number must be numeric and at least 7 digits long.

Single Contact Viewer

Ability to view one contact directly by name or phone number.




--- Phone Book Menu ---
1. Add Contact
2. View All Contacts
3. View Single Contact
4. Update Contact
5. Delete Contact
6. Search Contact
7. Exit
Choose an option: 1

Enter Name: John Doe
Enter Phone Number: 0801234567
Enter Email: john@example.com
Enter Address: Lagos

 Contact added successfully!
   


