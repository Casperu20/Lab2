using System.Text.Json;
using Lab2;

var Pokemon = PokemonUtils.GetPokemonDataAsync("pikachu").Result;
Pokemon myPokemon = JsonSerializer.Deserialize<Pokemon>(Pokemon); // StandardPokemon

var charizard = PokemonUtils.GetPokemonDataAsync("mewtwo").Result;
Pokemon myCharizard = JsonSerializer.Deserialize<Pokemon>(charizard);

// Console.WriteLine(myPokemon.name);
// Console.WriteLine("weight is: " + myPokemon.weight);
// Console.WriteLine(myPokemon.held_items);

/*
BattleSimulator Simulator = new BattleSimulator();
string stat = "";
int value = 0;

Simulator.TryFindStrongestStat(myPokemon, out stat, out value);
Console.WriteLine($"Stat: {stat} - Value: {value}\n");

Simulator.SimulateAttack(ref myCharizard, ref myPokemon);
Simulator.SimulateAttack(ref myPokemon, ref myCharizard);

double average_attack = Simulator.CalculateAverageStat("attack", myPokemon, myCharizard);
Console.WriteLine($"\nAverage attack is: {average_attack}");
*/
// LAB 4 PART

Console.WriteLine($"\n ---- Pokemon Evolution ---- ");

var pikachuSpecies = PokemonSpeciesHelper.GetSpeciesDataAsync(myPokemon.species.url).Result;
var mewtwoSpecies = PokemonSpeciesHelper.GetSpeciesDataAsync(myCharizard.species.url).Result;

BasePokemon pika;

if (pikachuSpecies != null && (pikachuSpecies.IsLegendary || pikachuSpecies.IsMythical))
{
    pika = new LegendaryPokemon
    {
        Id = myPokemon.id,
        Name = myPokemon.name,
        Weight = myPokemon.weight,
        Height = myPokemon.height,
        BaseExperience = myPokemon.base_experience
    };
}
else
{
    pika = new StandardPokemon
    {
        Id = myPokemon.id,
        Name = myPokemon.name,
        Weight = myPokemon.weight,
        Height = myPokemon.height,
        BaseExperience = myPokemon.base_experience
    };
}

BasePokemon mewtwo;

if (mewtwoSpecies != null && (mewtwoSpecies.IsLegendary || mewtwoSpecies.IsMythical))
{
    mewtwo = new LegendaryPokemon
    {
        Id = myCharizard.id,
        Name = myCharizard.name,
        Weight = myCharizard.weight,
        Height = myCharizard.height,
        BaseExperience = myCharizard.base_experience,
        SpecialType = "CRAZY_PIKA"
    };
}
else
{
    mewtwo = new StandardPokemon
    {
        Id = myCharizard.id,
        Name = myCharizard.name,
        Weight = myCharizard.weight,
        Height = myCharizard.height,
        BaseExperience = myCharizard.base_experience,
    };
}

List<BasePokemon> pokedex = new List<BasePokemon>();
pokedex.Add(pika);
pokedex.Add(mewtwo);

foreach (var pokemon in pokedex)
{
    pokemon.DisplayInfo();
}