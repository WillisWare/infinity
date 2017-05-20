using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WillisWare.Infinity.Classes.Attributes;
using WillisWare.Infinity.Classes.Generators;
using WillisWare.Infinity.Classes.Interfaces;

namespace WillisWare.Infinity.Classes.Fundamentals
{
    public abstract class Matter : IMatter
    {
        #region Constructors

        protected Matter()
        {
            var syllables = RandomNumber.Instance.Next(1, 7);
            Name = RandomWordGenerator.Word(syllables);

            Type = GetType().Name;
        }

        protected Matter(string name)
            : this(name, null)
        {
        }

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
            var attribute = Attribute.GetCustomAttribute(GetType(), typeof(AllowedChildAttribute)) as AllowedChildAttribute;
            if (attribute != null)
            {
                return attribute.AllowedTypes;
            }
            return new Type[] { };
        }

        protected int GetMaxChildren()
        {
            var attribute = Attribute.GetCustomAttribute(GetType(), typeof(MaxChildrenAttribute)) as MaxChildrenAttribute;
            if (attribute != null)
            {
                return attribute.Value;
            }
            return RandomNumber.Instance.Next(0, 10);
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

            var numChildren = RandomNumber.Instance.Next(0, GetMaxChildren());
            for (var count = 0; count < numChildren; count++)
            {
                var randomTypeIndex = RandomNumber.Instance.Next(0, childTypes.Length);

                var child = Activator.CreateInstance(childTypes[randomTypeIndex]) as IMatter;
                child.Parent = this;

                Children.Add(child);
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
