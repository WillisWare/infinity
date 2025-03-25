using NUnit.Framework;
using NUnit.Framework.Legacy;
using WillisWare.Infinity.Classes.Objects;

namespace WillisWare.Infinity.Tests.ClassTests
{
    /// <summary>
    /// Fixture for unit testing the entity classes for the Infinity game.
    /// </summary>
    [TestFixture]
    public sealed class MatterTests
    {
        #region Test Methods

        /// <summary>
        /// Tests the ability of the <see cref="Multiverse"/> class to initialize without error.
        /// </summary>
        [Test]
        public void New_Multiverse_Will_Initialize()
        {
            var multiverse = new Multiverse();

            ClassicAssert.IsNotNull(multiverse);
            Assert.DoesNotThrow(() => multiverse.Initialize());
            ClassicAssert.IsNotNull(multiverse.Children);
            ClassicAssert.IsNotEmpty(multiverse.Children);
        }

        #endregion

        #region Support Methods

        #endregion
    }
}
