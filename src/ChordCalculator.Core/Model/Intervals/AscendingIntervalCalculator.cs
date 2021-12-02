using System.Linq;

namespace ChordCalculator.Core
{
    public class AscendingIntervalCalculator : IntervalCalculator
    {
        public AscendingIntervalCalculator(Interval interval) : base(interval) { }

        public override Note Calculate(Note origin)
        {
            var destinationNote = origin;
            foreach (var i in Enumerable.Range(0, interval.Semitons()))
            {
                destinationNote = destinationNote.AddSemiton();
            }
            return destinationNote;
        }
    }
}
