using System;
using System.Collections.Generic;
using System.Linq;
using Infinity.Interfaces;

namespace Infinity.Fundamentals
{
    public abstract class Matter : IMatter
    {
        #region Members

        public static Random Random => new Random();

        private IDictionary<string, string> _properties;

        private IList<IMatter> _children;

        #endregion

        #region Constructors

        protected Matter()
        {
            // Initialize empty instance.
        }

        protected Matter(string name, string type, string subType)
        {
            ChildConfigs = new List<ChildConfig>();
            Children = new List<Matter>();
            Properties = new Dictionary<string, string>();

            Name = name;
            SubType = subType;
            Type = type;
        }

        #endregion

        #region Methods

        public void Initialize()
        {
            if (!IsInitialized)
            {
                var firstChild = ChildConfigs.FirstOrDefault(x => x.Name == SubType);
                if (firstChild != null)
                {
                    foreach (var child in firstChild.Children)
                    {
                        MakeChildren(child);
                    }
                }

                IsInitialized = true;
            }
        }

        public void MakeChildren(IMatter child)
        {
            if (child.Min == 1 && child.Max == 1)
            {
                var childType = Choose(child.Classes);
                if (childType != null)
                {
                    var newChild = Activator.CreateInstance(System.Type.GetType(childType)) as IMatter;
                    newChild.Parent = this;

                    Children.Add(newChild);
                }
            }
            else
            {
                var total = Random.Next(child.Min, child.Max);

                if (total != 0)
                {
                    for (var x = 0; x <= total; x++)
                    {
                        var childType = Choose(child.Classes);
                        if (childType != null)
                        {
                            var newChild = Activator.CreateInstance(System.Type.GetType(Choose(child.Classes))) as IMatter;
                            newChild.Parent = this;

                            Children.Add(newChild);
                        }
                    }
                }
            }
        }

        protected T Choose<T>(Dictionary<T, double> choices)
        {
            var newChoices = new List<T>();

            foreach (var choice in choices)
            {
                // TODO: Figure out why this "magic number" of 10 exists?
                for (var x = 0; x < choice.Value * 10; x++)
                {
                    newChoices.Add(choice.Key);
                }
            }

            return newChoices[Random.Next(0, newChoices.Count - 1)];
        }

        #endregion

        #region Properties

        public IList<IMatter> Children
        {
            get { return _children; }
            set { _children = value; }
        }

        public bool IsInitialized { get; set; }

        public string Name { get; set; }

        public IMatter Parent { get; set; }

        public IDictionary<string, string> Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public string SubType { get; set; }

        public string Type { get; set; }

        #endregion
    }
}
