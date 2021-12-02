using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace ChordCalculator.Core
{
    public class Note 
    {
        public BaseNote BaseNote { get; private set; }         
        public NoteType NoteType { get; set; }

        public Note(BaseNote note, NoteType type = NoteType.Normal) {
            BaseNote = note;
            NoteType = type;
        }

        public Note AddSemiton()
        {
            if (NoteType == NoteType.Bemol)
                return new Note(BaseNote, NoteType.Normal);

            if (NoteType == NoteType.Normal && BaseNote != BaseNote.E && BaseNote != BaseNote.B)
                return new Note(BaseNote, NoteType.Sostenido);

            return new Note(BaseNote.Next());
        }

        public Note RemoveSemiton()
        {
            if (NoteType == NoteType.Sostenido)
                return new Note(BaseNote, NoteType.Normal);

            if (NoteType == NoteType.Normal && BaseNote != BaseNote.F && BaseNote != BaseNote.C)
                return new Note(BaseNote, NoteType.Bemol);

            return new Note(BaseNote.Previous());
        }

        public override string ToString() => $"{BaseNote.ToString()}{NoteType.Description()}";

        public override bool Equals(object obj)
        {        
            if (obj == null || GetType() != obj.GetType())
                return false;
            var other = (Note)obj;
            return other.NoteType == NoteType && other.BaseNote == BaseNote;
        }
        
        public override int GetHashCode() => base.GetHashCode();
    }
}