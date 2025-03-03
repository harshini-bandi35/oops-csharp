using System;

namespace DecoratorPatternExample
{
    // Define the ILogger interface
    public interface ILogger
    {
        void Log(string message);
    }

    // Implement the FileLogger class
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // Simulate writing to a file
            Console.WriteLine($"FileLogger: {message}");
        }
    }

    // Implement the base LoggerDecorator class
    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void Log(string message)
        {
            _logger.Log(message);
        }
    }

    // Implement the TimestampLogger decorator
    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestampedMessage = $"{DateTime.Now}: {message}";
            _logger.Log(timestampedMessage);
        }
    }

    // Implement the ErrorCategoryLogger decorator
    public class ErrorCategoryLogger : LoggerDecorator
    {
        public ErrorCategoryLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string errorMessage = $"[Error]: {message}";
            _logger.Log(errorMessage);
        }
    }

    /*class Program
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
    }*/
}
