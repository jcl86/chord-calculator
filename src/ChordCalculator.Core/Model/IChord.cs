using System.Collections.Generic;

namespace ChordCalculator.Core
{
    public interface IChord
    {
        Note Fundamental { get; }
        IEnumerable<Note> Content { get; }
    }

    public class MajorTriadChord : IChord
    {
        public IEnumerable<Note> Notes { get; private set;}

        public FundamentalTriadChord(Note fundamental)
        {
            Notes
        }

        public IEnumerable<Note> Content => throw new System.NotImplementedException();
    }
}
