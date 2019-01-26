using System;
using System.Collections.Generic;

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
    }
}
