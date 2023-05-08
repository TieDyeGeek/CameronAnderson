using System;
using System.Collections.Generic;

namespace CameronAnderson.Resume;

public record Resume(
	string Name,
	string Location,
	List<Link> Links,
	List<Education> Education,
	List<Experience> Experiences,
	List<string> Skills
);

public record Link(
	string Text,
	string Url
);

public record Education(
	string Degree,
	DateOnly Date,
	string Major,
	string Note,
	Company Institution,
	double Gpa
)
{
	public string DateFormatted => Date.ToAbreviatedMonthYearString();
};

public record Experience(
	Company Company,
	string Position,
	DateOnly EmploymentStart,
	DateOnly? EmploymentEnd,
	List<string> Notes
)
{
	public string EmploymentStartFormatted => EmploymentStart.ToAbreviatedMonthYearString();
	public string EmploymentEndFormatted => EmploymentEnd?.ToAbreviatedMonthYearString() ?? "Present";
	public string EmploymentDatesFormatted => $"{EmploymentStartFormatted} — {EmploymentEndFormatted}";
};

public record Company(
	string Name,
	string Location,
	string Url
);
