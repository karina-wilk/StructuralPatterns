using AdapterPattern.Adaptee.Facebook;
using AdapterPattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapters
{
    public class FacebookAPIAdapter : IUserManager
    {
        private FacebookAPI fbApi;

        public FacebookAPIAdapter()
        {
            fbApi = new FacebookAPI();
        }

        public List<User> GetUsersByLastName(string lastName)
        {
            List<User> result = new List<User>();
            var fbUsers = fbApi.GetAccounts(lastName, 100000);
            if(fbUsers != null)
            {
                int i = 1;
                foreach(var fbUser in fbUsers)
                {
                    result.Add(new User
                    {
                        FullName = fbUser.FirstName + " " + fbUser.LastName,
                        Id = i++
                    });
                }
            }
            return result;
        }
    }
}
