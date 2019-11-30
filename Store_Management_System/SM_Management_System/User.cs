using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_Management_System
{[Serializable]
    class User
    {
        private string name, username, email, password;


        public string getname()
        {
            return name;
        }
        public void setname(string n)
        {
            name = n;
        }
        public string getusername()
        {
            return name;
        }
        public void setusername(string uname)
        {
            username = uname;
        }
        public string getemail()
        {
            return email;
        }
        public void setemail(string mail)
        {
            email = mail;
        }
        public string getpassword()
        {
            return password;
        }
        public void setpassword(string pass)
        {
            password = pass;
        }
    }
}
