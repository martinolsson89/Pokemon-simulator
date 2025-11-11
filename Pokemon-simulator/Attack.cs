namespace Pokemon_simulator;

public class Attack
{
    public string Name { get; init; }
    public ElementType Type { get; init; }
    public int BasePower { get; init; }

    public Attack(string name, ElementType type, int basePower)
    {
        Name = name;
        Type = type;
        BasePower = basePower;
    }


    public void Use(int level)
    {
        // TODO: Den ska skriva ut ett meddelande till konsolen som t.ex.:
        // Flamethrower hit with a total power of 13
        // Där 13 är BasePower + level
    }
}
