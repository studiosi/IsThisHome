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

            }
            else if(tokens.Count == 3)
            {

            }
            return "We can't go that way.";
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
