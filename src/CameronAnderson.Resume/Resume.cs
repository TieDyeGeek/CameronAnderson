using System;
using System.Collections.Generic;

namespace CameronAnderson.Resume;

public class Resume
{
	public string Name { get; internal set; }
	public string Location { get; internal set; }
	public List<Link> Links { get; internal set; }
	public List<Education> Education { get; internal set; }
	public List<Experience> Experiences { get; internal set; }
	public List<string> Skills { get; internal set; }
}

public class Link
{
	public string Text { get; internal set; }
	public string Url { get; internal set; }
}

public class Education
{
	public string Degree { get; internal set; }
	public DateTime Date { get; internal set; }
	public string Major { get; internal set; }
	public string Note { get; internal set; }
	public Company Institution { get; internal set; }
	public double Gpa { get; internal set; }
}

public class Experience
{
	public Company Company { get; internal set; }
	public string Position { get; internal set; }
	public DateTime EmploymentStart { get; internal set; }
	public DateTime? EmploymentEnd { get; internal set; }
	public List<string> Notes { get; internal set; }
}

public class Company
{
	public string Name { get; internal set; }
	public string Location { get; internal set; }
	public string Url { get; internal set; }
}
