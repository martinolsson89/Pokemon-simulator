
namespace Pokemon_simulator;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Seeda data
            IEnumerable<Attack> attacks = DataSeeder.SeedAttacks();
            List<Pokemon> pokemons = DataSeeder.SeedPokemons(attacks);

            Console.WriteLine("=== Available Attacks ===\n");
            foreach (var attack in attacks)
            {
                Console.WriteLine($"{attack.Name} (Type: {attack.Type}, Basepower: {attack.BasePower})");
            }
            Console.WriteLine();
            Console.WriteLine("=== Your Pokémon Team ===\n");
            foreach (var p in pokemons)
            {
                Console.WriteLine($"{p.Name} (Level: {p.Level}, Type: {p.Type})");
            }


            Console.WriteLine("=== Simulating traning ===\n");
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"{pokemon.Name} (Level: {pokemon.Level}, Type: {pokemon.Type})");
                pokemon.RaiseLevel();
                pokemon.Attack();
                pokemon.RandomAttack();

                if (pokemon is IEvolvable evolver)
                {
                    evolver.Evolve();
                }

                // Special method just for Bulbasaur class using cast.
                if(pokemon is Bulbasaur bulbasaur)
                    bulbasaur.Eating();
            }

        }
        catch (ArgumentException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error creating Pokémon: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}





