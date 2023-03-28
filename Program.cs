using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36ThredingConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Repo ! ");


            AddressBookRepo repo = new AddressBookRepo();

            AddressBookModel addressBookModel = new AddressBookModel();

            repo.GetAddressBook();
        }
    }
}
