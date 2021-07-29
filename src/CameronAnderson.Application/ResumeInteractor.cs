using System;
using System.Collections.Generic;

namespace CameronAnderson.Resume
{
	public static class ResumeInteractor
	{
		public static Resume GetResume()
		{
			return new Resume
			{
				Name = "Cameron Anderson",
				Location = "Peoria, IL area",
				Links = GetLinks(),
				Education = GetEducation(),
				Experiences = new List<Experience>
				{
					new Experience
					{
						Company = "CSE Software, Inc.",
						CompanyLocation = "Peoria, IL",
						Position = "Technical Architect",
						EmploymentStart = new DateTime(2020, 12, 24),
						EmploymentEnd = null,
						Notes = new List<string>
						{
							"asdf",
							"Training ..."
						}
					},
					new Experience
					{
						Company = "CSE Software, Inc.",
						CompanyLocation = "Peoria, IL",
						Position = "Enterprise Software Developer",
						EmploymentStart = new DateTime(2018, 11, 27),
						EmploymentEnd = new DateTime(2020, 12, 24),
						Notes = new List<string>
						{
							"Deveop and maintain enterprise web applications using C# and .NET",
							"Create training exercises for current employees and new hires",
							"C#, MVC, .NET Framework, .NET Core, SQL Server, Atlassian tools (Bitbucket, Jira, Confluence), Azure DevOps"
						}
					},
					new Experience
					{
						Company = "Western Illinois University Housing & Dining Services",
						CompanyLocation = "Macomb, IL",
						Position = "Assistant Complex Director",
						EmploymentStart = new DateTime(2017, 6, 1),
						EmploymentEnd = new DateTime(2018, 5, 19),
						Notes = new List<String>
						{
							"Supervised two Resident Managers in Graduate and Family Housing",
							"Served on the on-call duty rotation for 3 facilities responding to facilities and crisis situations",
							"Assisted with maintaining the housing website, creating video training materials for Resident Assistants, and marketing housing renewal"
						}
					}
				}
			};
		}

		private static List<Link> GetLinks()
		{
			return new List<Link>
			{
				new Link
				{
					Text = "cell",
					Uri = @"tel:+1-309-231-7834"
				},
				new Link
				{
					Text = "email",
					Uri = @"mailto:canderson3.14@me.com"
				},
				new Link
				{
					Text = "linkdin",
					Uri = @"https://www.linkedin.com/in/cameron-anderson/"
				},
				new Link
				{
					Text = "github",
					Uri = @"https://github.com/TieDyeGeek/"
				}
			};
		}

		private static List<Education> GetEducation()
		{
			return new List<Education>
			{
				new Education
				{
					Degree = "Master of Science",
					Date = new DateTime(2018, 5, 1),
					Major = "Computer Science",
					Project = "Two-Player Asymmetrical Virtual Reality Maze Game",
					Institution = "Western Illinois University",
					InstitutionLocation = "Macomb, IL",
					Gpa = 4
				},
				new Education
				{
					Degree = "Bachelor of Science",
					Date = new DateTime(2017, 5, 1),
					Major = "Computer Science",
					Minor = "Information Systems, Mathematics",
					Institution = "Western Illinois University",
					InstitutionLocation = "Macomb, IL",
					Gpa = 3.4
				}
			};
		}
	}
}
