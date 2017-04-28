using System.Collections.Generic;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    public class DarkEnergy : Matter
    {
        public DarkEnergy()
            : base(string.Empty, "Dark Energy", "Default")
        {
            ChildConfigs = new List<ChildConfig>
            {
                new ChildConfig
                {
                    Name = "Default",
                    Children = new List<Child>()
                }
            };
        }
    }
}