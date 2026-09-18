using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Mage : Entity.Character
{
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Crit_rate = 100;
        Crit_DMG = 10;
    }
    public int Attack()
    {
        return Intelligence * 3;
    }
    public string SpecialAbility()
    {
        return "Mage boosts other allies Crit_Rate";
    }
}