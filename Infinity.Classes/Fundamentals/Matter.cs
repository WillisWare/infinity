using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Generators;
using WillisWare.Infinity.Classes.Interfaces;
using WillisWare.Infinity.Common.DataTypes;

namespace WillisWare.Infinity.Classes.Fundamentals
{
    /// <summary>
    /// Base class for all matter in the Infinity solution.
    /// </summary>
    public abstract class Matter : IMatter
    {
        #region Constructors

        /// <summary>
        /// Default constructor. Initializes an instance of this class with a random name.
        /// </summary>
        protected Matter()
        {
            var syllables = RandomNumber.Instance.Next(1, 7);
            Name = RandomWordGenerator.Word((int)syllables);

            Type = GetType().Name;
        }

        /// <summary>
        /// Overloaded. Initializes an instance of this class with the specified name.
        /// </summary>
        /// <param name="name">A <see cref="string"/> value containing the name.</param>
        protected Matter(string name)
            : this(name, null)
        {
        }

        /// <summary>
        /// Overloaded. Initializes an instance of this class with the specified name and parent instance.
        /// </summary>
        /// <param name="name">A <see cref="string"/> value containing the name.</param>
        /// <param name="parent">An <see cref="IMatter"/> implementation containing the parent instance.</param>
        protected Matter(string name, IMatter parent)
        {
            Name = name;
            Parent = parent;
            Type = GetType().Name;
        }

        #endregion

        #region Methods

        protected Type[] GetAllowedChildren()
        {
            var attributes = GetType().GetCustomAttributes(typeof(AllowedChildAttribute)) as IEnumerable<AllowedChildAttribute>;

            return attributes?.Select(c => c.AllowedType.ChildType).ToArray() ?? new Type[] { };
        }

        protected Range GetPopulationLimits(Type childType)
        {
            var attributes = GetType().GetCustomAttributes(typeof(AllowedChildAttribute)) as IEnumerable<AllowedChildAttribute>;

            var child = attributes?.FirstOrDefault(a => a.AllowedType.ChildType == childType)?.AllowedType;

            return child?.PopulationLimit ?? new Range(0, 1);
        }

        public void Initialize()
        {
            if (!IsInitialized)
            {
                LoadChildren();
            }

            IsInitialized = true;
        }

        protected void LoadChildren()
        {
            var childTypes = GetAllowedChildren();
            if (!childTypes.Any())
            {
                // This object cannot have children.
                return;
            }

            for (var count = 0; count < childTypes.Length; count++)
            {
                var boundaries = GetPopulationLimits(childTypes[count]);

                var upperBoundary = RandomNumber.Instance.Next(boundaries.Minimum, boundaries.Maximum);
                for (var childIndex = 0; childIndex < upperBoundary; childIndex++)
                {
                    if (!(Activator.CreateInstance(childTypes[count]) is IMatter child))
                    {
                        continue;
                    }

                    child.Parent = this;

                    Children.Add(child);
                }
            }
        }

        /// <summary>
        /// Serializes this instance to JSON.
        /// </summary>
        /// <returns>A <see cref="string"/> value containing the instance and its children.</returns>
        public override string ToString()
        {
            var serializationSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            return JsonConvert.SerializeObject(this, Formatting.Indented, serializationSettings);
        }

        #endregion

        #region Properties

        [JsonProperty(PropertyName = "children")]
        public IList<IMatter> Children { get; set; } = new List<IMatter>();

        [JsonIgnore]
        public bool IsInitialized { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonIgnore]
        public IMatter Parent { get; set; }

        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        #endregion
    }
}
