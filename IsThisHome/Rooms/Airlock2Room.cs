using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class Airlock2Room : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            throw new NotImplementedException();
        }

        public List<string> GetText()
        {
            throw new NotImplementedException();
        }
    }
}
