﻿using System;
using System.Collections.Generic;
using System.Linq;
using Infinity.Attributes;
using Infinity.Generators;
using Infinity.Interfaces;

namespace Infinity.Fundamentals
{
    public abstract class Matter : IMatter
    {
        #region Constructors

        protected Matter()
        {
            Name = RandomWordGenerator.Word();
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

        #endregion

        #region Properties

        public IList<IMatter> Children { get; set; } = new List<IMatter>();

        public bool IsInitialized { get; set; }

        public string Name { get; set; }

        public IMatter Parent { get; set; }

        public IDictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();

        public string Type { get; set; }

        #endregion
    }
}
