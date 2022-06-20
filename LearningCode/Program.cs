// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var numbersList = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
};

foreach (var number in numbersList)
{
    Console.WriteLine($"Number: {number}");
}