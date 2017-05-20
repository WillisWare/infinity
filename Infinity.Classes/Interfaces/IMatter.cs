using System.Collections.Generic;

namespace WillisWare.Infinity.Classes.Interfaces
{
    public interface IMatter
    {
        #region Methods

        void Initialize();

        string ToString();

        #endregion

        #region Properties

        IList<IMatter> Children { get; set; }

        bool IsInitialized { get; set; }

        string Name { get; set; }

        IMatter Parent { get; set; }

        IDictionary<string, string> Properties { get; set; }

        string Type { get; set; }

        #endregion
    }
}
