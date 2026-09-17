using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

public sealed class Summoner : Entity.Character
{
    public Summoner(string name) : base(name, CharacterClass.Summoner)
    {
        Health = 30;
        Strength = 2;
        Intelligence = 15;
        Agility = 8;
        Crit_rate = 01;
        Crit_DMG = 100;
    }
}