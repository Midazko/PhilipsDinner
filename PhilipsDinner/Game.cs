using ClassLibrary;

namespace PhilipsDinner;

public class Game
{
    public List<IDinnerGuest> gameList = new();

    public Game()
    {
        gameList.Add(new Human("Philip"));
        gameList.Add(new Human("Richard"));
        gameList.Add(new Human("Niuchasl"));
        gameList.Add(new Human("Ralle"));
        gameList.Add(new Fly());
        gameList.Add(new Phone());
        gameList.Add(new Cat());
    }

    public void Run()
    {
        var GameRun = true;
        while (GameRun)
        {
            foreach (var Guest in gameList)
            {
                Guest.Act();
                Console.ReadKey();
            }
        }
    }
}