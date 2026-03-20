using Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Poke_Connector.Models;

namespace PartyKing.Pages
{
    public abstract class AddPageModel : PageModel
    {
        protected LogicService _service;
        protected DatabaseService _databaseService;
        protected IConfiguration _configuration;
        public AddPageModel(LogicService service, DatabaseService databaseService, IConfiguration configuration)
        {
            _service = service;
            _databaseService = databaseService;
            _configuration = configuration;
        }
        public List<PokemonModel>? Pokemons { get;  set; }
        public PokemonModel? Pokemon { get;  set; }
        public AbilitiesModel? Ability { get; set; }
        public bool AlreadyExists { get;  set; }
        public string CatchDate { get;  set; }
    }
}
