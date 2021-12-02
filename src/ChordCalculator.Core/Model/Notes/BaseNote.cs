namespace ChordCalculator.Core
{
     public enum BaseNote
     {
          A, B, C, D, E, F, G
     }

     public static class BaseNoteHelper
     {
          public static BaseNote Next(this BaseNote note)
          {
               if (note == BaseNote.G)
                    return BaseNote.A;
               
               return (BaseNote)(((int)note) + 1);
          }

          public static BaseNote Previous(this BaseNote note)
          {
               if (note == BaseNote.A)
                    return BaseNote.G;
               
               return (BaseNote)(((int)note) - 1);
          }
     }
}