using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        //create public prop called contacts whose value type is Dictionary. Keys are strings, values are Contact instances
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();


        public void AddContact(Contact contactPerson)
        {
            try
            {
                Contacts.Add(contactPerson.Email, contactPerson);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You have added someone twice.");

            }

        }
        public Contact GetByEmail(string emailId)
        {
            try
            {
                return Contacts[emailId];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"No contact with {emailId} found.");
                return null;
            }
        }
    }
}