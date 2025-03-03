/* **Use of Delegates for Event Handling**

Create a `Button` class that has a delegate `OnClick`.
Implement an event that triggers when the button is clicked.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public delegate void ClickHandler();
    public class Button
    {
        public event ClickHandler OnClick;

        public string ButtonText { get; set; }

        public Button(string buttonText)
        {
            ButtonText = buttonText;
        }

        // Method to simulate clicking the button
        public void Click()
        {
            Console.WriteLine($"{ButtonText} button clicked!");
            // Trigger the event if there are any subscribers
            OnClick?.Invoke();
        }
    }
}
