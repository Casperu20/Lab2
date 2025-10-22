namespace Lab2;

public class BattleSimulator : IBattleSimulator
{
    public bool TryFindStrongestStat(Pokemon pokemon, out string statName, out int statValue)
    {
        statName = string.Empty; 
        statValue = 0;
        
        if (pokemon == null || pokemon.stats == null || pokemon.stats.Length == 0) {
             return false;
        }
        // int maxValue = (int) pokemon.stats[0].base_stat;
        // string maxName = pokemon.stats[0].stat.name;
        
        foreach (Stat stat in pokemon.stats)
        {
            if (stat.base_stat > statValue)
            {
                statValue = (int) stat.base_stat;
                statName = stat.stat.name;

            }
        }
        return true;
    }

    public void SimulateAttack(ref Pokemon attacker, ref Pokemon defender)
    {
        if (attacker == null || defender == null) {
            return;
        }

        int attack = (int) attacker.stats[1].base_stat;
        int def = (int) defender.stats[2].base_stat;

        int damage = Math.Max(1, attack - def); // 
        defender.stats[0].base_stat = (uint) Math.Max(0, defender.stats[0].base_stat - damage);
        
        Console.WriteLine($"Attacker {attacker.name} attacks: {defender.name} for {damage} damage! Remaining hp: {defender.stats[0].base_stat}");
    }

    public double CalculateAverageStat(string statName, params Pokemon[] pokemonTeam)
    {
        if (pokemonTeam == null || pokemonTeam.Length == 0) {
            return 0;
        }

        int total = 0;
        int count = 0;

        foreach (var p in pokemonTeam)
        {
            if (p == null) {
                continue;
            }

            foreach (Stat stat in p.stats) {
               total += (int )stat.base_stat; 
            }
            // total += (int) p.stats[p.stats.Length - 1].base_stat;
            count++;
        }
        
        return total / count;
    }
}