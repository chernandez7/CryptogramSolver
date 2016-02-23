using System;
using System.Collections.Generic;

namespace CryptogramSolver
{

    //Author: Christopher Hernandez

    class Cryptogram
    {
        private static string _cryptoMessage = "q nuie ufcdgl dgqgskfkpskl qg tcd, mds pzcdil tcd zqs jk tcd xug kvakxs jk sc sft ugl psdg ussuxe. mkxudpk q xcdil gcs mkuf icpqgw jt zcgkt sc tcd.";
        private static string _alphabet = "abcdefghijklmnopqrstuvwxyz";

        static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_cryptoMessage);
            Console.WriteLine();
            var counter = 0;
            var counterTwo = 0;
            var permutations = 0;
            var startTime = DateTime.Now;
            foreach (var letter in _alphabet)
            {
                foreach (var lett in _alphabet)
                {
                    var tempAlphabet = SwapCharacters(_alphabet, counter, counterTwo);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Alphabet: {0}", tempAlphabet);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    CreateDict(tempAlphabet);
                    counter++;
                    permutations++;
                    Console.WriteLine();
                }
                counter = 0;
                counterTwo++;
            }

            var totalSeconds = (DateTime.Now - startTime).TotalSeconds;
            Console.WriteLine("Program took {0} seconds to create {1} permutations", totalSeconds, permutations);

            Console.ReadKey();
            return 0;
        }

        private static void CreateDict(string tempAlphabet)
        {
            var dict = new Dictionary<char, char>(26) { 
            //Given
            { 'q', 'i' }, 
            { ' ', ' ' },
            { ',', ',' }, 
            { '.', '.' }, 

            //Context Clues
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

            PrintDict(dict);
            Console.WriteLine();
        }

        private static void PrintDict(Dictionary<char, char> dict)
        {
            foreach (var letter in _cryptoMessage)
                Console.Write(dict[letter]);
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
