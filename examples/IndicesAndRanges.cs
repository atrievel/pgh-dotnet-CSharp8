using System;
using System.Linq;

namespace DotNetLightningTalks
{
    class IndicesAndRange
    {
        public string[] Words => new string[]
        {
                        // index from start    index from end
            "The",      // 0                   ^9
            "quick",    // 1                   ^8
            "brown",    // 2                   ^7
            "fox",      // 3                   ^6
            "jumped",   // 4                   ^5
            "over",     // 5                   ^4
            "the",      // 6                   ^3
            "lazy",     // 7                   ^2
            "dog"       // 8                   ^1
        };              // 9 (or Words.Length) ^0

        public void TryIndices() 
        {
            // The (index from start, LINQ, index from end)
            Console.WriteLine(Words[0]);
            Console.WriteLine(Words.First());
            Console.WriteLine(Words[^9]);

            // dog (index from start, LINQ, index from end)
            Console.WriteLine(Words[8]);
            Console.WriteLine(Words.Last());
            Console.WriteLine(Words[^1]);

            // Exception thrown (index from start, index from end)
            Console.WriteLine(Words[Words.Length]);
            Console.WriteLine(Words[^0]);
        }

        public void TryRanges() 
        {
            var quickBrownFox = words[1..4]; // contains "quick" through "fox", but not "jumped"
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
        }
    }
}