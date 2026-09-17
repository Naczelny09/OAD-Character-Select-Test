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
    }
}