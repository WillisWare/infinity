using System;

namespace WillisWare.Infinity.Classes
{
    /// <summary>
    /// Singleton random number generator class.
    /// Eliminates the need for any class in this project to instantiate <see cref="Random"/> and invoke the Next() method.
    /// Because only one instance of this class can exist, it guarantees true random numbers every time.
    /// </summary>
    public sealed class RandomNumber
    {
        #region Members

        private readonly Random _random;

        private static RandomNumber _instance;

        #endregion

        #region Constructors

        /// <summary>
        /// Default, hidden constructor. Initializes a single instance of this class via the "Instance" property.
        /// </summary>
        private RandomNumber()
        {
            _random = new Random();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a new random number.
        /// </summary>
        /// <param name="min">An <see cref="long"/> value specifying the smallest number that can be generated.</param>
        /// <param name="max">An <see cref="long"/> value specifying the largest number that can be generated.</param>
        /// <returns>An <see cref="long"/> value containing the randomly generated number.</returns>
        public long Next(long min, long max)
        {
            return _random.Next((int)min, (int)max);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Singleton pattern. Gets the one allowed instance of this class.
        /// </summary>
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
