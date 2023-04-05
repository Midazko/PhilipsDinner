using ClassLibrary;

public class Phone : IDinnerGuest
{
    public string Roll { get; set; }
    public void Act()
    {
        var Random = new Random();
        var RandomProcent = new Random();
        int Number = RandomProcent.Next(0, 100); 
        if (Number < 5)
        {
            var Item = new[] { "Ringer", "fick SMS" };
            var Roll = Item[Random.Next(Item.Length)];
            Console.WriteLine($"\n{"Telefonen"} {Roll}");
        }

    }
    public void MightLevelUp(string Roll)
    {

    }
}