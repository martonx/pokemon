// See https://aka.ms/new-console-template for more information
using System.Net.Http.Json;

Console.WriteLine("Hello, World!");

//TODO:
/*
 * Menu
 *  1. Listázzuk ki a pokémonok Név, Id
 *  2. Kiválasztott pokémon adatait adjuk vissza
 *      Név, Id, Kép url, Támadás
 */

var client = new HttpClient();
var pokemonList = await client.GetFromJsonAsync<PokemonList>(
    "https://pokeapi.co/api/v2/pokemon");

foreach (var pokemonItem in pokemonList.results)
    Console.WriteLine($"Pokemon: {pokemonItem.name}, url: {pokemonItem.url}");

//Get one pokemon details
var pokemon = await client.GetFromJsonAsync<Pokemon>(
    "https://pokeapi.co/api/v2/pokemon/1");

Console.WriteLine($"Név: {pokemon.name}");
foreach (var type in pokemon.types)
    Console.WriteLine($"Típus: {type.type.name}");

public class Pokemon
{
    public List<Ability> abilities { get; set; }
    public int base_experience { get; set; }
    public Cries cries { get; set; }
    public List<Details> forms { get; set; }
    public List<Game_Indices> game_indices { get; set; }
    public int height { get; set; }
    public object[] held_items { get; set; }
    public int id { get; set; }
    public bool is_default { get; set; }
    public string location_area_encounters { get; set; }
    public Move[] moves { get; set; }
    public string name { get; set; }
    public int order { get; set; }
    public object[] past_abilities { get; set; }
    public object[] past_types { get; set; }
    public Details species { get; set; }
    public Sprites sprites { get; set; }
    public Stat[] stats { get; set; }
    public List<Type> types { get; set; }
    public int weight { get; set; }
}

public class Cries
{
    public string latest { get; set; }
    public string legacy { get; set; }
}

public class Sprites
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
    public Other other { get; set; }
    public Versions versions { get; set; }
}

public class Other
{
    public Dream_World dream_world { get; set; }
    public Home home { get; set; }
    public OfficialArtwork officialartwork { get; set; }
    public Showdown showdown { get; set; }
}

public class Dream_World
{
    public string front_default { get; set; }
    public object front_female { get; set; }
}

public class Home
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class OfficialArtwork
{
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class Showdown
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class Versions
{
    public GenerationI generationi { get; set; }
    public GenerationIi generationii { get; set; }
    public GenerationIii generationiii { get; set; }
    public GenerationIv generationiv { get; set; }
    public GenerationV generationv { get; set; }
    public GenerationVi generationvi { get; set; }
    public GenerationVii generationvii { get; set; }
    public GenerationViii generationviii { get; set; }
}

public class GenerationI
{
    public RedBlue redblue { get; set; }
    public Yellow yellow { get; set; }
}

public class RedBlue
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string back_transparent { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }
    public string front_transparent { get; set; }
}

public class Yellow
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string back_transparent { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }
    public string front_transparent { get; set; }
}

public class GenerationIi
{
    public Crystal crystal { get; set; }
    public Gold gold { get; set; }
    public Silver silver { get; set; }
}

public class Crystal
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_transparent { get; set; }
    public string back_transparent { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_transparent { get; set; }
    public string front_transparent { get; set; }
}

public class Gold
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
    public string front_transparent { get; set; }
}

public class Silver
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
    public string front_transparent { get; set; }
}

public class GenerationIii
{
    public Emerald emerald { get; set; }
    public FireredLeafgreen fireredleafgreen { get; set; }
    public RubySapphire rubysapphire { get; set; }
}

public class Emerald
{
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class FireredLeafgreen
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class RubySapphire
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }
}

public class GenerationIv
{
    public DiamondPearl diamondpearl { get; set; }
    public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
    public Platinum platinum { get; set; }
}

public class DiamondPearl
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class HeartgoldSoulsilver
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class Platinum
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationV
{
    public BlackWhite blackwhite { get; set; }
}

public class BlackWhite
{
    public Animated animated { get; set; }
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class Animated
{
    public string back_default { get; set; }
    public object back_female { get; set; }
    public string back_shiny { get; set; }
    public object back_shiny_female { get; set; }
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationVi
{
    public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }
    public XY xy { get; set; }
}

public class OmegarubyAlphasapphire
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class XY
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationVii
{
    public Icons icons { get; set; }
    public UltraSunUltraMoon ultrasunultramoon { get; set; }
}

public class Icons
{
    public string front_default { get; set; }
    public object front_female { get; set; }
}

public class UltraSunUltraMoon
{
    public string front_default { get; set; }
    public object front_female { get; set; }
    public string front_shiny { get; set; }
    public object front_shiny_female { get; set; }
}

public class GenerationViii
{
    public Icons1 icons { get; set; }
}

public class Icons1
{
    public string front_default { get; set; }
    public object front_female { get; set; }
}

public class Ability
{
    public Details ability { get; set; }
    public bool is_hidden { get; set; }
    public int slot { get; set; }
}

public class Details
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Game_Indices
{
    public int game_index { get; set; }
    public Version version { get; set; }
}

public class Move
{
    public Details move { get; set; }
    public Version_Group_Details[] version_group_details { get; set; }
}

public class Version_Group_Details
{
    public int level_learned_at { get; set; }
    public Details move_learn_method { get; set; }
    public Details version_group { get; set; }
}

public class Stat
{
    public int base_stat { get; set; }
    public int effort { get; set; }
    public Details stat { get; set; }
}

public class Type
{
    public int slot { get; set; }
    public Details type { get; set; }
}
