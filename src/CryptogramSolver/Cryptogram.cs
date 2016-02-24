using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptogramSolver
{
    class Cryptogram
    {
        private string _rawMessage;
        private string[] _wordArray;
        
        public Cryptogram(string message)
        {
            _rawMessage = message;
            _wordArray = createWordArray(message);
        }

        private string[] createWordArray(string message)
        {
            var wordArray = message.Split(' ');
            return wordArray;
        }

        public string GetRawMessage()
        {
            return _rawMessage;
        }

        public string[] GetWordArray()
        {
            return _wordArray;
        }

        public int GetWordCount()
        {
            return _wordArray.Length;
        }
    }
}
