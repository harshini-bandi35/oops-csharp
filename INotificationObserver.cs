/***Real-World Observer Pattern for Notifications**

Implement an `INotificationObserver` interface where
`EmailNotifier` and `SMSNotifier` listen for notifications. 
When a new message arrives, all observers should receive an update.*/

using System;
using System.Collections.Generic;

// Define the INotificationObserver interface
public interface INotificationObserver
{
    void Update(string message);
}

// Implement the EmailNotifier class
public class EmailNotifier : INotificationObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Email notification: {message}");
    }
}

// Implement the SMSNotifier class
public class SMSNotifier : INotificationObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"SMS notification: {message}");
    }
}

// Define the NotificationSubject class that maintains a list of observers
public class NotificationSubject
{
    private List<INotificationObserver> observers = new List<INotificationObserver>();

    public void RegisterObserver(INotificationObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(INotificationObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (INotificationObserver observer in observers)
        {
            observer.Update(message);
        }
    }
}