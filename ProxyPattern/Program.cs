using ProxyPattern.Proxy;
using ProxyPattern.Wrapped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login!");
            var login = Console.ReadLine();
            Console.WriteLine("Enter key!");
            var password = Console.ReadLine();

            ISecretDataService proxy = new SecretDataServiceProxy(login, password);
            var secretKey = proxy.GetSecretKey();
            Console.WriteLine($"Secret key: {secretKey}");

            var addingKeySuccess = proxy.AddSecretKey("Ala ma kota");
            if (addingKeySuccess)
            {
                Console.WriteLine("Secret key added to secret database");
            }

            addingKeySuccess = proxy.AddSecretKey("Ola ma psa");
            if (addingKeySuccess)
            {
                Console.WriteLine("Secret key added to secret database");
            }

            Console.Read();
        }

    }
}
