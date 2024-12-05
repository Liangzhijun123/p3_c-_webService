namespace p3.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Careers
    {
        public string title { get; set; }
        public List<string> careerNames { get; set; }
    }

    public class Content
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class CoopInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string term { get; set; }
    }

    public class CoopTable
    {
        public string title { get; set; }
        public List<CoopInformation> coopInformation { get; set; }
    }

    public class DegreeStatistics
    {
        public string title { get; set; }
        public List<Statistic> statistics { get; set; }
    }

    public class Employers
    {
        public string title { get; set; }
        public List<string> employerNames { get; set; }
    }

    public class EmploymentTable
    {
        public string title { get; set; }
        public List<ProfessionalEmploymentInformation> professionalEmploymentInformation { get; set; }
    }

    public class Introduction
    {
        public string title { get; set; }
        public List<Content> content { get; set; }
    }

    public class ProfessionalEmploymentInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string title { get; set; }
        public string startDate { get; set; }
    }

    public class EmploymentModel
    {
        public Introduction introduction { get; set; }
        public DegreeStatistics degreeStatistics { get; set; }
        public Employers employers { get; set; }
        public Careers careers { get; set; }
        public CoopTable coopTable { get; set; }
        public EmploymentTable employmentTable { get; set; }
    }

    public class Statistic
    {
        public string value { get; set; }
        public string description { get; set; }
    }


}
