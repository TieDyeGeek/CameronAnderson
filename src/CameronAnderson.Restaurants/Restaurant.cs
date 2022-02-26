namespace CameronAnderson.Restaurants;

public record Restaurant
{
	public Restaurant(string name, double level, string? menuLink = null)
	{
		Name = name;
		Level = level;
		MenuLink = menuLink;
	}

	public string Name { get; }
	public double Level { get; }
	public string? MenuLink { get; }
}
