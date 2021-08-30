using System.Collections.Generic;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private readonly List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
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
            Pokemon pokemon = _pokemonTeam[teamPosition];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition];
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
            foreach (Pokemon pokemon in _pokemonTeam)
            {
                if (nickName == pokemon.PokemonNickName)
                {
                    pokemon.PokemonNickName = newPokemon.PokemonNickName;
                }
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
