using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class HealerTests
    {
        [TestMethod]
        public void Creation_HasCorrectName()
        {
            var healer = new Healer("Soraka");

            Assert.AreEqual("Soraka", healer.Name);
        }

        [TestMethod]
        public void Creation_HasCorrectBaseStats()
        {
            var healer = new Healer("Soraka");

            Assert.AreEqual(150, healer.Health);
            Assert.AreEqual(1, healer.Strength);
            Assert.AreEqual(25, healer.Intelligence);
            Assert.AreEqual(5, healer.Agility);
            Assert.AreEqual(0, healer.Crit_rate);
            Assert.AreEqual(0, healer.Crit_DMG);
        }

        [TestMethod]
        public void Attak_ReturnsCorrectValue()
        {
            var healer = new Healer("Soraka");

            double actualAttack = healer.Attack();

            Assert.AreEqual(262.5, actualAttack);
        }

        [TestMethod]
        public void SpecialAbility_ReturnsCorrectMessage()
        {
            var healer = new Healer("Soraka");
            string expectedMessage = "Healer heals your team for 50% his own health";

            string actualMessage = healer.SpecialAbility();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}