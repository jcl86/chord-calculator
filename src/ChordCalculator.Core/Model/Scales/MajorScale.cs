using System.Collections.Generic;

namespace ChordCalculator.Core
{
    public class MajorScale : Scale
    {
        protected override string ScaleName => "Major";
        public MajorScale(Note fundamental) : base(fundamental) { }

        protected override IEnumerable<Interval> ScaleIntervals()
        {
            yield return IntervalFactory.SegundaMayor;
            yield return IntervalFactory.TerceraMayor;
            yield return IntervalFactory.CuartaJusta;
            yield return IntervalFactory.QuintaJusta;
            yield return IntervalFactory.SextaMayor;
            yield return IntervalFactory.SeptimaMayor;
            yield return IntervalFactory.OctavaJusta;
        }
    }
}
