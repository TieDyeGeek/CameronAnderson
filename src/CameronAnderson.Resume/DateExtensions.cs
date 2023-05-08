using System;

namespace CameronAnderson.Resume;

internal static class DateExtensions
{
	internal static string ToAbreviatedMonthYearString(this DateOnly date)
	{
		return date.ToString("MMM yyyy");
	}
}

