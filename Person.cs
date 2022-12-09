﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookAssignment
{
    public class Person
    {
        public static List<Conatatct> person = new List<Conatatct>();
        public static void CreateContact()
        {
            Conatatct conatatct = new Conatatct();

            Console.WriteLine("Enter first name");
            conatatct.FName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            conatatct.LName = Console.ReadLine();

            Console.WriteLine("Enter address");
            conatatct.Addresss = Console.ReadLine();

            Console.WriteLine("Enter city");
            conatatct.City = Console.ReadLine();

            Console.WriteLine("Enter state");
            conatatct.State = Console.ReadLine();

            Console.WriteLine("Enter Zipcode");
           conatatct.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phonenumber");
            conatatct.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email");

            conatatct.Email = Console.ReadLine();

           person.Add(conatatct);


        }
        public static void editContact()
        {
            
            Console.WriteLine("Enter the first name");
            string name = Console.ReadLine();

            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.FName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string FName = Console.ReadLine();
                                data.FName = FName;
                                break;
                            case 2:
                                string LName = Console.ReadLine();
                                data.LName = LName;
                                break;
                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter correct name");
                    }
                }
            }
        }
        public static void deleteContact()
        {
            Console.WriteLine("Enter the first name");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (data.FName == name)
                {
                    person.Remove(data);

                    Console.WriteLine("\nContact delete Successfully");
                }
            }
        }

    }
}
