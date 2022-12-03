using System.Collections.Generic;

namespace CameronAnderson.Restaurants;

public record RestaurantOptions(
	List<Restaurant> Restaurants,
	List<RestaurantLevel> Levels
);

public record Restaurant(
	string Name,
	double Level,
	string? MenuLink = null
);

public record RestaurantLevel(
	double Level,
	string Description
);