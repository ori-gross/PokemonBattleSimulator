# -*- coding: utf-8 -*-

import requests
from bs4 import BeautifulSoup
import json

url = "https://pokemondb.net/move/generation/1"
response = requests.get(url)
soup = BeautifulSoup(response.text, "html.parser")

moves_table = soup.find("table", class_="data-table")
rows = moves_table.find("tbody").find_all("tr")

moves = []

def normalize_int(text, default=0, allow_null=False):
    try:
        cleaned = text.strip().replace("–", "-").replace("—", "-").replace("−", "-").replace("∞", "").replace("▒", "").replace("�", "").strip()
        if cleaned in ["", "-"]:
            return None if allow_null else default
        return int(cleaned)
    except Exception as e:
        print(f"[WARNING] Failed to convert '{repr(text)}' to int: {e}")
        return None if allow_null else default

for row in rows:
    cols = row.find_all("td")
    name = cols[0].text.strip()
    type_ = cols[1].text.strip()
    category = cols[2].find("img")["alt"].strip()
    power = normalize_int(cols[3].text, default=0)
    accuracy = normalize_int(cols[4].text, allow_null=True)
    pp = normalize_int(cols[5].text, default=0)
    description = cols[6].text.strip()

    moves.append({
        "Name": name,
        "Type": type_,
        "Category": category,
        "Power": power,
        "Accuracy": accuracy,
        "PP": pp,
        "Description": description
    })

# Save to JSON
with open("PokemonMoves_Gen1.json", "w", encoding="utf-8") as f:
    json.dump(moves, f, indent=4, ensure_ascii=False)

print(f"Extracted {len(moves)} moves to PokemonMoves_Gen1.json")
