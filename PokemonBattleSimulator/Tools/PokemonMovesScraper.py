# -*- coding: utf-8 -*-

import time
import requests
from bs4 import BeautifulSoup
import json
import logging

logging.basicConfig(level=logging.INFO, format="%(message)s")

def normalize_int(text, default=0, allow_null=False):
    try:
        cleaned = text.strip().replace("–", "-").replace("—", "-").replace("−", "-").replace("∞", "").replace("▒", "").replace("�", "").strip()
        if cleaned in ["", "-"]:
            return None if allow_null else default
        return int(cleaned)
    except Exception as e:
        print(f"[WARNING] Failed to convert '{repr(text)}' to int: {e}")
        return None if allow_null else default

def scrape_generation(gen):
    """Return list of move dicts introduced in generation `gen`."""
    url = f"https://pokemondb.net/move/generation/{gen}"
    logging.info(f"Scraping Gen {gen} → {url}")
    response = requests.get(url)
    soup = BeautifulSoup(response.text, "html.parser")

    table = soup.find("table", class_="data-table")
    if not table:
        logging.error(f"No data-table found on Gen {gen}")
        return []

    moves = []
    for row in table.tbody.find_all("tr"):
        cols = row.find_all("td")
        name     = cols[0].text.strip()
        type_    = cols[1].text.strip()
        category = cols[2].find("img")["alt"].strip()
        power    = normalize_int(cols[3].text, default=0)
        accuracy = normalize_int(cols[4].text, allow_null=True)
        pp       = normalize_int(cols[5].text, default=0)
        desc     = cols[6].text.strip()

        moves.append({
            "Name":        name,
            "Type":        type_,
            "Category":    category,
            "Power":       power,
            "Accuracy":    accuracy,
            "PP":          pp,
            "Description": desc
        })
    return moves

def main():
    all_moves = []
    seen = set()  # track by (name, gen) or just name if each only appears in its gen
    for gen in range(1, 6):
        gen_moves = scrape_generation(gen)
        for m in gen_moves:
            key = m["Name"]
            if key not in seen:
                seen.add(key)
                all_moves.append(m)
        time.sleep(1)  # be nice
    # sort alphabetically by move name
    all_moves.sort(key=lambda mv: mv["Name"].lower())

    out_path = "PokemonMoves_Gen1-5.json"
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(all_moves, f, indent=4, ensure_ascii=False)
    logging.info(f"Wrote {len(all_moves)} moves to {out_path}")

if __name__ == "__main__":
    main()
