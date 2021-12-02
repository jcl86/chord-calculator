namespace ChordCalculator.Core
{
    public static class IntervalFactory
    {
        public static Interval SegundaMenor => new Interval(2, IntervalKind.Menor);
        public static Interval SegundaMayor => new Interval(2, IntervalKind.Mayor);
        public static Interval TerceraMenor => new Interval(3, IntervalKind.Menor);
        public static Interval TerceraMayor => new Interval(3, IntervalKind.Mayor);
        public static Interval CuartaJusta => new Interval(4, IntervalKind.Justa);
        public static Interval QuintaJusta => new Interval(5, IntervalKind.Justa);
        public static Interval SextaMenor => new Interval(6, IntervalKind.Menor);
        public static Interval SextaMayor => new Interval(6, IntervalKind.Mayor);
        public static Interval SeptimaMenor => new Interval(7, IntervalKind.Menor);
        public static Interval SeptimaMayor => new Interval(7, IntervalKind.Mayor);
        public static Interval OctavaJusta => new Interval(8, IntervalKind.Justa);
    }
}