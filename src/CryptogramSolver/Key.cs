using System;
using System.Collections.Generic;

namespace CryptogramSolver
{
    class Key
    {
        private readonly Dictionary<char, char> _dict;
        private readonly string _cryptMessage;

        public Key(Cryptogram crypt, string alphabet)
        {
            _dict = CreateDict(crypt, alphabet);
            _cryptMessage = crypt.GetRawMessage();
        }

        public Dictionary<char, char> CreateDict(Cryptogram crypt, string alphabet)
        {
            var dict = new Dictionary<char, char>(26 + 6)
            {
                //Given
                {' ', ' '},
                {',', ','},
                {'.', '.'},
                {'!', '!'},
                {'?', '?'},
                {'\'', '\''},

                //Context Clues
                {'a', 'B'}, //a = b
                {'b', 'C'}, //b = c
                {'c', 'Y'}, //c = y
                {'d', 'H'}, //d = h
                {'e', 'T'}, //e = t
                {'f', 'I'}, //f = i
                {'g', 'P'}, //g = p
                //{'h', 'h'},
                {'i', 'W'}, //i = w
                {'j', 'X'}, //j = x
                {'k', 'N'}, //k = n
                {'l', 'F'}, //l = f
                {'m', 'V'}, //m = v
                {'n', 'L'}, //n = l
                {'o', 'M'}, //o = m
                {'p', 'A'}, //p = a
                {'q', 'S'}, //q = s
                {'r', 'R'}, //r = r
                {'s', 'E'}, //s = e
                {'t', 'O'}, //t = o
                //{'u', 'u'},
                {'v', 'K'}, //v = k 
                {'w', 'D'}, //w = d
                {'x', 'G'}, //x = g
                {'y', 'U'}, //y = u
                //{'z', 'z'},
                
            };

            //Populating dictionaly with a possible alphabet key solution
            foreach (var letter in alphabet)
            {
                foreach (var c in crypt.GetRawMessage())
                {
                    if (!dict.ContainsKey(c) && !dict.ContainsValue(letter))
                        dict.Add(c, letter); //adding individual keys and values if not already included
                }
            }
            return dict;
        }

        public void PrintDict()
        {
            foreach (var letter in _cryptMessage)
                Console.Write(_dict[letter]);
            Console.WriteLine();
        }

        public Dictionary<char, char> GetDict()
        {
            return _dict;
        }
    }
}
