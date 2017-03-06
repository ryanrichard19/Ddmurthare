using NUnit.Framework;

namespace PeriodicTableChecker.Library.Tests
{
    [TestFixture]
    public class ElementTests
    {
        [TestCase("Boron", "B", ExpectedResult =  false)]
        [TestCase("Mercury", "Cy", ExpectedResult = true)]
        [TestCase("Mercury", "Hg", ExpectedResult = false)]
        [TestCase("Silver", "Vr", ExpectedResult = true)]
        [TestCase("Silver", "Rv", ExpectedResult = false)]
        [TestCase("Magnesium", "Ma", ExpectedResult = true)]
        [TestCase("Magnesium", "Am", ExpectedResult = true)]
        public bool TestCases(string Name, string Symbol)
        {
            Element e = new Element(Name, Symbol);
            return e.CheckElementRule();
        }

    }
}
