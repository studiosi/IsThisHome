using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisHome
{
    public class Token
    {
        static string[] prepositions = {
            "ON",
            "AT",
            "TO",
            "FOR",
            "FROM",
            "UP"
        };
        static string[] verbs = {
            "START",
            "SHOW",
            "PUT",
            "TALK",
            "LOOK",
            "FIX",
            "USE",
            "WAIT",
            "GO",
            "MOVE",
            "PUSH",
            "EXAMINE",
            "PICK",
            "TAKE",
            "JUMP",
            "STAY",
            "CONTINUE",
            "WALK",
            "CALL",
            "SCAN",
            "OBEY",
            "SHOW",
            "CLIMB",
            "PICK",
            "ADD",
            "LEAVE",
            "BEAM",
            "QUIT",
            "PRESS",
            "HELP"
        };
        static string[] objects =
        {
            "PICTURE",
            "SPACESUIT",
            "JYRI",
            "FLAMETHROWER",
            "DOOR",
            "BUTTON",
            "SOIL",
            "MOUND",
            "SAND",
            "STARROCK",
            "SQUAREROCK",
            "ROCK",
            "RIGHT",
            "LEFT",
            "RADIOPHONE",
            "HILL",
            "LOCK",
            "ICE",
            "GENERAL",
            "VERBS",
            "PANEL",
            "PICKAXE"
        };
        public static List<string> GetVerbsText()
        {
            List<string> r = new List<string>();
            r.Add("= VERBS =");
            r.Add("");
            for(int i = 0; i < verbs.Length; i+=2)
            {
                string ps = "";
                ps += verbs[i];
                if(i + 1 < verbs.Length)
                {
                    while(ps.Length <= 20)
                    {
                        ps += " ";
                    }                    
                    ps += verbs[i + 1];
                }
                r.Add(ps);
            }
            r.Add("");
            r.Add("Press enter to continue...");
            return r;
        }
        public static TokenType FromWord(string word)
        {
            int i;
            if (Token.objects.Contains<string>(word))
            {
                return TokenType.OBJECT;
            }
            else if (Token.prepositions.Contains<string>(word))
            {
                return TokenType.PREPOSITION;
            }
            else if (Token.verbs.Contains<string>(word))
            {
                return TokenType.VERB;
            }
      
            else if (int.TryParse(word, out i))
            {
                return TokenType.NUMBER;
            }
            else
            {
                return TokenType.NOT_RECOGNIZED;
            }            
        }
    }
    public enum TokenType
    {
        NOT_RECOGNIZED,
        VERB,
        OBJECT,
        PREPOSITION,
        NUMBER
    }
}
