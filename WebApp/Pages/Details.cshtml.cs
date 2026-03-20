using Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PartyKing.Pages
{
    public class DetailsModel : AddPageModel
    {
        public string? Message { get; set; }
        public DetailsModel(LogicService service, DatabaseService databaseService, IConfiguration configuration) : base(service, databaseService, configuration)
        {
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var pokemon = await _service.GetSpecificPokeAsync(id);
            Pokemon = pokemon;
            return Page();
        }
        public async Task<IActionResult> OnPostFetchAbilities(string abilityName)
        {
            var ability = await _service.GetAbilityFromPoke(abilityName);
            Ability = ability;
            return Page();
        }
    }
}
