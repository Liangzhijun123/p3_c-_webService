namespace p3.Models
{ 
    public class FooterModel
    {
        public SocialModel Social { get; set; }
        public List<QuickLinkModel> QuickLinks { get; set; }
        public CopyrightModel Copyright { get; set; }
    }

    public class SocialModel
    {
        public string Title { get; set; }
        public string Tweet { get; set; }
        public string By { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
    }

    public class QuickLinkModel
    {
        public string Title { get; set; }
        public string Href { get; set; }
    }

    public class CopyrightModel
    {
        public string Title { get; set; }
        public string Html { get; set; }
    }

}
