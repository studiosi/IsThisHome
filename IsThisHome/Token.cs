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
            "FOR",
            "AT"
        };
        static string[] verbs = {
            "RUN",
            "GO",
            "MOVE",
            "OPEN"
        };
        static string[] objects =
        {
            "FLAMETHROWER",
            "DOOR",
            "GOLD",
            "KEY"
        };
        public static TokenType FromWord(string word)
        {
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
        PREPOSITION
    }
}
