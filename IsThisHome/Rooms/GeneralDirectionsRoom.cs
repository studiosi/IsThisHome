using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class GeneralDirectionsRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "OBEY")
                {
                    state.GoToRoom(11);
                    return "I creep closer and look into the crack.";
                }
                else if (tokens[0].Item1 == "LEAVE")
                {
                    state.GoToRoom(11);
                    return "One wrong step might be my doom. It's best I stay here.";
                }
            }
            return "You are asking me for something impossible.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("\"Zzhh – Nika, are you there?\" General asks in the radiophone. I try to");
            r.Add("answer her, but the rapid flamestorm drowns my voice. I’ve climbed");
            r.Add("to the hill. \"The scanning results show the area is safe for");
            r.Add("investigation, although there is a narrow crack in nearby. Tread");
            r.Add("carefully…\" General’s voice fades away. I look around and see the");
            r.Add("crack. It looks deep and menacing. I wonder whether I should obey or leave.");
            return r;
        }
    }
}
