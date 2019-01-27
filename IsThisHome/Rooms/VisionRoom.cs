using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class VisionRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "GO")
                {
                    state.GoToRoom(6);
                    return "Need to move fast!";
                }
            }
            if (tokens.Count == 3)
            {
                if (tokens[0].Item1 == "LOOK" && tokens[1].Item1 == "AT" && tokens[2].Item1 == "SAND")
                {
                    state.GameCompleted = true;
                    return "I'll dig a hole here and leave my fate to the winds of Mars. [ THE END ]";
                }
            }
            return "No, no, no!";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I remember how we ran through the corn fields");
            r.Add("together, and how you hated the hot sun on the summer");
            r.Add("months. After that summer everything we loved changed.");
            r.Add("");
            r.Add("The wisp of sand starts a playful dance. It blends to the copper");
            r.Add("horizon. The outlines of the dust clouds resemble a herd of sheep");
            r.Add("running through the field of dust and rocks. And something faster and");
            r.Add("slightly slimmer is chasing them. Jonesy, is that you? Did you find a");
            r.Add("new herd for yourself…?");
            return r;
        }
    }
}
