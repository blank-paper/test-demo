using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Presentation
{
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
