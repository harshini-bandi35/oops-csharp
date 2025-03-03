/***Shallow Copy vs. Deep Copy**

Create a `Department` class with a reference-type property 
`Manager`. Implement both **Shallow Copy** and **Deep Copy** 
to show how references are handled.*/
using System;

namespace CopyExample
{
    public class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    public class Department
    {
        public string Name { get; set; }
        public Manager Manager { get; set; }

        // Shallow copy method
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep copy method
        public Department DeepCopy()
        {
            Department copy = (Department)this.MemberwiseClone();
            copy.Manager = new Manager(this.Manager.Name);
            return copy;
        }

        public override string ToString()
        {
            return $"Department: {Name}, Manager: {Manager.Name}";
        }
    }
}
