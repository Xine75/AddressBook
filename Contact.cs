using System;
using System.Collections.Generic;
namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }

    //we could create a constructor right here and then pass in values in Program.cs - instead we create the contacts on Program.cs

}