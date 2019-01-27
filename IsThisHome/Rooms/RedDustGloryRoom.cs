using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class RedDustGloryRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "STAY")
                {
                    state.GameCompleted = true;
                    return "We should stay here. [ THE END ]";
                }
                if (tokens[0].Item1 == "LEAVE")
                {
                    state.GameCompleted = true;
                    return "This is not a place to stay. [ THE END ]";
                }
            }
            return "Not my thing...";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I still have the rock in my possession when I continue my exploration.");
            r.Add("I feel the weight of it in one of my pockets. It keeps me grounded and");
            r.Add("I keep thinking of home, wherever that might be, whatever that may");
            r.Add("mean. Suddenly my radiophone chimes. A voice echoes inside my");
            r.Add("helmet. \"Yes?\" I say. \"So? Have you made up your mind yet?\" I hear");
            r.Add("General's distant voice. Her words are more like a statement than a");
            r.Add("question, but my opinion weights. The martian winds push sand");
            r.Add("around in the wasteland before me. The sun is setting and I can");
            r.Add("already feel a chilling change in the air. Is this the home for humanity?");
            r.Add("Should we stay or leave?");
            return r;
        }
    }
}
