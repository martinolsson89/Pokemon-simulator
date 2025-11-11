namespace Pokemon_simulator;

public abstract class Pokemon
{
    private string _name;
    private int _level;
    protected readonly List<Attack> Attacks;

    public string Name
    {
        get => _name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 15)
                throw new ArgumentException("Namnet måste vara 2-15 tecken.");

            _name = value.Trim();
        }
    }
    public int Level
    {
        get => _level;
        private set
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(nameof(Level), "Level måste vara ≥ 1.");

            _level = value;
        }
    }

    public ElementType Type { get; protected set; }

    protected Pokemon(string name, int level, List<Attack> attacks)
    {
        Attacks = attacks ?? throw new ArgumentNullException(nameof(attacks), "Attacks-listan får inte vara null.");
        if (!Attacks.Any())
            throw new ArgumentException("En Pokémon måste känna till minst en attack.", nameof(attacks));

        Name = name;
        Level = level;
    }

    public void RandomAttack()
    {

    }

    public void Attack()
    {

    }

    public void RaiseLevel()
    {

    }

}




