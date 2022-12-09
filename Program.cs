namespace AddressBookAssignment
{
    class program
    {
       //  public static  List<Conatatct> person = new List<Conatatct>();
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program");

             AddressBookAssignment.Person.CreateContact();

           // Person.editContact();
            Person.deleteContact();
            
        }
    }
}
