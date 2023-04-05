using ClassLibrary;

public class Fly : IDinnerGuest
{
    public string Roll { get; set; }
    public string Name { get; set; }
    public int Count { get; set; } = 0;

    public int Level { get; set; } = 1;

    public void Act()
    {
        var Random = new Random();
        var Item = new[] { "flyger", "Landar i maten" };
        var Roll = Item[Random.Next(Item.Length)];
        MightLevelUp(Roll);
        Console.WriteLine($"\n{"Flugan"} {Roll}");
    }
    public void MightLevelUp(string Roll)
    {

        if (Roll == "Landar i maten")
        {
            Count++;
        }

        if (Count == 3)
        {
            Level++;
            Count = 0;
            Console.WriteLine($"{"Flugan"} Gick upp i level!");
        }
    }
}