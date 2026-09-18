using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class MageTests
    {
        [TestMethod]
        public void Creation_HasCorrectName()
        {
            var mage = new Mage("Ryze");

            Assert.AreEqual("Ryze", mage.Name);
        }

        [TestMethod]
        public void Creation_HasCorrectBaseStats()
        {
            var mage = new Mage("Ryze");

            Assert.AreEqual(80, mage.Health);
            Assert.AreEqual(4, mage.Strength);
            Assert.AreEqual(16, mage.Intelligence);
            Assert.AreEqual(10, mage.Agility);
            Assert.AreEqual(100, mage.Crit_rate);
            Assert.AreEqual(10, mage.Crit_DMG);
        }

        [TestMethod]
        public void Attak_ReturnsCorrectValue()
        {
            var mage = new Mage("Ryze");

            double actualAttack = mage.Attack();

            Assert.AreEqual(48, actualAttack);
        }

        [TestMethod]
        public void SpecialAbility_ReturnsCorrectMessage()
        {
            var mage = new Mage("Ryze");
            string expectedMessage = "Mage boosts other allies Crit_Rate";

            string actualMessage = mage.SpecialAbility();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}