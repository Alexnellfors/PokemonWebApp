using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Poke_Connector.Models.Dtos
{
    public class PokemonDbDto
    {
        public string? DateTime { get; set; }
        public string? Image { get; set; }
        [JsonPropertyName("id")] public long Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; } = "";
    }
}
