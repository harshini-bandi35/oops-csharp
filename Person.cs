using System;

namespace csharp2
{
    class Person
    {
        protected string name, age;

        public virtual void GetDetails()
        {
            Console.WriteLine("Enter the name of the person:");
            name = Console.ReadLine();
            Console.WriteLine("The name of the person is: " + name);
            Console.WriteLine("Enter the age of the person:");
            age = Console.ReadLine();
            Console.WriteLine("The age of the person is: " + age);

        }
    }

    class Students : Person
    {
        string rollNumber;

        public override void GetDetails()
        {
            Console.WriteLine("Enter the roll number of the student:");
            rollNumber = Console.ReadLine();
            Console.WriteLine("The roll number of the student is: " + rollNumber);
        }
    }

    class Teacher : Person
    {
        string subject;

        public override void GetDetails()
        {
            Console.WriteLine("Enter the name of the subject:");
            subject = Console.ReadLine();
            Console.WriteLine("The subject of the teacher is: " + subject);
        }
    }

}
