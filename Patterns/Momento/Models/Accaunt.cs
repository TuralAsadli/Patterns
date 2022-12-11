using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Momento.Models
{
    internal class Accaunt
    {

        User orginal_user;
        Momento storage;

        public Accaunt(string name, string password)
        {
            orginal_user = new User(name, password);
            storage = new Momento();
        }
        public void ChangeAll(string name, string password)
        {
            storage.Add(orginal_user);
            orginal_user = new(name, password);
        }

        public void ChangeName(string name)
        {
            storage.Add(orginal_user);
            orginal_user = new User(name, orginal_user.Password);
            
        }

        public void ChangePassword(string password)
        {
            storage.Add(orginal_user);
            orginal_user = new User(orginal_user.Name, password);
            
        }

        public void SetOldValue()
        {
            User user = storage.Backup();
            orginal_user.Name = user.Name;
            orginal_user.Password = user.Password;
        }

        public void ShowInfo()
        {
            Console.WriteLine(orginal_user.Name + " " + orginal_user.Password);
        }

        private class Momento
        {
            Stack<User> stack;
            public Momento()
            {
                stack = new Stack<User>();
            }

            public void Add(User user)
            {
                stack.Push(user);
            }

            public User Backup() => stack.Pop();
        }
    }
}
