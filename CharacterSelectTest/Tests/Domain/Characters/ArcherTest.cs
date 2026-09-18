using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class ArcherTests
    {
        [TestMethod]
        public void Creation_HasCorrectName()
        {
            var archer = new Archer("Legolas");

            Assert.AreEqual("Legolas", archer.Name);
        }

        [TestMethod]
        public void Creation_HasCorrectBaseStats()
        {
            var archer = new Archer("Legolas");

            Assert.AreEqual(50, archer.Health);
            Assert.AreEqual(5, archer.Strength);
            Assert.AreEqual(20, archer.Intelligence);
            Assert.AreEqual(7, archer.Agility);
        }

        [TestMethod]
        public void Creation_HasCorrectAdditionalStats()
        {
            var archer = new Archer("Legolas");

            Assert.AreEqual(15, archer.Crit_rate);
            Assert.AreEqual(100, archer.Crit_DMG);
        }

        [TestMethod]
        public void Attak_ReturnsCorrectValue()
        {
            var archer = new Archer("Legolas");

            double actualAttack = archer.Attack();

            Assert.AreEqual(300, actualAttack);
        }

        [TestMethod]
        public void SpecialAbility_ReturnsCorrectMessage()
        {
            var archer = new Archer("Legolas");
            string expectedMessage = "Archer bardges enemies with arrows ";
            string actualMessage = archer.SpecialAbility();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}