namespace Pokemon_simulator;

public class Charmander : FirePokemon, IEvolvable
{
    public Charmander(string name, int level, IEnumerable<Attack> attacks)
        : base(name, level, attacks)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"[{GetType().Name}] Attack override executed.");
        RandomAttack();
    }

    public void Evolve()
    {
        var old = Name;
        Level += 10;
        Name = "Charmeleon";
        Console.WriteLine($"{old} is evolving... Now it is a {Name} and its level is {Level}\n");
    }
}