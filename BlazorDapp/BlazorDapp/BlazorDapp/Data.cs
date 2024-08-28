namespace BlazorDapp;

public class Data
{
    private List<Superhero> SuperheroList; 
    public List<Superhero> GetData()
    {
        return SuperheroList;
    }

    public int GetDataCount()
    {
        return SuperheroList.Count;
    }

    public Task<List<Superhero>> GetDataAsync(int startIndex, int numberofHeroes, CancellationToken cancellationToken) 
    {
        return Task.FromResult(SuperheroList.Skip(startIndex).Take(numberofHeroes).ToList());
    }

    public Data()
    {
        SuperheroList = new List<Superhero>()
        {
            new Superhero { Id = 1, RealName ="Superman", Name = "Clark Kent", Power = "Super Strength" },
            new Superhero { Id = 2, RealName = "Batman", Name = "Bruce Wayne", Power = "Genius-level Intellect" },
            new Superhero { Id = 3, RealName = "Wonder Woman", Name = "Diana Prince", Power = "Superhuman Strength" },
            new Superhero { Id = 4, RealName = "Flash", Name = "Barry Allen", Power = "Super Speed" },
            new Superhero { Id = 5, RealName = "Aquaman", Name = "Arthur Curry", Power = "Underwater Breathing" },
            new Superhero { Id = 6, RealName = "Spider-Man", Name = "Peter Parker", Power = "Spider-Sense" },
            new Superhero { Id = 7, RealName = "Iron Man", Name = "Tony Stark", Power = "Powered Armor Suit" },
            new Superhero { Id = 8, RealName = "Hulk", Name = "Bruce Banner", Power = "Unlimited Strength" },
            new Superhero { Id = 9, RealName = "Thor", Name = "Thor Odinson", Power = "God of Thunder" },
            new Superhero { Id = 10, RealName = "Captain America", Name = "Steve Rogers", Power = "Super Soldier" }
        };
    }
}
