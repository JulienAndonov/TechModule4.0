using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Evolution>> pokemons = new Dictionary<string, List<Evolution>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string pokemonName = tokens[0];

                if (tokens.Length >= 2)
                {
                    
                    string evolutionType = tokens[1];
                    int evolutionIndex = int.Parse(tokens[2]);
                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Evolution>();
                    }

                    pokemons[pokemonName].Add(new Evolution
                    {
                        Index = evolutionIndex,
                        Type = evolutionType
                    });

                }
                else
                {
                    printPokemons(pokemons,pokemonName);
                }
            }


            printPokemons(pokemons);
        }

        public static void printPokemons(Dictionary<string, List<Evolution>> pokemons)
        {
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                Console.WriteLine(String.Join(Environment.NewLine, pokemon.Value
                    .OrderByDescending(b => b.Index)
                    .Select(a => $"{a.Type} <-> {a.Index}")));
            }
        }

        public static void printPokemons(Dictionary<string, List<Evolution>> pokemons,string pokemonName)
        {
            foreach (var pokemon in pokemons.Where(x => x.Key == pokemonName))
            {
                Console.WriteLine($"# {pokemon.Key}");
                Console.WriteLine(String.Join(Environment.NewLine, pokemon.Value.
                    Select(a => $"{a.Type} <-> {a.Index}")));
            }
        }

    }


    class Evolution
    {
        public string Type { get; set; }
        public int Index { get; set; }


    }
}
