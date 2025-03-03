/***Encapsulation Challenge**
Create a `BankAccount` class where `balance` is a private field.
Implement methods for `Deposit()` and `Withdraw()`, ensuring that 
withdrawal is only allowed if there is a sufficient balance. Prevent
direct modification of `balance` from outside the class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp1
{
    class BankAccount
    {
        private int balance;
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("The accound balance is:" + balance);
            }
            else
            {
                Console.WriteLine("please enter a positive value amount");
            }
        }
        public void WithDraw(int amount)
        {
            if (amount > 0)
            {
                if (balance > amount)
                {
                    balance -= amount;
                    Console.WriteLine("The remaining balance is: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient balance in the account");
                }
            }
            else
            {
                Console.WriteLine("withdrawl ammount must be positive");
            }

        }
        public int GetBalance()
        {
            return balance;
        }
    }
}