using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAssignment
{
    public class DeleteContact
    {
        public static List<Conatatct> person = new List<Conatatct>();
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
