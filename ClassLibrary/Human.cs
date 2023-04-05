namespace ClassLibrary
{
    public class Human : IDinnerGuest
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public int Level { get; set; }
        public string Roll { get; set; }
        public Human(string name)
        {
            Name = name;
        }
        public void Act()
        {
            var Random = new Random();
            var Item = new[] { "Rapar", "Äter", "Dricker", "Pratar" };
            var Roll = Item[Random.Next(Item.Length)];
            MightLevelUp(Roll);
            Console.WriteLine($"\n{Name} {Roll}");
        }
        public void MightLevelUp(string Roll)
        {

            if (Roll == "Rapar")
            {
                Count++;
            }

            if (Count == 3)
            {
                Level++;
                Count = 0;
                Console.WriteLine($"{Name} Gick upp i level!");
            }
        }
    }
}