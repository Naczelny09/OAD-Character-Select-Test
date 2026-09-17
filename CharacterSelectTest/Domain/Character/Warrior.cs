using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;
using System.Runtime.ConstrainedExecution;

namespace CharacterSelectTest.Domain.Character;

public sealed class Warrior : Entity.Character
{
    public Warrior(string name) : base(name, CharacterClass.Warrior)
    {
        Health = 120;
        Strength = 14;
        Intelligence = 6;
        Agility = 8;
        Crit_rate = 50;
        Crit_DMG = 30;
    }

    public double Attak()
    {
        return Math.Round((Strength + Health) * 1.5, 1);
    }
    public string SpecialAbility()
    {
        return "After landing a critical hit boots his agility by 10 %";
    }
}