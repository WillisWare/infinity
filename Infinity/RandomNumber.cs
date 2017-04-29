using System;

namespace Infinity
{
    public sealed class RandomNumber
    {
        #region Members

        private readonly Random _random;

        private static RandomNumber _instance;

        #endregion

        #region Constructors

        private RandomNumber()
        {
            _random = new Random();
        }

        #endregion

        #region Methods

        public int Next(int min, int max)
        {
            return _random.Next(min, max);
        }

        #endregion

        #region Properties

        public static RandomNumber Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RandomNumber();
                }
                return _instance;
            }
        }

        #endregion
    }
}
