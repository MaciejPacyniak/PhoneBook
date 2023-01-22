using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayContactDetails(Contact contact) 
        {
            Console.WriteLine($"Contact name:{contact.Name}, number: {contact.Number}");
        }
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(x => x.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
            
        }
        public void DisplayAll()
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatching(string searchPhrase)
        {
            var machingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(machingContacts);
            
        }
    }
}
