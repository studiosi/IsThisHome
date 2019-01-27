using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class PositiveSampleRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "EXAMINE" && tokens[1].Item1 == "SOIL")
                {
                    state.Objects.AddItem(Item.SOIL, 1);
                    state.GoToRoom(15);
                    return "I  scan the sample and it looks okayish.";
                }
                else if (tokens[0].Item1 == "EXAMINE" && tokens[1].Item1 == "MOUND")
                {
                    state.Objects.AddItem(Item.MOUND, 1);
                    state.GoToRoom(15);
                    return "I can't believe my eyes as the scanner flashes a green light.";
                }
            }
            return "I can't do it";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("As I step out of the ship, I see the vast red Martian plain. It looks");
            r.Add("hostile and endless, but I have an job to do. I've come to find out if");
            r.Add("this landscape is terraformable for human needs. I notice a loose patch");
            r.Add("of soil nearby and further away a promising mound. I must examine.");
            return r;
        }
    }
}
