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

        void IRoom.ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            return;
        }
    }
}
