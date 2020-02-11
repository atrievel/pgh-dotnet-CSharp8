using System;
using System.Collections.Generic;

namespace DotNetLightningTalks
{
    class AsyncStreams
    {
        // It's declared with the async modifier.
        // It returns an IAsyncEnumerable<T>.
        // The method contains yield return statements to return successive elements in the asynchronous stream.
        private async IAsyncEnumerable<int> GetRandomNumbers(int limit) 
        {
            Random random = new Random();

            for (int i = 0; i < limit; i++)
            {
                yield return random.Next(0, limit);
            }
        }

        public async Task PrintRandomNumbers() 
        {
            await foreach (var number in GetRandomNumbers(100))
            {
                Console.WriteLine(number);
            }
        }
    }
}