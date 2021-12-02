namespace ChordCalculator.Core
{
    public abstract class IntervalCalculator
    {
        protected Interval interval;

        public IntervalCalculator(Interval interval)
        {
            this.interval = interval;
        }

        public abstract Note Calculate(Note origin);
    }
}