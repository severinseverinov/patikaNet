using System.Collections.Generic;
namespace phoneBook
{
    class CManager{
        public void AddContact(List<Contact> contactList)
        {
            Console.WriteLine("New Number");
            Console.WriteLine("Name                          : ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Surname                       : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Phone Number              : ");
            string phone = Console.ReadLine();
            Contact newContact = new Contact(firtName, lastName, phone);
            contactList.Add(newContact);
            Console.WriteLine("Done.");
        }

        public void DeleteContact(List<Contact> contactList)
        {
            Console.WriteLine("Delete a record ");
            Console.WriteLine("Name                          : ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Surname                       : ");
            string lastName = Console.ReadLine();
            int count = 0;
            foreach (var item in contactList)
            {
                if (item.FirstName == firtName || item.LastName == lastName)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(firtName + " " + lastName + " do you want to delete this number ?(y/n)");
                char choose = Convert.ToChar(Console.ReadLine());
                if (choose == 'y')
                {
                    foreach (var item in contactList)
                    {
                        if (item.FirstName == firtName || item.LastName == lastName)
                        {
                            contactList.Remove(item);
                            Console.WriteLine(item.FirstName + " deleted.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Proses of delete finished.");
                }
            }
            else
            {
                Console.WriteLine("The record did not found.");
                Console.WriteLine("* Stop the delete : (1)");
                Console.WriteLine("* Try again : (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 2)
                {
                    DeleteContact(contactList);
                }
                else
                {
                    Console.WriteLine("Proses of delete finished.");
                }

            }
        }

        public void UpdateContact(List<Contact> contactList)
        {
            Console.WriteLine("Update a record");
            Console.WriteLine("Name                          : ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Surname                       : ");
            string lastName = Console.ReadLine();
            int count = 0;
            foreach (var item in contactList)
            {
                if (item.FirstName == firtName || item.LastName == lastName)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine(firtName + " " + lastName + " do you want to update this number ?(y/n)");
                char choose = Convert.ToChar(Console.ReadLine());
                if (choose == 'y')
                {
                    foreach (var item in contactList)
                    {
                        if (item.FirstName == firtName || item.LastName == lastName)
                        {
                            Console.WriteLine("Enter a new phone number ");
                            string phone = Console.ReadLine();
                            item.Phone = phone;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Proses of update finished.");
                }
            }
            else
            {
                Console.WriteLine("The record did not found.");
                Console.WriteLine("* Stop the update : (1)");
                Console.WriteLine("* Try again : (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 2)
                {
                    UpdateContact(contactList);
                }
                else
                {
                    Console.WriteLine("Proses of update finished.");
                }

            }
        }

        public void ViewContact(List<Contact> contactList)
        {
            Console.WriteLine("Phone Book");
            Console.WriteLine("*****************************************");
            foreach (var item in contactList)
            {
                Console.WriteLine("Name: " + item.FirstName);
                Console.WriteLine("Surname: " + item.LastName);
                Console.WriteLine("Phone Number: " + item.Phone);
                Console.WriteLine("-");
            }
        }

        public void SearchContact(List<Contact> contactList)
        {
            Console.WriteLine("How do you want to search the record?");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Name and surname: (1)");
            Console.WriteLine("Phone number: (2)");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Name                          : ");
                string firtName = Console.ReadLine();
                Console.WriteLine("Surname                       : ");
                string lastName = Console.ReadLine();
                foreach (var item in contactList)
                {
                    if (item.FirstName == firtName || item.LastName == lastName)
                    {
                        Console.WriteLine("Name: " + item.FirstName);
                        Console.WriteLine("Surname: " + item.LastName);
                        Console.WriteLine("Phone Number: " + item.Phone);
                        Console.WriteLine("-");
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter the phone number: ");
                string phone = Console.ReadLine();
                foreach (var item in contactList)
                {
                    if (item.Phone == phone)
                    {
                        Console.WriteLine("Name: " + item.FirstName);
                        Console.WriteLine("Surname: " + item.LastName);
                        Console.WriteLine("Phone Number: " + item.Phone);
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
}