namespace Pokemon_simulator;

public class Program
{
    static void Main(string[] args)
    {
        Attack flametrower = new Attack("flamethrower", ElementType.Fire, 12);
        Attack ember = new Attack("Ember", ElementType.Fire, 6);
    }
}

public abstract class FirePokemon : Pokemon
{
    protected FirePokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Fire;
    }
}

public abstract class WaterPokemon : Pokemon
{
    protected WaterPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Water;
    }

}

public abstract class GrassPokemon : Pokemon
{
    protected GrassPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Grass;
    }

}





