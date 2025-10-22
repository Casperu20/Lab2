namespace Lab2;

public abstract class BasePokemon {
    public uint Id{get; set;}
    public string Name{get; set;}
    public uint Weight{get; set;}
    public uint Height{get; set;}
    public uint BaseExperience{get; set;}
    
    public abstract void DisplayInfo();
}

