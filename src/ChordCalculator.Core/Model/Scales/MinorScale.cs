using System.Collections.Generic;

namespace ChordCalculator.Core
{
    public class MinorScale : Scale
    {
        protected override string ScaleName => "Minor";
        public MinorScale(Note fundamental) : base(fundamental) { }

        protected override IEnumerable<Interval> ScaleIntervals()
        {
            yield return IntervalFactory.SegundaMayor;
            yield return IntervalFactory.TerceraMenor;
            yield return IntervalFactory.CuartaJusta;
            yield return IntervalFactory.QuintaJusta;
            yield return IntervalFactory.SextaMenor;
            yield return IntervalFactory.SeptimaMenor;
            yield return IntervalFactory.OctavaJusta;
        }
    }
}
