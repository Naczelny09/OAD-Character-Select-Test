using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Healer : Entity.Character
{
    public Healer(string name) : base(name, CharacterClass.Healer)
    {
        Health = 150;
        Strength = 1;
        Intelligence = 25;
        Agility = 5;
        Crit_rate = 00;
        Crit_DMG = 00;
    }
    public double Attak()
    {
        return Math.Round((Health + Intelligence)*1.5 , 1);
    }
    public string SpecialAbility()
    {
        return "Healer heals your team for 50% his own health";
    }
}