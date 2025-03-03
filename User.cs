/***Design a Role-Based Access System**

Create a base class `User` with properties like
`Username` and `Role`. Derive `Admin` and `Customer`
classes that override a method `AccessControl()`, where
`Admin` can access all features, but `Customer` has limited access.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        public virtual void AccessControl()
        {
            Console.WriteLine($"{Username} with role {Role} has limited access.");
        }
    }

    public class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} with role {Role} has access to all features.");
        }
    }

    public class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        public override void AccessControl()
        {
            Console.WriteLine($"{Username} with role {Role} has limited access.");
        }
    }
}

