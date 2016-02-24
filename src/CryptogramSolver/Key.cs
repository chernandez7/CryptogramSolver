using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptogramSolver
{
    class Key
    {
        private readonly Dictionary<char, char> _dict;
        private readonly string _cryptMessage;
        private readonly string _alphabet;

        public Key(Cryptogram crypt, string alphabet)
        {
            _dict = CreateDict(crypt, alphabet);
            _cryptMessage = crypt.GetRawMessage();
            _alphabet = alphabet;
        }

        public Dictionary<char, char> CreateDict(Cryptogram crypt, string alphabet)
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
