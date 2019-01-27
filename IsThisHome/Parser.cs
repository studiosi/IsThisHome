using System;
using System.Collections.Generic;
using System.Linq;

namespace IsThisHome
{
    class Parser
    {
        static char[] Separators = { ' ' };
        public static List<String> Tokenize(String input)
        {
            string[] parts = input.ToUpper().Split(Parser.Separators);
            List<String> result = new List<string>(parts);
            return result;
        }
        public static List<Tuple<String, TokenType>> Parse(List<String> parts)
        {
            List<Tuple<String, TokenType>> result = new List<Tuple<String, TokenType>>();
            foreach(string word in parts)
            {
                result.Add(new Tuple<String, TokenType>(word, Token.FromWord(word)));
            }
            return result;
        }
        public static List<Tuple<String, TokenType>> TokenizeAndParse(String input)
        {
            List<String> words = Tokenize(input);
            return Parse(words);
        }

        public static bool IsValidStructure(List<Tuple<String, TokenType>> tokenPairs)
        {
            List<TokenType> tknList = (from t in tokenPairs select t.Item2).ToList();
            if(tknList.Count() == 1)
            {
                if(tknList[0] == TokenType.VERB)
                {
                    return true;
                }
            }
            else if(tknList.Count() == 2)
            {
                if(tknList[0] == TokenType.VERB && tknList[1] == TokenType.OBJECT)
                {
                    return true;
                }
            }
            else if(tknList.Count() == 3)
            {
                if (tknList[0] == TokenType.VERB && tknList[1] == TokenType.PREPOSITION && tknList[2] == TokenType.NUMBER)
                {
                    return true;
                }
            }
            else if (tknList.Count() == 4)
            {
                if (tknList[0] == TokenType.VERB && tknList[1] == TokenType.OBJECT && tknList[2] == TokenType.PREPOSITION && tknList[3] == TokenType.OBJECT)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
