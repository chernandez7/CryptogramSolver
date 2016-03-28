namespace CryptogramSolver
{
    internal class Cryptogram
    {
        private readonly string _rawMessage;
        private readonly string[] _wordArray;
        
        public Cryptogram(string message)
        {
            _rawMessage = message;
            _wordArray = CreateWordArray(message);
        }

        private string[] CreateWordArray(string message)
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
