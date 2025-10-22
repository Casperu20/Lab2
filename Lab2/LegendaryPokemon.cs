namespace Lab2;

public class LegendaryPokemon : BasePokemon {
    public String SpecialType{get; set;} = "Legendary";
    
    public override void DisplayInfo()
    {
        Console.WriteLine("***{0}***", Name.ToUpper());
        Console.WriteLine("Special Type: {0}", SpecialType);
        Console.WriteLine("Height: {0}", Height);
        Console.WriteLine("Weight: {0}", Weight);
        Console.WriteLine("Base Experience: {0}", BaseExperience);
        
        Console.WriteLine(" ---- Pokemon Stats END ---- ");
    }
    
}