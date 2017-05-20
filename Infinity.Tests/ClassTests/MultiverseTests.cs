using NUnit.Framework;
using WillisWare.Infinity.Classes.Objects;

namespace WillisWare.Infinity.Tests.ClassTests
{
    /// <summary>
    /// Fixture for unit testing the entity classes for the Infinity game.
    /// </summary>
    [TestFixture]
    public sealed class MultiverseTests
    {
        #region Test Methods

        /// <summary>
        /// Tests the ability of the <see cref="Multiverse"/> class to initialize without error.
        /// </summary>
        [Test]
        public void New_Multiverse_Will_Initialize()
        {
            var multiverse = new Multiverse();

            Assert.IsNotNull(multiverse);
            Assert.DoesNotThrow(() => multiverse.Initialize());
            Assert.IsNotNull(multiverse.Children);
            Assert.IsNotEmpty(multiverse.Children);
        }

        #endregion

        #region Support Methods

        #endregion
    }
}
