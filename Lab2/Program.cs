using System.Text.Json;
using Lab2;

var Pokemon = PokemonUtils.GetPokemonDataAsync("Pikachu").Result;
Pokemon myPokemon = JsonSerializer.Deserialize<Pokemon>(Pokemon);

var charizard = PokemonUtils.GetPokemonDataAsync("charizard").Result;
Pokemon myCharizard = JsonSerializer.Deserialize<Pokemon>(charizard);

// Console.WriteLine(myPokemon.name);
// Console.WriteLine("weight is: " + myPokemon.weight);
// Console.WriteLine(myPokemon.held_items);

BattleSimulator Simulator = new BattleSimulator();
string stat = "";
int value = 0;

Simulator.TryFindStrongestStat(myPokemon, out stat, out value);
Console.WriteLine($"Stat: {stat} - Value: {value}\n");

Simulator.SimulateAttack(ref myCharizard, ref myPokemon);
Simulator.SimulateAttack(ref myPokemon, ref myCharizard);

double average_attack = Simulator.CalculateAverageStat("attack", myPokemon, myCharizard);
Console.WriteLine($"\nAverage attack is: {average_attack}");


