using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome.Rooms
{
    class AirlockRoom : IRoom
    {
        public string ExecuteAction(GameState state, List<Tuple<string, TokenType>> tokens)
        {
            if (tokens.Count == 2)
            {
                if (tokens[0].Item1 == "TAKE" && tokens[1].Item1 == "PICKAXE")
                {
                    state.Objects.AddItem(Item.PICKAXE, 1);
                    return "I put the pickaxe on my backpack";
                }
                else if (tokens[0].Item1 == "TAKE" && tokens[1].Item1 == "FLAMETHROWER")
                {
                    state.Objects.AddItem(Item.FLAMETHROWER, 1);
                    return "Flames all over the place. You asked for it, door!";
                }
                else if (tokens[0].Item1 == "PRESS" && tokens[1].Item1 == "BUTTON")
                {                    
                    buttonPressed = true;
                    return "Click, nothing really happens. Maybe I can use my picking skills?";
                }
                if (buttonPressed)
                {
                    if (tokens[0].Item1 == "FIX" && tokens[1].Item1 == "LOCK")
                    {
                        state.GoToRoom(17);
                        return "I fix the door. I move immediately";
                    }
                    else if (tokens[0].Item1 == "PICK" && tokens[1].Item1 == "LOCK")
                    {
                        state.GoToRoom(12);
                        return "What? *sparks everywhere*";
                    }
                }
            }
            return "Can't do much in that sense...";
        }

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("I'm standing in front of an airlock. The airlock panel is slightly"); 
            r.Add("blackened. I'm afraid it might have been damaged during the");
            r.Add("landing. The panel has a single flickering button. I notice a pickaxe");
            r.Add("on top of a crate and a flamethrower on the wall.");
            return r;
        }

        private bool buttonPressed = false;
    }
}
