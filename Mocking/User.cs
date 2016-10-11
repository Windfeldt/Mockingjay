using System;
using System.Collections.Generic;

namespace Mocking
{
    internal enum Rights
    {
        Full,
        None
        
    }
    public class User:ILoginModule
    {
        string password;
        string username;
        object rights;
        public User()
        {
        }

        public string Password
        {
            get{return password;}

            set{password = value;}
        }
        internal object Rights
        {
            get{return rights;}

            set{rights = value;}
        }
        public string UserName
        {
            get{return username;}

            set{username = value;}
        }

        public int NumMessagesCreated { get; internal set; }

        public void Login(User user)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }

        public void ResendPassword(User user)
        {
            throw new NotImplementedException();
        }

        internal string ViewAllEmployees()
        {
            string employeeMessage = "Here is the list";
            return employeeMessage;
        }
    }
}