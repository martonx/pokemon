// See https://aka.ms/new-console-template for more information
public class PokemonList
{
    public int count { get; set; }
    public string next { get; set; }
    public object previous { get; set; }
    public List<PokemonListItem> results { get; set; }
}
