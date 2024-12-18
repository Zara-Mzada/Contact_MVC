using Contact_MVC.Models;

namespace Contact_MVC.Repository;

public static class ContactRepository
{
    private static List<Contact> contacts = new List<Contact>()
    {
        new Contact() { ID = 1, Name = "John", Surname = "Doe", Number = "1234567890", URL = "img/contact1.png"},
        new Contact() { ID = 2, Name = "Jane", Surname = "Smith", Number = "0987654321", URL = "img/contact5.png"},
        new Contact() { ID = 3, Name = "Michael", Surname = "Brown", Number = "1122334455", URL = "img/contact3.png"},
        new Contact() { ID = 4, Name = "Emily", Surname = "Davis", Number = "2233445566", URL = "img/contact6.png"},
        new Contact() { ID = 5, Name = "Chris", Surname = "Wilson", Number = "3344556677", URL = "img/contact2.png"},
        new Contact() { ID = 6, Name = "Sarah", Surname = "Johnson", Number = "4455667788", URL = "img/contact6.png"},
        new Contact() { ID = 7, Name = "David", Surname = "Taylor", Number = "5566778899", URL = "img/contact1.png"},
        new Contact() { ID = 8, Name = "Laura", Surname = "Moore", Number = "6677889900", URL = "img/contact5.png"},
        new Contact() { ID = 9, Name = "Robert", Surname = "Anderson", Number = "7788990011", URL = "img/contact2.png"},
        new Contact() { ID = 10, Name = "Sophia", Surname = "Thomas", Number = "8899001122", URL = "img/contact5.png"},
        new Contact() { ID = 11, Name = "James", Surname = "Jackson", Number = "9900112233", URL = "img/contact1.png"},
        new Contact() { ID = 12, Name = "Olivia", Surname = "White", Number = "1000112233", URL = "img/contact5.png"},
        new Contact() { ID = 13, Name = "Daniel", Surname = "Harris", Number = "2000112233", URL = "img/contact4.png"},
        new Contact() { ID = 14, Name = "Grace", Surname = "Martin", Number = "3000112233", URL = "img/contact6.png"},
        new Contact() { ID = 15, Name = "Matthew", Surname = "Lee", Number = "4000112233", URL = "img/contact1.png"},
        new Contact() { ID = 16, Name = "Lily", Surname = "Perez", Number = "5000112233", URL = "img/contact5.png"},
        new Contact() { ID = 17, Name = "Henry", Surname = "Young", Number = "6000112233", URL = "img/contact4.png"},
        new Contact() { ID = 18, Name = "Chloe", Surname = "Hall", Number = "7000112233", URL = "img/contact6.png"},
        new Contact() { ID = 19, Name = "Ethan", Surname = "Allen", Number = "8000112233", URL = "img/contact3.png"},
        new Contact() { ID = 20, Name = "Ava", Surname = "King", Number = "9000112233", URL = "img/contact6.png"}
    };

    public static List<Contact> GetContacts()
    {
        return contacts;
    }

    public static void AddContact(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine("Contact added");
    }
}