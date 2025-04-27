# 🐱‍🏍 PokemonBattleSimulator

A WPF MVVM application simulating Pokémon battles.  
Built with C#, .NET, and XAML.

---

## ✨ Features

- Simulate turn-based Pokémon battles.
- Type effectiveness system.
- Status effects and stat modifiers.
- Real-time UI with animations, images, and sounds.
- Clean MVVM architecture with data binding.
- Uses JSON to define Pokémon species, moves, and items.
- Tools/scripts for scraping move/species data from PokémonDB.

---

## 🔧 Technologies

- WPF (.NET)
- MVVM architecture
- C# / XAML
- Git + GitHub
- JSON-based external data
- Python (for data scraping)

---

## 📁 Data Structure

- `PokemonMoves.json`: All Generation 1–5 moves.
- `Items.json`: Common healing/status items.
- `PokemonSpecies.json`: Pokémon stats, types, sprites, and learnsets.

---

## 🚀 Getting Started

1. Clone the repo:
   ```bash
   git clone https://github.com/ori-gross/PokemonBattleSimulator.git
   cd PokemonBattleSimulator

2. Open in Visual Studio 2022+ (or Rider) and build the solution.

3. Make sure the following are set:
   - `Resources/UI/Audio/MainTheme.mp3` → Set as **Resource**
   - JSON files are in `Resources/Data/` → Set as **Copy if newer**

## 🎯 Roadmap

- [x] Design core data models (Pokémon, Moves, Items, Types, Stats, Trainers, etc.)
- [x] Define and load data from external JSON files
- [x] Build scraping tools for moves and species (Python + Pokémon DB)
- [x] Set up MVVM architecture with ViewModels and services
- [x] Implement background music with volume/mute controls
- [x] Create Pokédex, Attackdex, and Itemdex browsing views
- [ ] Implement team setup and trainer customization
- [ ] Build turn-based battle simulation engine
- [ ] Add support for stat changes, status conditions, type effectiveness, etc.
- [ ] Create animated battle view with health bars and move selection
- [ ] Add settings UI (audio, accessibility, visuals)
- [ ] Enable random team generation and AI opponents
- [ ] Design save/load system and game persistence
- [ ] Polish UI and add final assets and transitions

---

## 🙌 Credits

- **[Pokémon Essentials](https://essentialsdocs.fandom.com/wiki/Essentials_Docs_Wiki)**  
  Graphics and audio assets are based on Pokémon Essentials, used under fair use for non-commercial, educational purposes.

- **[Pokémon Database (pokemondb.net)](https://pokemondb.net/)**  
  Move and Pokémon species data were scraped from this site for use in the simulator.

- **ChatGPT (OpenAI)**  
  Used as a programming assistant to help design architecture, implement features, and refactor the project during development.

- **Developed by Ori Gross**  
  Built with ❤️ as a personal project to simulate Pokémon battles in a clean MVVM-structured WPF application.
