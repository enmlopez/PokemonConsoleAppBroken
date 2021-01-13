using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam (Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];

            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.Level = updates.Level;
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne;
            pokemon.MoveTwo = updates.MoveTwo;
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour;
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            foreach(Pokemon oldPokemon in _pokemonTeam)
            {
                if(nickName == oldPokemon.PokemonNickName)
                {
                    oldPokemon.PokemonNickName = newPokemon.PokemonNickName;
                    oldPokemon.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                    oldPokemon.Level = newPokemon.Level;
                    oldPokemon.PokemonType = newPokemon.PokemonType;
                    oldPokemon.SecondaryType = newPokemon.SecondaryType;
                    oldPokemon.MoveOne = newPokemon.MoveOne;
                    oldPokemon.MoveTwo = newPokemon.MoveTwo;
                    oldPokemon.MoveThree = newPokemon.MoveThree;
                    oldPokemon.MoveFour = newPokemon.MoveFour;

                }
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
