using System;

namespace ChordCalculator.Core
{
    public struct Interval
    {
        private int grade;
        public bool IsSecond => grade == 2;
        public bool IsThird => grade == 3;
        public bool IsSixth => grade == 6;
        public bool IsSeventh => grade == 7;
        public bool IsSecondThirdSixthSeventh => IsSecond || IsThird || IsSixth || IsSeventh;

        public bool IsFourth => grade == 4;
        public bool IsFifth => grade == 5;
        public bool IsOctave => grade == 8;
        public bool IsFourthFifthOctave => IsFourth || IsFifth || IsOctave;

        private IntervalKind kind;

        public Interval(int grade, IntervalKind kind)
        {
            this.grade = grade;
            this.kind = kind;

            Validate();
        }

        private void Validate()
        {
            if (grade < 2 || grade > 8)
                throw new ArgumentOutOfRangeException("Grade must be betwen 2 and 8");

            switch(kind)
            {
                case IntervalKind.Menor:
                case IntervalKind.Mayor:
                    if (!IsSecondThirdSixthSeventh)
                        throw new ArgumentException($"{grade} {kind} is not a valid Interval");
                break;

                case IntervalKind.Justa:
                    if (!IsFourthFifthOctave)
                        throw new ArgumentException($"{grade} {kind} is not a valid Interval");
                break;
            }
        }

        public int Semitons() => BaseValue() + Modifier();

        private int BaseValue()
        {
            if (grade == 2) return 1;
            if (grade == 3) return 3;
            if (grade == 4) return 5;
            if (grade == 5) return 7;
            if (grade == 6) return 8;
            if (grade == 7) return 10;
            if (grade == 8) return 12;
            throw new NotImplementedException();
        }

        private int Modifier()
        {
            if (IsSecondThirdSixthSeventh)
                return ModifierThirthSixthSeventhCalculation();

            if (IsFourthFifthOctave)
                return ModifierFourthFifthOctaveCalculation();

            throw new NotImplementedException();
        }
        private int ModifierThirthSixthSeventhCalculation()
        {
            switch(kind)
            {
                case IntervalKind.Disminuido: return -1;
                case IntervalKind.Menor: return 0;
                case IntervalKind.Mayor: return +1;
                case IntervalKind.Aumentado: return +2;
            }
            throw new NotImplementedException();
        }

        private int ModifierFourthFifthOctaveCalculation()
        {
            switch(kind)
            {
                case IntervalKind.Disminuido: return -1;
                case IntervalKind.Justa: return 0;
                case IntervalKind.Aumentado: return +1;
            }
            throw new NotImplementedException();
        }
    }
}
