using ClassLibrary;

public class Cat : IDinnerGuest
{
    public string Roll { get; set; }
    public bool CatisInside { get; set; } = true;
    public void Act()
    {
        var Random = new Random();
        int Number = Random.Next(0, 100);
        if (Number < 10)
        {
            var Item = new[] { "Jamar, vill ut", "Jamar, vill in" };
            var Roll = Item[Random.Next(Item.Length)];
            Console.WriteLine($"\n{"Katten"} {Roll}");
            if (Roll == "Jamar, vill in")
            {
                if (CatisInside)
                {
                    Console.WriteLine("Vem släppte in kattjäveln?");
                }
                CatisInside = true;
            }
            else if (Roll == "Jamar, vill ut")
            {
                if (CatisInside == false)
                {
                    Console.WriteLine("Hur fan kom kattjäveln ut?");
                }
                CatisInside = false;
            }
        }
    }
    public void MightLevelUp(string Roll)
    {

    }
}