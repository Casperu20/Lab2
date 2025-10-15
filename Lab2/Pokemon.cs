namespace Lab2;

public class Pokemon
{
    public Ability[] abilities{get; set;}
    public uint base_experience{get; set;}
    public Cry cries{get; set;}
    public Form[] forms {get; set;}
    public GameIndex[] game_indices{get; set;}
    public uint height{get; set;}
    public Item[] held_items{get; set;}
    public uint id{get; set;}
    public bool is_default{get; set;}
    public string location_area_encounters{get; set;}
    public Move[] moves{get; set;}
    public string name{get; set;}
    public uint order{get; set;}
    public PastAbility[] past_abilities{get; set;}
    public TypeObj[] past_types{get; set;}
    public OneSpecies species{get; set;}
    public object sprites{get; set;} // NOT NOW!
    public Stat[] stats{get; set;}
    public TypeObj[] types{get; set;}
    public uint weight{get; set;}
}