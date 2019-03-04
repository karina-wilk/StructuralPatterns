using ProxyPattern.Wrapped;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Proxy
{
    public class SecretDataServiceProxy: ISecretDataService
    {
        SecretDataService realService;
        string login;
        string password;
        static int numberOfAddCall;

        public SecretDataServiceProxy(string login, string password)
        {
            this.login = login;
            this.password = password;
            numberOfAddCall = 0;
        }

        public bool AddSecretKey(string key)
        {
            Console.WriteLine($"This method call counter:\t{numberOfAddCall}");
            numberOfAddCall++;
            if (CheckAccess())
            {
                realService = new SecretDataService();
                return realService.AddSecretKey(key);
            }
            return false;
        }

        public string GetSecretKey()
        {
            if (CheckAccess())
            {
                realService = new SecretDataService();
                return realService.GetSecretKey();
            }
            throw new MethodAccessException();
        }

        //Metody pomocnicze:
        private bool CheckAccess()
            => login == password && password == "admin";
    }
}
