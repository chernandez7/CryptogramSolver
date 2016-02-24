using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptogramSolver
{
    class Key
    {
        private Dictionary<char, char> _dict;
        private string _cryptMessage;
        private string _alphabet;

        public Key(Cryptogram crypt, string alphabet)
        {
            _dict = createDict();
            _cryptMessage = crypt.
        }

        private Dictionary<char, char> createDict()
        {
            var dict = new Dictionary<char, char>(26 + 4) { 
            //Given
            { ' ', ' ' },
            { ',', ',' }, 
            { '.', '.' },
            { '!', '!' }, 

            //Context Clues
            /*
            { 'q', 'i' }, 
            { 'n', 'w' }, 
            { 'i', 'l' }, 
            { 'f', 'r' }, 
            { 'u', 'a' }, 
            { 'g', 'n' }, 
            { 's', 't' },
            { 'l', 'd' }, 
            { 't', 'y' }, 
            { 'c', 'o' }, 
            { 'd', 'u' }, 
            { 'm', 'b' }, 
            { 'e', 'k' }, 
            { 'p', 's' },
            { 'z', 'h' }, 
            { 'j', 'm' }, 
            { 'k', 'e' }, 
            { 'w', 'g' }, 
            { 'v', 'x' }, 
            { 'a', 'p' }, 
            */
              };

            //Populating dictionaly with a possible alphabet key solution
            foreach (var letter in tempAlphabet)
            {
                foreach (var c in _cryptoMessage)
                {
                    if (!dict.ContainsKey(c) && !dict.ContainsValue(letter))
                        dict.Add(c, letter); //adding individual keys and values if not already included
                }
            }
        }

        public static void PrintDict(Dictionary<char, char> dict)
        {
            foreach (var letter in _cryptoMessage)
                Console.Write(dict[letter]);
        }

        public Dictionary<char, char> GetDict()
        {
            return _dict;
        }
    }
}
