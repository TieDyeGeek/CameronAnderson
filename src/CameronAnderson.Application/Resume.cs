using System;
using System.Collections.Generic;

namespace CameronAnderson.Resume
{
	public class Resume
	{
		public string Name { get; set; }
		public string Location { get; set; }
		public List<Link> Links { get; set; }
		public List<Education> Education { get; set; }
		public List<Experience> Experiences { get; set; }
	}

	public class Link
	{
		public string Text { get; set; }
		public string Uri { get; set; }
	}

	public class Education
	{
		public string Degree { get; set; }
		public DateTime Date { get; set; }
		public string Major { get; set; }
		public string Minor { get; set; }
		public string Project { get; set; }
		public string Institution { get; set; }
		public string InstitutionLocation { get; set; }
		public double Gpa { get; set; }
	}

	public class Experience
	{
		public string Company { get; set; }
		public string CompanyLocation { get; set; }
		public string Position { get; set; }
		public DateTime EmploymentStart { get; set; }
		public DateTime? EmploymentEnd { get; set; }
		public List<string> Notes { get; set; }
	}
}
