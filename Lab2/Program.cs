using System.Text.Json;
using Lab2;

var Pokemon = PokemonUtils.GetPokemonDataAsync("Pikachu").Result;
Pokemon myPokemon = JsonSerializer.Deserialize<Pokemon>(Pokemon);
Console.WriteLine(myPokemon.name);
