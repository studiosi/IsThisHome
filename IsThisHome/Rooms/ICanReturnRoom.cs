using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class ICanReturnRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "STAY")
                {
                    return "I am waiting...";
                }
                else if (tokens[0].Item1 == "WALK")
                {
                    state.GoToRoom(18);
                    return "Moving!";
                }
            }
            return "Not now.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();

            r.Add("I put aside my tools and push the button. The airlock doors swing");
            r.Add("open. I let out a small sigh of relief and feel the heavy weight of the");
            r.Add("suit on me, now that the dread of staying behind the locked doors is");
            r.Add("gone. In my mind I thank my annoying electrical instructor. I hated");
            r.Add("her so much for pestering me with stupid tasks with colourful electric");
            r.Add("cords, but it was good for something. I see a path before me, path that");
            r.Add("has never been walked.");

            return r;
        }
    }
}
