using System;

namespace csharp2
{
    class Student
    {
        private int rollnumber;
        private string name;

        public int RollNumber
        {
            get { return rollnumber; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The rollnumber cannot be negative, please enter a correct rollnumber");
                }
                else
                {
                    rollnumber = value;
                    Console.WriteLine("The student rollnumber is: " + rollnumber);
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("The name of the student cannot be empty");
                }
                else
                {
                    name = value;
                    Console.WriteLine("The name of the student is: " + name);
                }
            }
        }
    }
}