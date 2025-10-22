namespace Lab2;

public class StandardPokemon : BasePokemon {
    public override void DisplayInfo()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Height: {0}", Height);
        Console.WriteLine("Weight: {0}", Weight);
        Console.WriteLine("Base Experience: {0}", BaseExperience);
        
        Console.WriteLine(" ---- Pokemon Stats END ---- ");
    }
}