using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class RogueTests
    {
        [TestMethod]
        public void Creation_HasCorrectName()
        {
            var rogue = new Rogue("Zed");

            Assert.AreEqual("Zed", rogue.Name);
        }

        [TestMethod]
        public void Creation_HasCorrectBaseStats()
        {
            var rogue = new Rogue("Zed");

            Assert.AreEqual(95, rogue.Health);
            Assert.AreEqual(9, rogue.Strength);
            Assert.AreEqual(8, rogue.Intelligence);
            Assert.AreEqual(15, rogue.Agility);
            Assert.AreEqual(20, rogue.Crit_rate);
            Assert.AreEqual(100, rogue.Crit_DMG);
        }

        [TestMethod]
        public void Attak_ReturnsCorrectValue()
        {
            var rogue = new Rogue("Zed");

            double actualAttack = rogue.Attack();

            Assert.AreEqual(27.6, actualAttack);
        }

        [TestMethod]
        public void SpecialAbility_ReturnsCorrectMessage()
        {
            var rogue = new Rogue("Zed");
            string expectedMessage = "Rouge steals some of the enemies health ";

            string actualMessage = rogue.SpecialAbility();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}