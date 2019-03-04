using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Wrapped
{
    public class SecretDataService
    {
        public string GetSecretKey()
        {
            //jakaś logika.
            return Guid.NewGuid().ToString();
        }

        public bool AddSecretKey(string key)
        {
            //jakaś logika.
            return true;
        }
    }
}
