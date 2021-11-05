using System;

namespace CameronAnderson.Selenium.Translations
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
	public class TranslationKeyAttribute : Attribute
	{
		public TranslationKeyAttribute(string key)
		{
			Key = key;
		}

		public string Key { get; set; }
	}
}
