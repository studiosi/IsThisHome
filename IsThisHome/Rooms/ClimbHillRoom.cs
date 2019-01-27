using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class ClimbHillRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if(tokens.Count == 2) { 
                if (tokens[0].Item1 == "CLIMB" && tokens[1].Item1 == "RIGHT")
                {
                    if (state.Objects.CheckItem(Item.WATER, 1))
                    {
                        state.GoToRoom(22);
                    }
                    else
                    {
                        state.GoToRoom(20);
                    }
                    return "I almost slip on the icy surface";
                }
                else if (tokens[0].Item1 == "CLIMB" && tokens[1].Item1 == "LEFT")
                {
                    state.GoToRoom(20);
                    return "It looks like I made a good choice";
                }
                else if (tokens[0].Item1 == "CLIMB" && tokens[1].Item1 == "UP")
                {
                    state.GoToRoom(22);
                    return "Out of a sudden a gust of wind tackles and I fall.";
                }
            }
            return "No... again?";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I continue walking towards a high hill. Soon I stand at the feet of the a");
            r.Add("cliff. I need to climb to the top in order to get an idea of the landscape.");
            r.Add("I see three possible routes. I could just climb up, but the cliff looks");
            r.Add("steep. I could climb the left side of the hill, but there's loose gravel");
            r.Add("there, or I could go around from right, but I think I see a dangerous");
            r.Add("glimmer of dust-speckled ice. A tough choice.");
            return r;
        }
    }
}
