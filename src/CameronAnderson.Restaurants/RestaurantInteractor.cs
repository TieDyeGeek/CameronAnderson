namespace CameronAnderson.Restaurants
{
	public static class RestaurantInteractor
	{
		public static List<Restaurant> GetRestaurants()
		{
			return new List<Restaurant>
			{
				new Restaurant("McDonald's", 1),
				new Restaurant("Burger King", 1),
				new Restaurant("Wendy's", 1),
				new Restaurant("Jimmy Johns", 1.5),
				new Restaurant("Subway", 1.5),
				new Restaurant("Portillos", 1.5),
				new Restaurant("Chipotle", 1.5),
				new Restaurant("Dominos", 1.5),
				new Restaurant("Chinese Buffets", 2),
				new Restaurant("Buffalo Wild Wings", 2),
				new Restaurant("Kenny's Westside Pub", 2),
				new Restaurant("Olive Garden", 3),
				new Restaurant("Blue Duck", 3),
				new Restaurant("Alexander's Steakhouse", 4)
			};
		}
	}
}
