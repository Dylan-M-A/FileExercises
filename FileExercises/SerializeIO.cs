using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExercises
{
    struct Contact
    {
        public string name;
        public string email;
        public int id;

        public Contact(string name, string email, int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;
        }
        public void Print()
        {
            Console.WriteLine(name + " | " + email + " | " + id);
        }
    }
    internal class SerializeIO
    {
        public void Run()
        {
            Contact bob = new Contact("Bob", "bob@email.com", 1234);
            Contact fred = new Contact("Fred", "fred@email.com", 2345);
            Contact jane = new Contact("Jane", "jane@email.com", 3456);

            //write each contact to a file
            bob.Serialize(@"contacts\bob.txt");
            fred.Serialize(@"contacts\fred.txt");
            jane.Serialize(@"contacts\jane.txt");

            //clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane = new Contact();

            //load contacts from file
            bob.DeSerialize(@"contacts\bob.txt");
            fred.DeSerialize(@"contacts\fred.txt");
            jane.DeSerialize(@"contacts\jane.txt");

            //print contacts
            bob.Print();
            fred.Print();
            jane.Print();
        }
    }
}
