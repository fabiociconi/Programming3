using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetFlixFabioCiconi.Models
{
    public class User
    {
        private string user;

        public string GetUser()
        {
            return user;
        }

        public void SetUser(string value)
        {
            user = value;
        }

        private string passoword;

        public string GetPassoword()
        {
            return passoword;
        }

        public void SetPassoword(string value)
        {
            passoword = value;
        }
    }
}
