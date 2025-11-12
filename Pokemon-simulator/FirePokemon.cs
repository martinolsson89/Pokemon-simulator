namespace Pokemon_simulator;

public abstract class FirePokemon : Pokemon
{
    protected FirePokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Fire;
    }
}





