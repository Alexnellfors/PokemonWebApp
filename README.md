# 🎉 PokemonWebApp

A Pokémon-inspired web application built with **ASP.NET Core Razor Pages** and **Entity Framework Core (SQLite)**.  

---

## 🧰 Requirements

Before running the project, make sure you have:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio or VS Code
- SQLite database viewer (optional, e.g. [DB Browser for SQLite](https://sqlitebrowser.org/))

---

## 🚀 How to Run the Project

- Clone or download this repository

   ```bash
   git clone https://github.com/Alexnellfors/PokemonWebApp.git
    or just download the ZIP and extract it.

- Open the solution in Visual Studio (PokemonWebApp.sln).

- Check the database

    Inside the PokemonWebApp/ folder, there’s a .db file (SQLite).
    You can open it in any SQLite browser if you want to inspect the raw data.

- Verify the configuration

    Open appsettings.json and make sure these values are correct:
  ```bash
  "PokeConfig": {
    "BaseUrl": "https://pokeapi.co/api/v2/",
    "TimeoutSeconds": 30
  },
  "Database": {
    "Connectionstring": "Data Source=poke.db"
  },
  "Pokemon": {
    "MaxPokemonIds": 1025,
    "Other_Dreamworld_Front_Default": "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/"
  }
## Run the application

- Click ▶️ Run HTTP (or press F5) in Visual Studio.

    The app will launch in your browser.

