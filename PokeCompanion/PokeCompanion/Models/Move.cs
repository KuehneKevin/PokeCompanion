namespace PokeCompanion.Models;

public class Move
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string MoveType { get; set; }
    public int BasePower { get; set; }
    public int Accuracy { get; set; }
    public int PP { get; set; }
    public int MaxPP { get; set; }
}
