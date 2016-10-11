using System;

namespace Mocking
{
    public enum Rights
    {
        Full,
        None,
    }
    public class User
    {
        public User()
        {
        }

        public int NumMessagesCreated { get; internal set; }
        public string Password { get; set; }
        public object Rights { get; internal set; }
        public string UserName { get; set; }

        internal string ViewAllEmployees()
        {
            string result = "Here is the list";
            return result;
        }
    }
}