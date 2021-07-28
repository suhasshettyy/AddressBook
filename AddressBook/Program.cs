using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        
        public static List<AddressBookMainDetails> list = new List<AddressBookMainDetails>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Program program = new Program();
            program.AddDetails();
            foreach (var person in list)
            {
                program.Contactdisplay(person);
            }
        }
        public void AddDetails()
        {
            AddressBookMainDetails addressbook = new AddressBookMainDetails();
            Console.WriteLine("enter Firstname,LastName,Adress,State,City,Zip,Phonenumber,Mail");
            addressbook.Firstname = Console.ReadLine();
            addressbook.Lastname = Console.ReadLine();
            addressbook.Address = Console.ReadLine();
            addressbook.State = Console.ReadLine();
            addressbook.City = Console.ReadLine();
            addressbook.Zip = Console.ReadLine();
            addressbook.Phonenumber = Console.ReadLine();
            addressbook.Mail = Console.ReadLine();
            list.Add(addressbook);
        }
        public void Contactdisplay(AddressBookMainDetails person)
        {
            Console.WriteLine("FirstName : " + person.Firstname + "\n" + "LastName : " + person.Lastname + "\n" + "Address : " + person.Address + "\n"
                           + "State : " + person.State + "\n" + "City : " + person.City + "\n" + "Zip : " + person.Zip + "\n"
                           + "PhoneNumber : " + person.Phonenumber + "\n" + "Mail Id : " + person.Mail);
        }
    }
}