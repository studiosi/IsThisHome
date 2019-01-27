using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome
{
    class TitleRoom : IRoom
    {

        public List<String> GetText()
        {
            List<String> r = new List<string>();
            r.Add("= AM I HOME? =");
            r.Add("");
            r.Add("");
            r.Add("A game by Studiosi, Risku and Solina Riekkola");
            return r;
        }

        string IRoom.ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if(tokens.Count == 1)
            {
                if(tokens[0].Item1 == "START")
                {
                    state.GoToRoom(1);
                    return "Let's do this!";
                }
            }
            return "We can't do that...";
        }
    }
}
