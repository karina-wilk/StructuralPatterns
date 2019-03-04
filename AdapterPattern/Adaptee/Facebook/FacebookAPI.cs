using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee.Facebook
{
    public class FacebookAPI
    {
        #region Mock
        private static List<FacebookUser> usersMock = new List<FacebookUser>
        {
            new FacebookUser(new Guid(), "Jan", "Kowalski"),
            new FacebookUser(new Guid(), "Jan", "Nowak"),
            new FacebookUser(new Guid(), "Adam", "Kowalski"),
            new FacebookUser(new Guid(), "Agnieszka", "Kowalski"),
            new FacebookUser(new Guid(), "Anna", "Gates"),
            new FacebookUser(new Guid(), "Jan", "Hajzer")
        }; 
        #endregion

        public List<FacebookUser> GetAccounts(string lastName, int maxCount)
        {
            return usersMock.Where(c => c.LastName == lastName)
                .Take(maxCount)
                .ToList();
        }

    }
}
