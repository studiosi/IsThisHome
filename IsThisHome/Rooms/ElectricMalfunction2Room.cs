using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class ElectricMalfunction2Room : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "PUSH" && tokens[1].Item1 == "BUTTON")
                {
                    state.GameCompleted = true;
                    return "A strong electrical current smites me. [ THE END ]";
                }
            }
            else if(tokens.Count == 1)
            {
                if (tokens[0].Item1 == "WAIT")
                {
                    state.GameCompleted = true;
                    return "I take a deep breath as the the airlock doors open. [ THE END ]";
                }
            }
            return "Can't do that, tell me something else.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I brace myself and push the button. I wait, terrified and out of breath,");
            r.Add("but nothing happens. Suddenly the room feels cramped. I can feel the");
            r.Add("sweat pooling in my armpits. I get an urge to push the button again.");
            r.Add("Then a vague memory of my instructor hovers in my mind. \"Wait, it");
            r.Add("might short-circuit\", she said in a similar situation a long time ago.");
            return r;
        }
    }
}
