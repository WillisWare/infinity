using System.Collections.Generic;
using Infinity.Enums;

namespace Infinity.Interfaces
{
    public interface ILife
    {
        #region Methods

        #endregion

        #region Properties

        double Age { get; set; }

        Gender Gender { get; set; }

        Disposition Mood { get; set; }

        string Name { get; set; }

        IEnumerable<ILife> Offspring { get; set; }

        LifeStage Stage { get; set; }

        #endregion
    }
}
