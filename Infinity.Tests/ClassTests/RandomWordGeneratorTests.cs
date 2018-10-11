using NUnit.Framework;
using WillisWare.Infinity.Classes.Generators;

namespace WillisWare.Infinity.Tests.ClassTests
{
    [TestFixture]
    public class RandomWordGeneratorTests
    {
        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void VariableSyllableWords_HaveValues(int syllables)
        {
            var word = RandomWordGenerator.Word(syllables);

            Assert.IsNotNull(word);
        }
    }
}
