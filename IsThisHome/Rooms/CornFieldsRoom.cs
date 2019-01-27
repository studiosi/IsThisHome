using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class CornFieldsRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "TAKE" && tokens[1].Item1 == "STARROCK")
                {
                    state.Objects.AddItem(Item.STARROCK, 1);
                    state.GoToRoom(7);
                    return "Everything is out of place here. I don't belong here.";
                }
                if (tokens[0].Item1 == "TAKE" && tokens[1].Item1 == "SQUAREROCK")
                {
                    state.Objects.AddItem(Item.SQUAREROCK, 1);
                    state.GoToRoom(7);
                    return "The rock feels heavy in my hand like the fate of Tellus.";
                }
            }
            return "No, I can't do that";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I keep walking, I keep looking. The scenery stays the same.");
            r.Add("Everything around me is tinted in red and orange. I keep seeing a");
            r.Add("shimmering light that shines and flashes to my visor. I need to raise");
            r.Add("my glove to shade my eyes from the light. I feel something hard under");
            r.Add("my step and see two rocks that don't look like they belong here. A");
            r.Add("starrock that looks like it fell from the vast night-sky. And a");
            r.Add("squarerock that looks like it was thrown out from a pile of bricks.");
            return r;
        }
    }
}
