namespace ChordCalculator.Core
{
    public static class NoteFactory
    {
        public static Note Do => new Note(BaseNote.C);
        public static Note Re => new Note(BaseNote.D);
        public static Note Mi => new Note(BaseNote.E);
        public static Note Fa => new Note(BaseNote.F);
        public static Note Sol => new Note(BaseNote.G);
        public static Note La => new Note(BaseNote.A);
        public static Note Si => new Note(BaseNote.B);
    }
}