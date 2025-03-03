/***Thread-Safe Singleton Pattern for Configuration Management**

Implement a Singleton class `ConfigurationManager`
that prevents multiple instances. Ensure it is thread-safe.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation from outside
        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                // Double-check locking mechanism
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ConfigurationManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // Example configuration property
        public string ConfigurationSetting { get; set; } = "DefaultSetting";

        public void DisplayConfiguration()
        {
            Console.WriteLine($"Configuration Setting: {ConfigurationSetting}");
        }
    }
}

