using System;
using System.Collections.Generic;

namespace CameronAnderson.Resume;

public static class ResumeInteractor
{
	public static Resume GetResume()
	{
		return new Resume(
			Name: "Cameron Anderson",
			Location: "Peoria, IL area",
			Links: Links,
			Education: Education,
			Experiences: new List<Experience>
			{
				TechnicalArchitect,
				Developer,
				AssistantComplexDirector,
				CommunityCoordinator,
				ResidentAssistant
			},
			Skills: Skills
		);
	}

	private static List<string> Skills => new()
	{
		"C#",
		".NET",
		"Azure",
		"REST APIs",
		"MVC",
		"UWP",
		"Selenium",
		"Blazor",
		"Azure DevOps",
		"Atlassian Tools (Bitbucket, Jira, Confluence)",
		"HTML",
		"CSS",
		"SQL"
	};

	private static List<Link> Links => new()
	{
		new Link(
			Text: "email",
			Url: @"mailto:canderson3.14@me.com"
		),
		new Link(
			Text: "linkedin",
			Url: @"https://www.linkedin.com/in/cameron-anderson/"
		),
		new Link(
			Text: "github",
			Url: @"https://github.com/TieDyeGeek/"
		)
	};

	private static List<Education> Education => new()
	{
		new Education(
			Degree: "Master of Science",
			Date: new DateTime(2018, 5, 1),
			Major: "Computer Science",
			Note: "Project:  Two-Player Asymmetrical Virtual Reality Maze Game",
			Institution: WIU,
			Gpa: 4.0
		),
		new Education(
			Degree: "Bachelor of Science",
			Date: new DateTime(2017, 5, 1),
			Major: "Computer Science",
			Note: "Minors:  Information Systems, Mathematics",
			Institution: WIU,
			Gpa: 3.4
		)
	};

	private static Experience TechnicalArchitect => new(
		Company: CSE,
		Position: "Technical Architect",
		EmploymentStart: new DateTime(2020, 12, 24),
		EmploymentEnd: null,
		Notes: new List<string>
		{
			"Plan, develop, test, deploy, and maintain enterprise web and desktop applications",
			"Effectively translate customer requirements into application design",
			"Provide peer code reviews to ensure code quality and maintainability standards",
			"Understand project budgets and impacts of ramping up/down of resources",
			"Assist Team Lead in targeting topics for employee growth plans",
			"Create and maintain CSE's open source projects"
		}
	);

	private static Experience Developer => new(
		Company: CSE,
		Position: "Enterprise Software Developer",
		EmploymentStart: new DateTime(2018, 11, 27),
		EmploymentEnd: new DateTime(2020, 12, 24),
		Notes: new List<string>
		{
			"Deveop and maintain enterprise web applications using C# and .NET",
			"Create training exercises for current employees and new hires"
		}
	);

	private static Experience AssistantComplexDirector => new(
		Company: UHDS,
		Position: "Assistant Complex Director",
		EmploymentStart: new DateTime(2017, 6, 1),
		EmploymentEnd: new DateTime(2018, 5, 19),
		Notes: new List<string>
		{
			"Supervised two Resident Managers in Graduate and Family Housing",
			"Served on the on-call duty rotation for 3 facilities responding to facilities and crisis situations",
			"Assisted with maintaining the housing website, creating video training materials for Resident Assistants, and marketing housing renewal"
		}
	);

	private static Experience CommunityCoordinator => new(
		Company: UHDS,
		Position: "Community Coordinator",
		EmploymentStart: new DateTime(2017, 2, 19),
		EmploymentEnd: new DateTime(2017, 6, 1),
		Notes: new List<string>
		{
			"Assisted with administrative duties in the hall including on-call duty rotation",
			"Followed up with students about facilities, personal, and academic issues"
		}
	);

	private static Experience ResidentAssistant => new(
		Company: UHDS,
		Position: "Resident Assistant",
		EmploymentStart: new DateTime(2014, 8, 1),
		EmploymentEnd: new DateTime(2017, 2, 19),
		Notes: new List<string>
		{
			"Managed a cohesive residence hall living environment of 30-50 students each year",
			"Served as a referral agent in matters of personal, academic, and career related issues"
		}
	);

	private static Company CSE => new(
		Name: "CSE Software, Inc.",
		Location: "Peoria, IL",
		Url: "https://www.csesoftware.com/"
	);

	private static Company UHDS => new(
		Name: "Western Illinois University Housing & Dining Services",
		Location: "Macomb, IL",
		Url: "https://www.wiu.edu/student_services/uhds/index.php"
	);

	private static Company WIU => new(
		Name: "Western Illinois University Housing",
		Location: "Macomb, IL",
		Url: "https://www.wiu.edu/"
	);
}
