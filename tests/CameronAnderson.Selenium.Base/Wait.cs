namespace CameronAnderson.Selenium.Base;

public static class Wait
{
	public static void Milliseconds(int milliseconds)
	{
		Thread.Sleep(milliseconds);
	}

	public static void Seconds(double seconds)
	{
		Milliseconds((int)(seconds * 1000));
	}

	public static void Minutes(double minutes)
	{
		Seconds(minutes * 60);
	}

	/// <summary>
	/// 1 jiffy = 1/60 of a second
	/// </summary>
	public static void Jiffy(double jiffies)
	{
		Seconds(jiffies / 60);
	}

	/// <summary>
	/// 1 moment = 90 seconds
	/// </summary>
	public static void Moment(double moments)
	{
		Seconds(moments * 90);
	}

	/// <summary>
	/// 1 microfortnit = 1.2096 seconds
	/// </summary>
	public static void Microfortnight(double microfortnights)
	{
		Seconds(microfortnights * 1.2096);
	}
}
