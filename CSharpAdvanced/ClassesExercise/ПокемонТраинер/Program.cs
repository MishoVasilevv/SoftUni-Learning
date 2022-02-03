using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Trainer currentTrainer = new Trainer(trainerName);
                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, currentTrainer);

                    currentTrainer.PokemonCollection.Add(currentPokemon);
                }
                else
                {
                    trainers[trainerName].PokemonCollection.Add(currentPokemon);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    int i = 0;

                    foreach (var pokemon in trainer.Value.PokemonCollection)
                    {
                        if (pokemon.Element == command)
                        {
                            trainer.Value.NumberOfBadges++;
                            i++;
                            break;
                        }
                    }

                    if (i > 0)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = 0; j < trainer.Value.PokemonCollection.Count; j++)
                        {
                            trainer.Value.PokemonCollection[j].Health -= 10;

                            if (trainer.Value.PokemonCollection[j].Health <= 0)
                            {
                                trainer.Value.PokemonCollection.Remove(trainer.Value.PokemonCollection[j]);
                            }
                        }
                    }

                }

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                //"{trainerName} {badges} {numberOfPokemon}"
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.PokemonCollection.Count}");
            }
        }
    }
}
