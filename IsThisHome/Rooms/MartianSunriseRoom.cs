using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class MartianSunriseRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "STAY")
                {
                    state.GameCompleted = true;
                    return "This is it. This soil is able to provide us a solid food source. [ THE END ]";
                }
                else if (tokens[0].Item1 == "LEAVE")
                {
                    state.GameCompleted = true;
                    return "My family is still on Earth... [ THE END ]";
                }
            }
            return "Not now.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("It's an");
            r.Add("affirmation of hope! Once terraformed, this soil could be used");
            r.Add("to grow Jonesy’s favourite variety of corn!");
            r.Add("");
            r.Add("I straighten myself and look at the view. Setting sun glimmers behind");
            r.Add("the mountain range. I can’t help but think it’s the kind of scenery");
            r.Add("Jonesy would like. He could herd the sheep on the vast plains.");
            r.Add("Suddenly my radiophone rings. A voice echoes inside my helmet.");
            r.Add("\"Yes?\" I say.\"So? Have you made up your mind yet?\" I hear General's");
            r.Add("familiar voice and I know it’s time to decide. The Martian wind");
            r.Add("pushes sand around in the wasteland before me. There's a chilling");
            r.Add("change in the air. Is this the home for humanity? Should we stay or");
            r.Add("leave?");
            return r;
        }
    }
}
