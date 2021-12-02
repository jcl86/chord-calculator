using System.Collections.Generic;
using System.Linq;

namespace ChordCalculator.Core
{
    public abstract class Scale 
    {
        protected abstract string ScaleName { get; }
        
        public List<Note> Notes {get; private set; }

        public Scale(Note fundamental) 
        {
            this.Notes = new List<Note>() { fundamental };
            foreach(Interval interval in ScaleIntervals())
                Notes.Add(new AscendingIntervalCalculator(interval).Calculate(fundamental));
        }

        protected abstract IEnumerable<Interval> ScaleIntervals();

        public string Content() => string.Join(" - ", Notes.Select(note => note.ToString()));
        public override string ToString() => $"{Notes.First().ToString()} {ScaleName}";
        public string Summary() => $"{ToString()}: {Content()}";
    }
}
