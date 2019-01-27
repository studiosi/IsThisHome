using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome
{
    public interface IRoom
    {

        List<String> GetText();

        void ExecuteAction(GameState state, List<Tuple<String, TokenType>> tokens);

    }
}
