using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WillisWare.Infinity.Classes.Enums;
using WillisWare.Infinity.Classes.Interfaces;

namespace WillisWare.Infinity.Classes.Fundamentals
{
    public class Life : ILife
    {
        #region Methods

        /// <summary>
        /// Serializes this instance to JSON.
        /// </summary>
        /// <returns>A <see cref="string"/> value containing the instance and its children.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        #endregion

        #region Properties

        [JsonProperty(PropertyName = "age")]
        public double Age { get; set; }

        [JsonProperty(PropertyName = "gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        [JsonProperty(PropertyName = "mood")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Disposition Mood { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "children")]
        public IEnumerable<ILife> Offspring { get; set; }

        [JsonIgnore]
        public LifeStage Stage { get; set; } = LifeStage.Unknown;

        #endregion
    }
}
