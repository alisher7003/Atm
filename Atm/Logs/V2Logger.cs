using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class V2Logger : ILogger
    {
        public void LogInformation(string message) 
        {            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
        }
    }
}
