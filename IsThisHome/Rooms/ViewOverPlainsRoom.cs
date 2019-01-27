using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class ViewOverPlainsRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "STAY")
                {
                    state.GameCompleted = true;
                    return "We should stay, this place can be a home for us, I say. [ THE END ]";
                }
                else if (tokens[0].Item1 == "LEAVE")
                {
                    state.GameCompleted = true;
                    return "I don’t think this is the place we’re looking for. [ THE END ]";
                }
            }
            return "Stop it, tell me something I can do";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I grab the ice and melt the rest of it to my suits build-in canister. Mars");
            r.Add("has water, or at least ice that can be cultivated to the liquid stage. It's");
            r.Add("the basis of life. But is it enough? Can we change this hostile planet");
            r.Add("enough to ever call it a home? Suddenly the radiophone rings. A voice");
            r.Add("echoes inside my helmet. \"Yes?\" I say. \"So? Have you made up your");
            r.Add("mind yet?\" General asks. The martian winds push sand around in the");
            r.Add("wasteland before me. The sun is setting and I can already feel a");
            r.Add("chilling change in the air. Is this the home for humanity? Should we");
            r.Add("stay or leave?");
            return r;
        }
    }
}
