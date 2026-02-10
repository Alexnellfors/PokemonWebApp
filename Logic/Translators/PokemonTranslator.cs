using Poke_Connector.Models.Dtos;
using Poke_Connector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Translators
{
    public static class PokemonTranslator
    {
        public static PokemonDbDto FromPokeApiToDatabase(PokemonModel pokemon)
        {
            return new PokemonDbDto
            {
                Name = pokemon.Name,
                Id = pokemon.Id
            };
        }
        public static List<PokemonModel> FromPokeDbToApi(List<PokemonDbDto> pokemons)
        {
            List<PokemonModel> pokeList = new List<PokemonModel>();
            foreach (var pokemon in pokemons)
            {
                var poke = new PokemonModel
                {
                    Name = pokemon.Name,
                    Id = pokemon.Id,
                    Image = pokemon.Image

                };
                pokeList.Add(poke);
            }
            return pokeList;
        }
    }
}
