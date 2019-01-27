using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class DeathRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            state.GameCompleted = true;
            state.IsAlive = false;
            return "";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();

            r.Add("Your soul slowly slips away.");
            r.Add("");
            r.Add("Your eyes slowly close");
            r.Add("");
            r.Add("You are dead");

            return r;
        }
    }
}
