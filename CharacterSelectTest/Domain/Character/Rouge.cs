using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Crit_rate = 20;
        Crit_DMG = 100;
    }
    public int Attack()
    {
        return Agility * 3;
    }
    public string SpecialAbility()
    {
        return "Rouge steals some of the enemies health ";
    }
}