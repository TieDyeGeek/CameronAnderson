namespace CameronAnderson.Restaurants
{
	public class Restaurant 
	{
		public Restaurant(string name, double level)
		{
			Name = name;
			Level = level;
		}

		public string Name { get; set; }
		public double Level {  get; set; }
	}
}