using PokeCompanion.Models;

namespace PokeCompanion;

public class Pokemon
{
    public Guid Id { get; set; }
    public string PokedexNumber { get; set; }
    public string Name { get; set; }
    public string PrimaryType { get; set; }
    public string SecondaryType { get; set; }
    public Ability? Ability1 { get; set; }
    public Ability? Ability2 { get; set; }
    public Ability? HiddenAbility { get; set; }
    public int HP { get; set; }
    public int HP_EV { get; set; }
    public int Atk { get; set; }
    public int Atk_EV { get; set; }
    public int Def { get; set; }
    public int Def_EV { get; set; }
    public int SpA { get; set; }
    public int SpA_EV { get; set; }
    public int SpD { get; set; }
    public int SpD_EV { get; set; }
    public int Spe { get; set; }
    public int Spe_EV { get; set; }
    public decimal Weight { get; set; }
    public string EggGroup { get; set; }
    public List<Move> LevelUpMoves { get; set; }
    public List<Move> TMMoves { get; set; }
    public List<Move> EggMoves { get; set; }
}
