using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Wrapped
{
    public interface ISecretDataService
    {
        string GetSecretKey();
        bool AddSecretKey(string key);
    }
}
