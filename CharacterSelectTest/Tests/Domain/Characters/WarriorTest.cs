using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class WarriorTests
    {
        [TestMethod]
        public void Creation_HasCorrectName()
        {
            var warrior = new Warrior("Garen");

            Assert.AreEqual("Garen", warrior.Name);
        }

        [TestMethod]
        public void Creation_HasCorrectBaseStats()
        {
            var warrior = new Warrior("Garen");

            Assert.AreEqual(120, warrior.Health);
            Assert.AreEqual(14, warrior.Strength);
            Assert.AreEqual(6, warrior.Intelligence);
            Assert.AreEqual(8, warrior.Agility);
            Assert.AreEqual(50, warrior.Crit_rate);
            Assert.AreEqual(30, warrior.Crit_DMG);
        }

        [TestMethod]
        public void Attak_ReturnsCorrectValue()
        {
            var warrior = new Warrior("Garen");

            double actualAttack = warrior.Attack();

            Assert.AreEqual(201, actualAttack);
        }

        [TestMethod]
        public void SpecialAbility_ReturnsCorrectMessage()
        {
            var warrior = new Warrior("Garen");
            string expectedMessage = "After landing a critical hit boots his agility by 10 %";

            string actualMessage = warrior.SpecialAbility();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}