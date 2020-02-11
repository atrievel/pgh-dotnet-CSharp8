using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotNetLightningTalks
{
    class UsingExample
    {
        public int OldMethod(string path, IEnumerable<string> lines) 
        {
            int linesContainingA = 0;

            using (var writer = new StreamWriter(path, append:false, Encoding.UTF8))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                    linesContainingA += line.Contains('A') ? 1 : 0;
                }
            }

            return linesContainingA;
        }

        public int NewMethod(string path, IEnumerable<string> lines) 
        {
            using var writer = new StreamWriter(path, append:false, Encoding.UTF8);
            int linesContainingA = 0;
            
            foreach (var line in lines)
            {
                writer.WriteLine(line);
                linesContainingA += line.Contains('A') ? 1 : 0;
            }
            
            return linesContainingA;
        }
    }
}