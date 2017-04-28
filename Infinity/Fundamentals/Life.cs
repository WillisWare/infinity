using System.Collections.Generic;
using Infinity.Enums;
using Infinity.Interfaces;

namespace Infinity.Fundamentals
{
    public abstract class Life : ILife
    {
        #region Properties

        public double Age { get; set; }

        public Gender Gender { get; set; }

        public Disposition Mood { get; set; }

        public string Name { get; set; }

        public IEnumerable<ILife> Offspring { get; set; }

        public LifeStage Stage { get; set; }

        #endregion
    }
}
