namespace p3.Models
{
	public class DegreeModel
	{
		public List<UnderGraduate> Undergraduate { get; set; }
		public List<Graduate> Graduate { get; set; }
	}

	public class UnderGraduate
	{
		public string DegreeName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public List<string> Concentrations { get; set; } 
	}

	public class Graduate
	{
		public string DegreeName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public List<string> Concentrations { get; set; } 
	}
}
