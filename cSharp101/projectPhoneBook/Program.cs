using System.Collections.Generic;
namespace phoneBook
{
    class Program{
        static void Main(string[]args){
            List<Contact> contactList = new List<Contact>();
            CManager contactManager = new CManager();
            contactList.Add(new Contact("Sevgin", "SERBEST", "11111"));
            contactList.Add(new Contact("Elif", "SERBEST", "22222"));
            contactList.Add(new Contact("Cihangir", "SERBEST", "33333"));
            contactList.Add(new Contact("Nil Nisa", "Yılmaz", "44444"));

            int number = 0;
            while(number != 6)
            {
                Console.WriteLine("Select a number: ");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) New number");
                Console.WriteLine("(2) Delete a number");
                Console.WriteLine("(3) Update a number");
                Console.WriteLine("(4) Delete all numbers");
                Console.WriteLine("(5) Search a member");
                Console.WriteLine("(6) Exit");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        contactManager.AddContact(contactList);
                        break;
                    case 2:
                        contactManager.DeleteContact(contactList);
                        break;
                    case 3:
                        contactManager.UpdateContact(contactList);
                        break;
                    case 4:
                        contactManager.ViewContact(contactList);
                        break;
                    case 5:
                        contactManager.SearchContact(contactList);
                        break;
                    case 6:
                        Console.WriteLine("Program closed!");
                        break;
                }
            }
        }
    }
}
