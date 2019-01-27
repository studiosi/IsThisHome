using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class SuitRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if(tokens.Count == 1)
            {
                if(tokens[0].Item1 == "GO")
                {
                    state.GoToRoom(2);
                    return "Moving! Yes!";
                }
            }
            else if(tokens.Count == 2)
            {
                if (tokens[0].Item1 == "USE" && tokens[1].Item1 == "PANEL")
                {
                    return "Welcome to Mars, -80F outside. Go out and explore. r.Add(sb.ToString());";
                }
            }
            else if(tokens.Count == 3)
            {
                if (tokens[0].Item1 == "PUT" && tokens[1].Item1 == "ON" && tokens[2].Item1 == "SPACESUIT")
                {
                    state.Objects.AddItem(Item.SPACESUIT, 1);
                    return "I put it on. It's state-of-the-art. It has modules for small equipment.";
                }
                else if (tokens[0].Item1 == "LOOK" && tokens[1].Item1 == "AT" && tokens[2].Item1 == "PICTURE")
                {
                    return "This is Jonesy, the dog that I left behind on Earth. I feel pain.";
                }
            }
            return "No... I can't do that";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I wake up and my mouth feels like sandpaper. My bones remember the");
            r.Add("tremble of the landing. The ship is tiny, meant for a single person. It's a");
            r.Add("scout ship for the rest of the fleet and I'm the scout. My name is Nika and");
            r.Add("I'm looking for a terraformable home. I can reach everything in the cabin");
            r.Add("from the point I'm sitting at. There's a control panel on the left and next");
            r.Add("to the panel hangs a picture of Jonesy, my only family left on Tellus. On");
            r.Add("the right side there's a spacesuit I can use to go planetside.");
            return r;
        }
    }
}
