namespace LearningCode.DataStructures;

public class Cat
{
    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Breed { get; set; }


    public void DoTheDocument()
    {
        SaveDocument();
    }

    private void SaveDocument()
    {
        var documentString = $"PET DNI: Name {Name} / Age {Age} / Breed {Breed}";
        
        Console.WriteLine(documentString);
    }
}