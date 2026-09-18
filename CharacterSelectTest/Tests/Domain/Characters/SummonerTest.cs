using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Characters
{
    [TestClass]
    public class SummonerTests
    {
        [TestMethod]
        public void Creation_HasCorrectName()
        {
            var summoner = new Summoner("Yorick");

            Assert.AreEqual("Yorick", summoner.Name);
        }

        [TestMethod]
        public void Creation_HasCorrectBaseStats()
        {
            var summoner = new Summoner("Yorick");

            Assert.AreEqual(30, summoner.Health);
            Assert.AreEqual(2, summoner.Strength);
            Assert.AreEqual(15, summoner.Intelligence);
            Assert.AreEqual(8, summoner.Agility);
            Assert.AreEqual(15, summoner.Crit_rate);
            Assert.AreEqual(100, summoner.Crit_DMG);
        }

        [TestMethod]
        public void Attak_ReturnsCorrectValue()
        {
            var summoner = new Summoner("Yorick");

            double actualAttack = summoner.Attack();

            Assert.AreEqual(20.4, actualAttack);
        }

        [TestMethod]
        public void SpecialAbility_ReturnsCorrectMessage()
        {
            var summoner = new Summoner("Yorick");
            string expectedMessage = "Summoner summons 5 bats that attacks enemies";

            string actualMessage = summoner.SpecialAbility();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
};