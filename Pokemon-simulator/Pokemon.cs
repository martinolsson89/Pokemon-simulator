namespace Pokemon_simulator;

public abstract class Pokemon
{
    private string _name = string.Empty;
    private int _level;
    private readonly List<Attack> _attacks;

    public string Name
    {
        get => _name;
        protected set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 15)
                throw new ArgumentException("Name must be 2–15 characters.");

            _name = value.Trim();
        }
    }
    public int Level
    {
        get => _level;
        protected set
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(nameof(Level), "Level must be ≥ 1.");

            _level = value;
        }
    }

    public ElementType Type { get; protected set; }

    protected Pokemon(string name, int level, IEnumerable<Attack> attacks)
    {
        ArgumentNullException.ThrowIfNull(attacks);

        _attacks = attacks.ToList();

        if (_attacks.Count == 0)
            throw new ArgumentException("A Pokémon must know at least one attack.", nameof(attacks));

        Name = name;
        Level = level;
    }

    public void RandomAttack()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _attacks.Count);
        var attack = _attacks[index];

        Console.Write($"{Name} used: ");
        attack.Use(Level);
    }

    public virtual void Attack()
    {
        Console.WriteLine($"\nChoose an attack for {Name}:");
        for (int i = 0; i < _attacks.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_attacks[i].Name} ({_attacks[i].Type}, {_attacks[i].BasePower} base)");
        }

        while (true)
        {
            Console.Write("Enter number: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                int index = choice - 1;
                if (index >= 0 && index < _attacks.Count)
                {
                    var selected = _attacks[index];
                    Console.Write($"\n{Name} used ");
                    selected.Use(Level);
                    break;
                }
            }

            Console.WriteLine("Invalid choice. Try again.");
        }
    }

    public void RaiseLevel()
    {
        Level += 1;
        Console.WriteLine($"{Name} leveled up to {Level}!\n");
    }

}




