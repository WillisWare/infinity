using System.Collections.Generic;
using WillisWare.Infinity.Classes.Enums;

namespace WillisWare.Infinity.Classes.Interfaces
{
    public interface ILife
    {
        #region Methods

        string ToString();

        #endregion

        #region Properties

        double Age { get; set; }

        Gender Gender { get; set; }

        Disposition Mood { get; set; }

        string Name { get; set; }

        IEnumerable<ILife> Offspring { get; set; }

        LifeStage Stage { get; }

        #endregion
    }
}
