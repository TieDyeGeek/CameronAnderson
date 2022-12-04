using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace CameronAnderson.Restaurants;

public static class RestaurantInteractor
{
	public static RestaurantOptions GetRestaurants()
	{
		return new RestaurantOptions(
			Restaurants
				.OrderBy(x => x.Level)
				.ThenBy(x => x.Name)
				.ToList(),
			Levels);
	}

	private static List<RestaurantLevel> Levels => new()
	{
		new RestaurantLevel(1, "Fast Food (Generally take out)"),
		new RestaurantLevel(2, "Fast Casual (Take out or eat in; pay when ordering"),
		new RestaurantLevel(3, "Sit Downs"),
		new RestaurantLevel(4, "Fancy"),
	};

	private static List<Restaurant> Restaurants => new()
	{
		new Restaurant("McDonald's", 1),
		new Restaurant("Burger King", 1),
		new Restaurant("Wendy's", 1),
		new Restaurant("Subway", 1),
		new Restaurant("Domino's", 1),

		new Restaurant("Jimmy John's", 2),
		new Restaurant("Portillo's", 2),
		new Restaurant("Chipotle", 2),
		new Restaurant("Culver's", 2),
		new Restaurant("Five Guys", 2),
		new Restaurant("LaGondola", 2, "https://lagondolaspaghettihouse.com/"),
		new Restaurant("China Garden", 2, "http://www.chinagardengermantownhills.com"),
		new Restaurant("Noodles and Company", 2),

		new Restaurant("Buffalo Wild Wings", 3, "https://www.buffalowildwings.com/en/food/"),
		new Restaurant("Kenny's Westside Pub", 3),
		new Restaurant("Olive Garden", 3),
		new Restaurant("Applebee's", 3),
		new Restaurant("Blue Duck", 3, "http://www.blueduckbarbecue.com/menu"),
		new Restaurant("Texas Road House", 3),
		new Restaurant("Kelleher's", 3, "https://www.kellehersonwater.com/food"),
		new Restaurant("Maquet's Rail House", 3, "https://maquetsrailhouse.com/menu"),
		new Restaurant("Seasons Gastropub", 3, "https://www.seasonsgastro.pub/menus/"),

		new Restaurant("Alexander's Steakhouse", 4),
	};
}
