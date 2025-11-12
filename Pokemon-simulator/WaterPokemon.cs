namespace Pokemon_simulator;

public abstract class WaterPokemon : Pokemon
{
    protected WaterPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Water;
    }

}





