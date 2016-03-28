using System;

namespace CryptogramSolver
{

    //Author: Christopher Hernandez

    internal class Program
    {
        private static readonly string _cryptoMessage = "ipke et bdpqs, bryqd opkc lpbs. ayrk ifed lfrs! tyeqfwsrq gfbvswsw yg rpi trs, opvs opw! rtpo rtykw ifed eit opk brsi, kte smsk tks npwc xfms bdpqfkx. ksmsr qopbv nfgq, kte qskw soteftk, opvs msrc opw! ipebd btygnsq anti vfqqsq, apac eyrk gprskeq qnpmsq. wrtg os bfxprsees, skw yg sjersosnc opw!";
        private static readonly string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_cryptoMessage);
            Console.WriteLine();
            var counter = 0;
            var counterTwo = 0;
            var permutations = 0;
            var startTime = DateTime.Now;

            var cryptObject = new Cryptogram(_cryptoMessage);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alphabet: {0}", _alphabet);
            Console.ForegroundColor = ConsoleColor.Yellow;
            var cryptKeyObject = new Key(cryptObject, _alphabet);
            cryptKeyObject.CreateDict(cryptObject, _alphabet);
            cryptKeyObject.PrintDict();
            Console.WriteLine();

            /*
            foreach (var letter in _alphabet)
            {
                foreach (var lett in _alphabet)
                {
                    var tempAlphabet = SwapCharacters(_alphabet, counter, counterTwo);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Alphabet: {0}", tempAlphabet);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    var cryptKeyObject = new Key(cryptObject, tempAlphabet);
                    cryptKeyObject.CreateDict(cryptObject, tempAlphabet);
                    cryptKeyObject.PrintDict();
                    counter++;
                    permutations++;
                    Console.WriteLine();
                }
                counter = 0;
                counterTwo++;
            }
            */

            var totalSeconds = (DateTime.Now - startTime).TotalSeconds;
            Console.WriteLine("Program took {0} seconds to create {1} permutations", totalSeconds, permutations);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            return 0;
        }

        private static string SwapCharacters(string value, int position1, int position2)
        {
            var array = value.ToCharArray();
            var temp = array[position1]; // Get temporary copy of character
            array[position1] = array[position2];
            array[position2] = temp;
            return new string(array);
        }
    }
}
