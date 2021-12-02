using System.ComponentModel;

namespace ChordCalculator.Core
{
    public enum NoteType
    {
        [Description("")]
        Normal,

        [Description("#")]
        Sostenido,

        [Description("b")]
        Bemol
    }
}