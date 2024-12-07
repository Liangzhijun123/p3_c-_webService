namespace p3.Models
{
    public class AcademicAdvisors
    {
        public string title { get; set; }
        public string description { get; set; }
        public Faq faq { get; set; }
    }

    public class AdvisorInformation
    {
        public string name { get; set; }
        public string department { get; set; }
        public string email { get; set; }
    }

    public class CoopEnrollment
    {
        public string title { get; set; }
        public List<EnrollmentInformationContent> enrollmentInformationContent { get; set; }
        public string RITJobZoneGuidelink { get; set; }
    }

    public class EnrollmentInformationContent
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class FacultyAdvisors
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Faq
    {
        public string title { get; set; }
        public string contentHref { get; set; }
    }

    public class Forms
    {
        public List<GraduateForm> graduateForms { get; set; }
        public List<UndergraduateForm> undergraduateForms { get; set; }
    }

    public class GraduateForm
    {
        public string formName { get; set; }
        public string href { get; set; }
    }

    public class IstMinorAdvising
    {
        public string title { get; set; }
        public List<MinorAdvisorInformation> minorAdvisorInformation { get; set; }
    }

    public class MinorAdvisorInformation
    {
        public string title { get; set; }
        public string advisor { get; set; }
        public string email { get; set; }
    }

    public class Place
    {
        public string nameOfPlace { get; set; }
        public string description { get; set; }
    }

    public class ProfessonalAdvisors
    {
        public string title { get; set; }
        public List<AdvisorInformation> advisorInformation { get; set; }
    }

    public class ResourceModel
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public StudyAbroad studyAbroad { get; set; }
        public StudentServices studentServices { get; set; }
        public TutorsAndLabInformation tutorsAndLabInformation { get; set; }
        public StudentAmbassadors studentAmbassadors { get; set; }
        public Forms forms { get; set; }
        public CoopEnrollment coopEnrollment { get; set; }
    }

    public class StudentAmbassadors
    {
        public string title { get; set; }
        public string ambassadorsImageSource { get; set; }
        public List<SubSectionContent> subSectionContent { get; set; }
        public string applicationFormLink { get; set; }
        public string note { get; set; }
    }

    public class StudentServices
    {
        public string title { get; set; }
        public AcademicAdvisors academicAdvisors { get; set; }
        public ProfessonalAdvisors professonalAdvisors { get; set; }
        public FacultyAdvisors facultyAdvisors { get; set; }
        public IstMinorAdvising istMinorAdvising { get; set; }
    }

    public class StudyAbroad
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<Place> places { get; set; }
    }

    public class SubSectionContent
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class TutorsAndLabInformation
    {
        public string title { get; set; }
        public string description { get; set; }
        public string tutoringLabHoursLink { get; set; }
    }

    public class UndergraduateForm
    {
        public string formName { get; set; }
        public string href { get; set; }
    }


}
