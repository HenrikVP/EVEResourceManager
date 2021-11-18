using EVEResourceManager;

Console.WriteLine("Hello, World!");

Resource r = new Resource() { };

List<Resource> EarthResourceList = new()
{
    new Resource(1, "Kul"),
    new Resource(2, "Jern"),
    new Resource(3, "Guld")
};

List<Resource> IceResourceList = new()
{
    new Resource(1, "Water"),
    new Resource(2, "Gas"),
    new Resource(3, "Fish")
};


 

    //public static List<T> GetClone<T>(this List<T> source)
    //{
    //    return source.GetRange(0, source.Count);
    //}



    //public static void Main()
    //{
    //    List<string> source = new List<string>() { "A", "B", "C" };

    //    List<string> clonedList = source.GetRange(0, source.Count);
    //    Console.WriteLine(String.Join(",", clonedList));
    //}





Planet earth = new Planet() { Name = "Earth", Id = 1, Resources = EarthResourceList.GetRange(0, EarthResourceList.Count) };
Planet earth2 = new Planet() { Name = "New Earth", Id = 2, Resources = EarthResourceList.GetRange(0, EarthResourceList.Count) };
List<Planet> planetList = new() { earth, earth2 };

foreach (var planet in planetList)
{
    Console.WriteLine($"\nInput amount for {planet.Name}: ");
    foreach (var res in planet.Resources)
    {
        Console.Write($"R: {res.Name} : ");
        res.Amount = int.Parse(Console.ReadLine());
    }
}

foreach (var planet in planetList)
{
    Console.WriteLine($"\nShow amount for {planet.Name}: ");
    foreach (var res in planet.Resources)
    {
        Console.Write($"R: {res.Name} : {res.Amount}");       
    }
}

//Dictionary<Earth, "LavaResourcelist">