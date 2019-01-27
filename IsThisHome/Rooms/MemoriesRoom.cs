using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class MemoriesRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (pictureSeen && tokens.Count == 1)
            {
                if (tokens[0].Item1 == "GO")
                {
                    state.GoToRoom(6);
                    return "I need to do this, for Jonesy and for others.";
                }
            }
            if (tokens.Count == 3)
            {
                if (tokens[0].Item1 == "LOOK" && tokens[1].Item1 == "AT" && tokens[2].Item1 == "SAND")
                {
                    nSand++;
                    if(nSand == 3)
                    {
                        state.GoToRoom(5); // Secret Room
                    }
                    return "I am sure there is nothing on the sand";
                }
                else if (tokens[0].Item1 == "LOOK" && tokens[1].Item1 == "AT" && tokens[2].Item1 == "PICTURE")
                {
                    pictureSeen = true;
                    return "Jonesy approves of the mission.";
                }
            }
            return "";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I walk for a moment in the light gravity and feel like I am floating on");
            r.Add("the air. This giant red giant is still a mystery for us all. Could it be a");
            r.Add("home we're looking for? Mars looks like a haunting place, and I am");
            r.Add("here experiencing it all alone. I feel the chill of loneliness, but then I");
            r.Add("see the glimmering light that shines down on to the sand. It's like a");
            r.Add("glimpse of hope. Without any hesitation I take the picture of Jonesy");
            r.Add("from my pocket and squeeze it with my sturdy glove.");
            return r;
        }

        private int nSand = 0;
        private bool pictureSeen = false;
    }
}
