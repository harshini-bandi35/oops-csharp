using CopyExample;
using csharp1;
using FactoryPatternExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class program
    {
        /*public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine("The remaining balance after deposit is:" + account.GetBalance());
            account.WithDraw(500);
            Console.WriteLine("The remaining balance after withdraw is:" + account.GetBalance());
            account.WithDraw(600);
            Console.WriteLine("The remaining balance after withdraw is:" + account.GetBalance());
        }

        
            public static void Main(string[] args)
        {
            Student s = new Student();
            s.RollNumber = 123;
            s.Name = "Harshini";
        }
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.DisplayDetails();
            Book book2 = new Book("Amma Dairy lo konni pagelu","Ravi Mantri");
            book2.DisplayDetails();
            Book book3 = new Book("It ends with us", "coolen Hoover","123456789");
            book3.DisplayDetails();
        }
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.CalculateArea(5, 4);
            Circle circle = new Circle();
            circle.CalculateArea(4);

        }
        
        static void Main(string[] args)
            {
                Vehicle bike = new Bike();
                bike.Start();

                Vehicle car = new Car();
                car.Start();
            }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.GetDetails();
            Students student = new Students();
            student.GetDetails();

            Teacher teacher = new Teacher();
            teacher.GetDetails();
        
        public static void Main(String[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("The addition of two numbers is: "+calculator.Add(2, 3));
            Console.WriteLine("The addition of three numbers is: "+calculator.Add(2, 3, 4));
            Console.WriteLine("The addition of float number is: "+calculator.Add(2.5, 3));
        }
        public static void Main(string[] args)
        {
            MusicPlayer musicplayer = new MusicPlayer();
            musicplayer.Play();
            VideoPlayer videoplayer = new VideoPlayer();
            videoplayer.Play();
        }
        static void Main(string[] args)
        {
            Report report = new Report
            {
                Title = "Quarterly Report",
                Content = "This is the content of the quarterly report."
            };

            report.Print();

            string filePath = "report.txt";
            report.SaveToFile(filePath);
        }
        static void Main(string[] args)
        {
            User admin = new Admin("AdminUser");
            User customer = new Customer("CustomerUser");

            admin.AccessControl();
            customer.AccessControl();
        }
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(1, 4);

            ComplexNumber sum = c1 + c2;

            Console.WriteLine($"The sum of {c1} and {c2} is {sum}");
        }
        static void Main(string[] args)
        {
            Manager manager = new Manager("John Doe");
            Department originalDept = new Department { Name = "IT", Manager = manager };

            // Perform shallow copy
            Department shallowCopyDept = originalDept.ShallowCopy();

            // Perform deep copy
            Department deepCopyDept = originalDept.DeepCopy();

            // Display original and copied objects
            Console.WriteLine("Original: " + originalDept);
            Console.WriteLine("Shallow Copy: " + shallowCopyDept);
            Console.WriteLine("Deep Copy: " + deepCopyDept);

            // Modify the manager name in the original department
            originalDept.Manager.Name = "Jane Smith";

            // Display original and copied objects after modification
            Console.WriteLine("\nAfter modifying original manager's name:");
            Console.WriteLine("Original: " + originalDept);
            Console.WriteLine("Shallow Copy: " + shallowCopyDept);
            Console.WriteLine("Deep Copy: " + deepCopyDept);
        }
        static void Main(string[] args)
        {
            Bank.SetInterestRate(3.5);

            Bank bank1 = new Bank("Bank A");
            Bank bank2 = new Bank("Bank B");

            bank1.DisplayInterestRate();
            bank2.DisplayInterestRate();

            Bank.SetInterestRate(4.0);

            bank1.DisplayInterestRate();
            bank2.DisplayInterestRate();
        }
        static void Main(string[] args)
        {
            SecuritySystem securitySystem = new SecuritySystem("Home Security");
            securitySystem.Activate();
        }
        static void Main(string[] args)
        {
            // Create a Button instance
            Button myButton = new Button("Submit");

            // Subscribe to the OnClick event with a method
            myButton.OnClick += MyButton_ClickHandler;

            // Simulate clicking the button
            myButton.Click();
        }

        // Event handler method
        static void MyButton_ClickHandler()
        {
            Console.WriteLine("Button click event triggered!");
        }
        static void Main(string[] args)
        {
            // Create a basic FileLogger instance
            ILogger logger = new FileLogger();

            // Add timestamp decoration
            logger = new TimestampLogger(logger);

            // Add error categorization decoration
            logger = new ErrorCategoryLogger(logger);

            // Log a message
            logger.Log("This is a test log message.");

            // Output will demonstrate the applied decorators
        }

    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a basic FileLogger instance
            ILogger logger = new FileLogger();

            // Add timestamp decoration
            logger = new TimestampLogger(logger);

            // Add error categorization decoration
            logger = new ErrorCategoryLogger(logger);

            // Log a message
            logger.Log("This is a test log message.");

            // Output will demonstrate the applied decorators
        }
        static void Main(string[] args)
        {
            // Access the singleton instance and set a configuration
            ConfigurationManager configManager1 = ConfigurationManager.Instance;
            configManager1.ConfigurationSetting = "NewSetting";

            // Access the singleton instance from another reference
            ConfigurationManager configManager2 = ConfigurationManager.Instance;
            configManager2.DisplayConfiguration();

            // Output will show the same instance is used
        }
        static void Main(string[] args)
        {
            // Create a NotificationSubject instance
            NotificationSubject subject = new NotificationSubject();

            // Create observers
            INotificationObserver emailNotifier = new EmailNotifier();
            INotificationObserver smsNotifier = new SMSNotifier();

            // Register observers
            subject.RegisterObserver(emailNotifier);
            subject.RegisterObserver(smsNotifier);

            // Send a notification
            subject.NotifyObservers("You have a new message!");

            // Unregister an observer
            subject.UnregisterObserver(smsNotifier);

            // Send another notification
            subject.NotifyObservers("Another message arrived!");
        }*/
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            // Adding items to the shopping cart
            cart.AddItem(100);
            cart.AddItem(200);

            Console.WriteLine("Choose a discount strategy: 1. No Discount 2. Percentage Discount 3. Fixed Amount Discount");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
                case 2:
                    Console.WriteLine("Enter the discount percentage:");
                    decimal percentage = decimal.Parse(Console.ReadLine());
                    cart.SetDiscountStrategy(new PercentageDiscount(percentage));
                    break;
                case 3:
                    Console.WriteLine("Enter the discount amount:");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    cart.SetDiscountStrategy(new FixedAmountDiscount(amount));
                    break;
                default:
                    Console.WriteLine("Invalid choice. No discount will be applied.");
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
            }

            // Calculate and display the total amount after applying the discount strategy
            decimal totalAmount = cart.CalculateTotal();
            Console.WriteLine($"Total amount after discount: {totalAmount}");
        }
    }
}


    
    

