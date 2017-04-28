using System.Collections.Generic;
using Infinity.Fundamentals;

namespace Infinity.Objects
{
    public class Galaxy : Matter
    {
        public Galaxy()
            : base(string.Empty, "Galaxy", "Default")
        {
            ChildConfigs = new List<ChildConfig>
            {
                new ChildConfig
                {
                    Name = "Default",
                    Children = new List<Child>
                    {
                        new Child(10) {
                            Classes = { { "Infinity.Things.Star_System", 1.0 } }
                        }
                    }
                }
            };

            var nameChoices = new List<Dictionary<string, double>>
            {
                new Dictionary<string, double> { { "Ad", 1.0 }, { "Ith", 1.0 }, { "Gek", 1.0 }, { "Thur", 1.0 }, { "Det", 1.0 }, { "Urp", 1.0 }, { "Wib", 1.0 }, { "Nuf", 1.0 }, { "Log", 1.0 } },
                new Dictionary<string, double> { { "it", 1.0 }, { "ag", 1.0 }, { "op", 1.0 }, { "ub", 1.0 }, { "em", 1.0 }, { "at", 1.0 }, { "yx", 1.0 } },
                new Dictionary<string, double> { { "ia", 1.0 }, { "es", 1.0 }, { "ath", 1.0 }, { "ora", 1.0 }, { "ino", 1.0 }, { "ope", 1.0 }, { "ing", 1.0 } },
                new Dictionary<string, double> { { "", 1.0 }, { " Sigma", 0.5 }, { " Prime", 0.5 }, { " Lorem", 0.5 }, { " Xayah", 0.3 }, { " Ultima", 0.2 }, { " Fin", 0.1 } }
            };
            nameChoices.ForEach(segment => Name += Choose(segment));
        }
    }
}