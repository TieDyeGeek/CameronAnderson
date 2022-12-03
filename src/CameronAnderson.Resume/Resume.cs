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
	DateTime Date,
	string Major,
	string Note,
	Company Institution,
	double Gpa
);

public record Experience(
	Company Company,
	string Position,
	DateTime EmploymentStart,
	DateTime? EmploymentEnd,
	List<string> Notes
);

public record Company(
	string Name,
	string Location,
	string Url
);
