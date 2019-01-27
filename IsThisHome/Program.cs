using System;
using System.Collections.Generic;

namespace IsThisHome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console Initialization
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleUtils.SetConsoleFont();
            ConsoleUtils.RemoveResizeItems();           
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            // Game loop
            GameState state = new GameState();     
            PaintUtils.PrintScreen(state.CurrentRoom);
            string command = "";
            while(command != "QUIT") {
                PaintUtils.PrintScreen(state.CurrentRoom);
                command = PaintUtils.GetInput().ToUpper();
                List<Tuple<string, TokenType>> tokens = Parser.TokenizeAndParse(command);
                PaintUtils.PrintScreen(state.CurrentRoom);
                bool executeCommand = true;
                if(command == "QUIT")
                {
                    break;
                }
                if(command == "SHOW INVENTORY")
                {
                    PaintUtils.DeleteText();
                    PaintUtils.PrintNonRoomText(state.Objects.GetText());
                    PaintUtils.GetInput();
                    PaintUtils.DeleteText();
                    executeCommand = false;
                }
                if(command == "SHOW VERBS" || command.ToUpper() == "HELP")
                {
                    PaintUtils.DeleteText();
                    PaintUtils.PrintNonRoomText(Token.GetVerbsText());
                    PaintUtils.GetInput();
                    PaintUtils.DeleteText();
                    executeCommand = false;
                }
                else {
                    if(executeCommand) { 
                        if (!Parser.IsValidStructure(tokens))
                        {
                            PaintUtils.PrintResult("I can't understand you");
                        }
                        else
                        {
                            PaintUtils.PrintResult(command);
                        }
                    }
                }
            }      
        }
    }
}
