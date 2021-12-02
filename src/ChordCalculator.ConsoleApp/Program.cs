using System;
using System.Collections.Generic;
using ChordCalculator.Core;

namespace ChordCalculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var fundamental in new List<Note>() 
            { 
                new Note(BaseNote.C), 
                new Note(BaseNote.D),
                new Note(BaseNote.E),
                new Note(BaseNote.F),
                new Note(BaseNote.G),
                new Note(BaseNote.A),
                new Note(BaseNote.B)
            })
            {
                Console.WriteLine(fundamental.ToString());
                var majorScale = new MajorScale(fundamental);
                var minorScale = new MinorScale(fundamental);
                Console.WriteLine(majorScale.Summary());
                Console.WriteLine(minorScale.Summary());
                Console.WriteLine("");
            }
        }
    }
}
