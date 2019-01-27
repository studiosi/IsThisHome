using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class ElectricMalfunction1Room : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "PUSH" && tokens[1].Item1 == "BUTTON")
                {
                    state.GoToRoom(13);
                    return "What??";
                }             
            }
            return "Can't do that, tell me something else.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I hear a loud snap and stare at the blue sizzle of the broken airlock");
            r.Add("panel. That does not look good. I examine the pair of doors carefully,");
            r.Add("but there seems to be no external damage. The release button emits an");
            r.Add("unassuming red glow. I hesitate. The system might be beyond repair,");
            r.Add("but I need to get out.");
            return r;
        }
    }
}
