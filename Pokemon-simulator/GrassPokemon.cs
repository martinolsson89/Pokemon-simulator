namespace Pokemon_simulator;

public abstract class GrassPokemon : Pokemon
{
    protected GrassPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Grass;
    }

}





