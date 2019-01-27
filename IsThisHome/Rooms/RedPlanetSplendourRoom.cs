using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class RedPlanetSplendourRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "STAY")
                {
                    state.GameCompleted = true;
                    return "Humankind will prevail in Mars. [ THE END ]";
                }
                else if (tokens[0].Item1 == "LEAVE")
                {
                    state.GameCompleted = true;
                    return "This is not a place I would want to bring Jonesy. [ THE END ]";
                }
            }
            return "You are asking me for something impossible.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("There's interesting sand there… I reach out to take the sample. I use my pocket scan");
            r.Add("on the sand. It's pristine Martian dust. Pride swells in my");
            r.Add("chest.");
            r.Add("");
            r.Add("The sun is setting. Purple");
            r.Add("shadows creep under the stones. I know it's soon going to be cold.");
            r.Add("There's something awe-inspiring in the hostileness of the terrain.");
            r.Add("Suddenly the radiophone rings. A voice echoes inside my helmet.");
            r.Add("\"Yes?\" I say. \"So? Have you made up your mind yet?\" It's General,");
            r.Add("who else. The sand rattles under my boots. There's a chilling change");
            r.Add("in the air. Is this the home for humanity? Should I stay or leave?");
            r.Add("");
            return r;
        }
    }
}
