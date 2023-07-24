using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.Examples.BaseExample
{
    internal class User
    {
        private readonly string username;

        public User(string username)
        {
            this.username = username;
        }
        public string GetInfo()
        {
            return "This is user";
        }

        public static explicit operator User(string text)
        {
            return new User(text);
        }

        public static implicit operator string(User user)
        {
            return user.username;
        }

    }
}
