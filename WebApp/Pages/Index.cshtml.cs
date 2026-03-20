using Logic.Services;
using Logic.Translators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PartyKing.Pages;
using Poke_Connector.Models;
using Poke_Connector.Models.Dtos;
using System.Runtime.CompilerServices;

public class IndexModel : AddPageModel
{
    public IndexModel(LogicService service, DatabaseService databaseService, IConfiguration configuration) : base(service, databaseService, configuration)
    {
    }

    public async Task<IActionResult?> OnPostFetchAllAsync()
    {
        var all = await _databaseService.FetchFromDatabase();

        if (all != null)
        {
            var pokemons = PokemonTranslator.FromPokeDbToApi(all);
            Pokemons = pokemons;
            return Page();
        }
        return null;
    }
    public async Task<IActionResult?> OnPostFetchDetailsAsync(int pokemonId)
    {
        return RedirectToPage("Details", new {id = pokemonId });
    }
    public async Task<IActionResult?> OnPostCatchPokemonAsync()
    {
        var result = await _service.GetRandomPokeAsync();

        if (result != null)
        {
            CatchDate = DateTime.Now.ToString();
            //Check if we already have this pokémon in pokéindex.
            var pokemons = _databaseService.GetPokemonsByNameAsync(result.Name);

            if (pokemons != null && pokemons?.Result?.Count > 0)
            {
                AlreadyExists = true;
            }
            else
            {
                AlreadyExists = false;
            }

            Pokemon = result;
            return Page();
        }
        return null;
    }
    public async Task<IActionResult> OnPostAddToIndexAsync(string pokemonName, string pokemonUrl, string pokemonDateTime, int pokemonId)
    {
        try
        {
            var pokemon = new PokemonDbDto
            {
                Name = pokemonName,
                Id = pokemonId,
                DateTime = pokemonDateTime,
                Image = pokemonUrl
            };

            //Add to pokéIndex
            await _databaseService.AddToDatabase(pokemon);

            TempData["Message"] = $"{pokemonName} added to your PokéIndex!";
        }
        catch (Exception ex)
        {
            TempData["Message"] = $"Error adding Pokémon: {ex.Message}";
        }

        return RedirectToPage(); 
    }
    public async Task<IActionResult> OnPostSkipAddAsync(string pokemonName)
    {
        TempData["Message"] = $"Bye {pokemonName}!";
        return RedirectToPage();
    }
}
