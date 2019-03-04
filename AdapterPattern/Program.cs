using AdapterPattern.Adaptee;
using AdapterPattern.Adapters;
using AdapterPattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserManager userManager = new FacebookAPIAdapter();

            foreach(var user in userManager.GetUsersByLastName("Kowalski"))
            {
                Console.WriteLine($"{user.Id}) {user.FullName}");
            }
          
            Console.Read();
        }
    }
}
;