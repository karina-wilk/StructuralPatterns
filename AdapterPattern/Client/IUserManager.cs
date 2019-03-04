using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Client
{
    public interface IUserManager
    {
        List<User> GetUsersByLastName(string lastName);
        //...
    }
}
