using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee.Facebook
{
    public class FacebookUser
    {
        public Guid ID { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FacebookUser(Guid id, string fName, string lName)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
            BirthDate = DateTime.Now.AddMonths(-new Random().Next(200));
        }
    }
}
