// See https://aka.ms/new-console-template for more information

using LearningCode.DataStructures;

var xNumber = 14;

var catList = new List<Cat>();

var frejyo = new Cat
{
    Name = "Frejyo",
    Age = 4,
    Breed = null
};

catList.Add(frejyo);

var ducati = new Cat
{
    Name = "Ducati",
    Age = 6,
    Breed = "Criollo"
};

catList.Add(ducati);

var noir = new Cat
{
    Name = "Noir",
    Age = 0,
    Breed = "Criollo"
};

catList.Add(noir);




foreach (var cat in catList)
{
    Console.WriteLine($"Cat Name: {cat.Name}");
    cat.DoTheDocument();
    Console.WriteLine("------------");
}