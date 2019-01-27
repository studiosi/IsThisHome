using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class WaterIsGoneRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 1)
            {
                if (tokens[0].Item1 == "GO")
                {
                    state.GoToRoom(19);
                    return "Let's go! fast!";
                }
            }
            else if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "USE" && tokens[1].Item1 == "PICKAXE")
                {                    
                    if(state.Objects.CheckItem(Item.FLAMETHROWER, 1))
                    {
                        state.Objects.AddItem(Item.WATER, 1);
                        return "I use it and now I have water I can drink.";
                    }
                    else
                    {
                        return "I don't have a flamethrower...";
                    }                    
                }
                else if (tokens[0].Item1 == "USE" && tokens[1].Item1 == "FLAMETHROWER")
                {
                    if (state.Objects.CheckItem(Item.FLAMETHROWER, 1))
                    {
                        state.Objects.AddItem(Item.ICE, 1);
                        return "I use it to melt a lump of ice I can melt later.";
                    }
                    else
                    {
                        return "I can't find a pickaxe on my backpack...";
                    }
                }
            }
            return "No, tell me something else.";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("After a brief walk my legs start to feel heavy and my mind unfocused.");
            r.Add("Martian atmosphere makes me light-headed and dizzy. I feel a lump of");
            r.Add("flesh in my mouth: my tongue has dried up. I long for a sip of water. I");
            r.Add("look at the scenery and the red-tinted clouds hang above me. Right");
            r.Add("now Mars seems dry, but I was taught in the academy that at night the");
            r.Add("humidity raises. But I need water now. I notice a slippery looking");
            r.Add("chunk. It’s ice! A giant boulder. I think I could use something to");
            r.Add("section the ice block for me.");
            return r;
        }
    }
}
