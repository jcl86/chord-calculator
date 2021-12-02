using System.Linq;

namespace ChordCalculator.Core
{ 
    public class DescendingIntervalCalculator : IntervalCalculator
    {
        public DescendingIntervalCalculator(Interval interval) : base(interval) { }

        public override Note Calculate(Note origin)
        {
            var destinationNote = origin;
            foreach (var i in Enumerable.Range(0, interval.Semitons()))
            {
                destinationNote = destinationNote.RemoveSemiton();
            }
            return destinationNote;
        }
    }
}
