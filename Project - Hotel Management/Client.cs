using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Hotel_Management
{
    class Client
    {
        //this is a shortcut to all setters and getters
        public int NationalID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Mobile { set; get; }
        public string Email { set; get; }

        //creating a constructor 
        public Client(int id, string fname, string lname, int mobile, string email)
        {
            NationalID = id;
            if (NationalID < 0)
                NationalID = 0;

            FirstName = fname;
            LastName = lname;
            
            Mobile = mobile;
            if (Mobile < 0)
                Mobile = 0;

            Email = email;
        }
    }
}
