using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTableChecker.Library.Tests
{
    [TestFixture]
    public class ElementTests
    {
        [Test]
        public void Element_Boron_Symbol_B()
        {
            string input1 = "Boron";
            string input2 = "B";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, false);
        }
        [Test]
        public void Element_Mercury_Symbol_Cy()
        {
            string input1 = "Mercury";
            string input2 = "Cy";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, true);
        }
        [Test]
        public void Element_Mercury_Symbol_Hg()
        {
            string input1 = "Mercury";
            string input2 = "Hg";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, false);
        }

        [Test]
        public void Element_Silver_Symbol_Vr()
        {
            string input1 = "Silver";
            string input2 = "Vr";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, true);
        }
        [Test]
        public void Element_Silver_Symbol_Rv()
        {
            string input1 = "Silver";
            string input2 = "Rv";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, false);
        }
        [Test]
        public void Element_Magnesium_Symbol_Ma()
        {
            string input1 = "Magnesium";
            string input2 = "Ma";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, true);
        }
        [Test]
        public void Element_Magnesium_Symbol_Am()
        {
            string input1 = "Magnesium";
            string input2 = "Am";
            Element e = new Element(input1, input2);
            bool output = e.CheckElementRule();
            Assert.AreEqual(output, true);
        }





    }
}
