/***Sealed Class in a Security System**

Create a sealed class `SecuritySystem` that prevents inheritance. 
Show how sealing a class stops further extension.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public sealed class SecuritySystem
    {
        public string SystemName { get; set; }

        public SecuritySystem(string systemName)
        {
            SystemName = systemName;
        }

        public void Activate()
        {
            Console.WriteLine($"{SystemName} activated.");
        }
    }
}
