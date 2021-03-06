﻿using System;

namespace WillisWare.Infinity.Classes.Attributes
{
    public sealed class MaxChildrenAttribute : Attribute
    {
        #region Constructors

        public MaxChildrenAttribute(int maxValue)
        {
            Value = maxValue;
        }

        #endregion

        #region Properties

        public int Value { get; set; }

        #endregion
    }
}
