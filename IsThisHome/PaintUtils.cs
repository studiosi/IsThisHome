using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome
{
    class PaintUtils
    {
        private static void PrintBorder()
        {
            StringBuilder star = new StringBuilder().Append("*");
            short[] fullY = { 0, 21, 24 };
            foreach(short y in fullY) { 
                for(short x = 0; x < 80; x++)
                {
                    ConsoleUtils.ConsoleWriteNoCursor(x, y, star);
                }
            }
            for (short y = 0; y < 25; y++)
            {
                ConsoleUtils.ConsoleWriteNoCursor(0, y, star);
                ConsoleUtils.ConsoleWriteNoCursor(79, y, star);
            }

        }
        public static void DeleteText()
        {
            for(short y = 1; y < 21; y++) {
                DeleteLine(y);
            }
        }
        public static void PrintText(IRoom room)
        {
            List<string> lines = room.GetText();
            PrintNonRoomText(lines);
        }
        public static void PrintNonRoomText(List<string> lines)
        {
            short y = 2;
            foreach (string line in lines)
            {
                ConsoleUtils.ConsoleWriteNoCursor(2, y, new StringBuilder(line));
                y++;
            }
        }
        public static void PrintScreen(IRoom room)
        {
            PrintBorder();
            PrintText(room);
        }

        public static void DeleteLine(short y)
        {
            for (short x = 1; x < 79; x++)
            {
                ConsoleUtils.ConsoleWriteNoCursor(x, y, new StringBuilder(" "));
            }
        }

        public static string GetInput()
        {
            DeleteLine(22);
            Console.SetCursorPosition(2, 22);
            Console.Write("> ");
            return Console.ReadLine();
        }

        public static void PrintResult(string result)
        {
            DeleteLine(23);
            ConsoleUtils.ConsoleWriteNoCursor(2, 23, new StringBuilder(result));
        }

    }
}
