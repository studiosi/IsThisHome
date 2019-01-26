using System;
using System.Collections.Generic;

namespace IsThisHome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Initialization 
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleUtils.SetConsoleFont();
            ConsoleUtils.RemoveResizeItems();           
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            // Game loop            
        }
    }
}
