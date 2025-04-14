# -*- coding: utf-8 -*-

# Re-run the script after kernel reset
import requests
from bs4 import BeautifulSoup
import json
import time

def normalize_name(name):
    name = name.strip()
    
    if name == "Nidoran♀":
        return "nidoran-f"
    if name == "Nidoran♂":
        return "nidoran-m"

    return name.lower().replace(" ", "-").replace(".", "").replace("♀", "-f").replace("♂", "-m").replace("'", "").replace("é", "e")

def extract_base_stats(row):
    cols = row.find_all("td")
    return {
        "PokedexNumber": int(cols[0].text.strip()),
        "Name": cols[1].text.strip(),
        "Type1": cols[2].find_all("a")[0].text.strip(),
        "Type2": cols[2].find_all("a")[1].text.strip() if len(cols[2].find_all("a")) > 1 else "None",
        "BaseStats": {
            "HP": int(cols[4].text.strip()),
            "Attack": int(cols[5].text.strip()),
            "Defense": int(cols[6].text.strip()),
            "SpecialAttack": int(cols[7].text.strip()),
            "SpecialDefense": int(cols[8].text.strip()),
            "Speed": int(cols[9].text.strip())
        }
    }

def extract_learnable_moves(pokemon_name):
    url = f"https://pokemondb.net/pokedex/{normalize_name(pokemon_name)}/moves/5"
    # print(f"Checking moves URL: {url}")
    response = requests.get(url)
    soup = BeautifulSoup(response.text, "html.parser")

    # Find the header for the "Moves learnt by level up" section
    move_table = None
    for h3 in soup.find_all("h3"):
        if "Moves learnt by level up" in h3.text:
            # Go to the following sibling div with the table
            resp_scroll = h3.find_next("div", class_="resp-scroll")
            if resp_scroll:
                move_table = resp_scroll.find("table", class_="data-table")
            break

    if not move_table:
        print(f"Could not find level-up move table for {pokemon_name}")
        return { "LearnableMoves": [] }

    moves = []
    for row in move_table.find("tbody").find_all("tr"):
        try:
            level = row.find("td", class_="cell-num").text.strip()
            if level.lower() in ["—", "-", "varies"]:
                continue
            move_name = row.find("td", class_="cell-name").text.strip()
            moves.append({
                "Move": move_name,
                "Level": int(level)
            })
        except Exception as e:
            print(f"Skipping a row for {pokemon_name}: {e}")
            continue

    return { "LearnableMoves": moves }

    table = move_table.find_next("table")
    moves = []
    for row in table.find("tbody").find_all("tr"):
        cols = row.find_all("td")
        try:
            level = cols[0].text.strip()
            if level.lower() in ["—", "-", "varies"]:
                continue
            move_name = cols[1].text.strip()
            moves.append({
                "Move": move_name,
                "Level": int(level)
            })
        except Exception:
            continue
    return moves

def build_sprite_paths(pokemon_name):
    # Normalize to match the file name convention
    if pokemon_name == "Nidoran♀":
        sprite_name = "NIDORANF"
    elif pokemon_name == "Nidoran♂":
        sprite_name = "NIDORANM"
    else:
        sprite_name = pokemon_name.upper()

    return {
        "FrontImageMalePath": f"Resources/Graphics/Pokemon/Front/{sprite_name}.png",
        "FrontImageFemalePath": f"Resources/Graphics/Pokemon/Front/{sprite_name}.png",
        "BackImageMalePath": f"Resources/Graphics/Pokemon/Back/{sprite_name}.png",
        "BackImageFemalePath": f"Resources/Graphics/Pokemon/Back/{sprite_name}.png",
        "IconImagePath": f"Resources/Graphics/Pokemon/Icons/{sprite_name}.png"
    }

# Fetch data for the first 9 Pokémon
url = "https://pokemondb.net/pokedex/all"
response = requests.get(url)
soup = BeautifulSoup(response.text, "html.parser")
rows = soup.find("table", class_="data-table").find("tbody").find_all("tr")

pokemon_list = []
seen_pokedex_numbers = set()

for row in rows:
    base_data = extract_base_stats(row)
    num = base_data["PokedexNumber"]
    name = base_data["Name"]

    if num in seen_pokedex_numbers:
        continue
    if any(x in name.lower() for x in ["mega", "alolan", "galarian", "hisuian", "partner", "paldean"]):
        continue

    print(f"Scraping {name}...".encode("ascii", "ignore").decode())
    base_data["LearnableMoves"] = extract_learnable_moves(name)
    base_data["Sprites"] = build_sprite_paths(name)
    pokemon_list.append(base_data)
    seen_pokedex_numbers.add(num)

    if len(pokemon_list) >= 151:
        break

    time.sleep(1)  # Be nice to the server

# Save to JSON
#output_path = "/mnt/data/PokemonSpecies_Gen1to5_Sample.json"
with open("PokemonSpecies_Gen1to5_Sample.json", "w", encoding="utf-8") as f:
    json.dump(pokemon_list, f, indent=4, ensure_ascii=False)

#output_path
