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
		new RestaurantLevel(1, "Fast Food (order at front)"),
		new RestaurantLevel(1.5, "Semi-Fast Food"),
		new RestaurantLevel(2, "Mom & Pops / Sports Bars (sit downs)"),
		new RestaurantLevel(3, "Full Sit Downs (no TVs)"),
		new RestaurantLevel(4, "Fancy (specialty items; focus)"),
	};

	private static List<Restaurant> Restaurants => new()
	{
		new Restaurant("McDonald's", 1),
		new Restaurant("Burger King", 1),
		new Restaurant("Wendy's", 1),
		new Restaurant("Jimmy John's", 1.5),
		new Restaurant("Subway", 1.5),
		new Restaurant("Portillo's", 1.5),
		new Restaurant("Chipotle", 1.5),
		new Restaurant("Domino's", 1.5),
		new Restaurant("Culver's", 1.5),
		new Restaurant("Chinese Buffets", 2),
		new Restaurant("Buffalo Wild Wings", 2, "https://www.buffalowildwings.com/en/food/"),
		new Restaurant("Kenny's Westside Pub", 2),
		new Restaurant("Noodles and Company", 2),
		new Restaurant("Olive Garden", 3),
		new Restaurant("Applebee's", 3),
		new Restaurant("Blue Duck", 3),
		new Restaurant("Texas Road House", 3),
		new Restaurant("Alexander's Steakhouse", 4),
		new Restaurant("Kelleher's", 2, "https://www.kellehersonwater.com/food"),
		new Restaurant("Maquet's Rail House", 2, "https://maquetsrailhouse.com/menu"),
		new Restaurant("Seasons Gastropub", 3, "https://www.seasonsgastro.pub/menus/")
	};
}
