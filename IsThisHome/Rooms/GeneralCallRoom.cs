using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class GeneralCallRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "BEAM" && tokens[1].Item1 == "UP")
                {
                    state.GoToRoom(22);
                    state.IsAlive = false;
                    return "You suddenly feel a strong pain going through your body";
                }
                else if (tokens[0].Item1 == "SCAN" && tokens[1].Item1 == "SOIL")
                {
                    state.GoToRoom(10);
                    return "General starts to talk...";
                }
            }
            return "I can't do that";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I hear the sweet buzz of the long-distance call. General sounds");
            r.Add("worried. \"Doctor Nika, are you alright?\" My helmet's visor presents");
            r.Add("me with data that tells me I'm intact. I see a promising red hill ahead.");
            r.Add("An ideal place to collect soil samples… I could ask General to scan");
            r.Add("the place for me, now that the ship is in ruins.  Suddenly I hear");
            r.Add("something exploding behind me. A shrapnel flies past. I come to");
            r.Add("think that perhaps General could just beam me up.");
            return r;
        }
    }
}
