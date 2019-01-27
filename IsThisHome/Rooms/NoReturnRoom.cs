using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class NoReturnRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "GO")
                {
                    state.GoToRoom(4);
                    return "My family is still on Earth...";
                }
            }
            else if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "CALL" && tokens[1].Item1 == "GENERAL")
                {
                    state.GoToRoom(8);
                    return "Calling to the general, waiting for connection...";
                }
            }
            return "I can't do that";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("The flaming wreck of the shapeship crackles and pops behind me.");
            r.Add("That ship won't fly ever again. I think of what General told me just");
            r.Add("before departed. \"Nika, you're not alone.\" It might be a good idea to");
            r.Add("let the fleet above to know what happened. On the other hand, I");
            r.Add("haven't even started my mission yet.");
            return r;
        }
    }
}
