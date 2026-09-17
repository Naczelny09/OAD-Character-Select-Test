using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 50;
        Strength = 5;
        Intelligence = 20;
        Agility = 7;
        Crit_rate = 15;
        Crit_DMG = 100;
    }
}