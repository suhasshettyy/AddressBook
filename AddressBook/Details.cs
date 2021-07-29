using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        const int add = 1;
        const int edit = 2;
        const int firstname = 1;
        const int lastname = 2;
        const int address = 3;
        const int state = 4;
        const int city = 5;
        const int zip = 6;
        const int phonenumber = 7;
        const int mail = 8;
        const int display = 3;
        const int Exit = 0;
        public static List<Details> list = new List<Details>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Program program = new Program();
            while (true)
            {
                Details addressBook = new Details();
                Console.WriteLine("enter the option for the proper action\n" +
                    "0.For exiting from address book\n" +
                "1.For adding a contact\n" +
                "2.For editing a contact\n" +
                "3.For displaying the contact");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == Exit)
                {
                    break;
                }
                switch (choose)
                {
                    case add:
                        program.AddDetails();
                        break;
                    case edit:
                        program.EditContact();
                        break;
                    case display:
                        foreach (var person in list)
                        {
                            program.Contactdisplay(person);
                        }
                        Console.WriteLine(".....................................................");
                        break;
                    default:
                        Console.WriteLine("wrong input enter another input");
                        break;
                }

            }
        }
        public void AddDetails()
        {
            Details addressbook = new Details();
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
        public void Contactdisplay(Details person)
        {
            Console.WriteLine("FirstName : " + person.Firstname + "\n" + "LastName : " + person.Lastname + "\n" + "Address : " + person.Address + "\n"
                           + "State : " + person.State + "\n" + "City : " + person.City + "\n" + "Zip : " + person.Zip + "\n"
                           + "PhoneNumber : " + person.Phonenumber + "\n" + "Mail Id : " + person.Mail);
        }
        public void EditContact()
        {
            Details addressBook = new Details();
            foreach (var item in list)
            {
                Console.WriteLine("Enter the first name to search for the details");
                string searchname = Console.ReadLine();
                if (item.Firstname == searchname)
                {
                    Console.WriteLine("What you want to edit\n" +
                        "press 1 for firstname\n" +
                        "press 2 for lastname\n" +
                        "press 3 for address\n" +
                        "press 4 for state\n" +
                        "press 5 for city\n" +
                        "press 6 for Zip\n" +
                        "press 7 for phonenumber\n" +
                        "press 8 for mail ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case firstname:
                            Console.WriteLine("enter first name to change");
                            item.Firstname = Console.ReadLine();
                            break;
                        case lastname:
                            Console.WriteLine("enter last name to change");
                            item.Lastname = Console.ReadLine();
                            break;
                        case address:
                            Console.WriteLine("enter address to change");
                            item.Address = Console.ReadLine();
                            break;
                        case state:
                            Console.WriteLine("enter state to change");
                            item.State = Console.ReadLine();
                            break;
                        case city:
                            Console.WriteLine("enter city to change");
                            item.City = Console.ReadLine();
                            break;
                        case zip:
                            Console.WriteLine("enter zip to change");
                            item.Zip = Console.ReadLine();
                            break;
                        case phonenumber:
                            Console.WriteLine("enter phonenumber to change");
                            item.Phonenumber = Console.ReadLine();
                            break;
                        case mail:
                            Console.WriteLine("enter mail to change");
                            item.Mail = Console.ReadLine();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

            }
            Console.WriteLine("Wants to edit any other details then press y or else n");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'y' || ch == 'Y')
                EditContact();
            else
                Console.WriteLine("Exited");

        }
    }
}