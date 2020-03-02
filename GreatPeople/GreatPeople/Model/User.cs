using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatPeople.Model
{
    class User
    {
        public int IDUser { get; set; }
        public string NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }

        public User(int idUser, string nickName, string login, string password, int accessLevel)
        {
            IDUser = idUser;
            NickName = nickName;
            Login = login;
            Password = password;
            AccessLevel = accessLevel;
        }

        public User()
        {
        }
    }
}
