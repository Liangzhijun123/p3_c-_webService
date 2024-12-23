using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using p3.Models;
using p3.Services;
using Newtonsoft.Json;
using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;

namespace p3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var footerModel = new FooterModel
            {
                Social = new SocialModel
                {
                    Title = "Follow Us",
                    Tweet = "Join us on Twitter!",
                    By = "By RIT",
                    Twitter = "https://twitter.com/RIT",
                    Facebook = "https://facebook.com/RIT"
                },
                QuickLinks = new List<QuickLinkModel>
                {
                    new QuickLinkModel { Title = "Home", Href = "/" },
                    new QuickLinkModel { Title = "About", Href = "/about" },
                    new QuickLinkModel { Title = "Courses", Href = "/course" },
                    new QuickLinkModel { Title = "Employment", Href = "/Employment" },
                    new QuickLinkModel { Title = "Research", Href = "/research" },
                    new QuickLinkModel { Title = "Resources", Href = "/resources" },
                    new QuickLinkModel { Title = "News", Href = "/news" },
                    new QuickLinkModel { Title = "Degrees", Href = "/degrees" },
                    new QuickLinkModel { Title = "Minors", Href = "/minors" },
                },
                Copyright = new CopyrightModel
                {
                    Title = "RIT Course Portal",
                    Html = "&copy; 2024 All Rights Reserved"
                }
            };

            return View(footerModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> People()
        {
            DataRetrieval dataR = new DataRetrieval();
            var loadedPep = await dataR.GetData("people/");
            var jsonResult = JsonConvert.DeserializeObject<PeopleModel>(loadedPep);

            //page title
            jsonResult.pageTitle = "Our People";
            return View(jsonResult);
        }

        //right click on About() to add a view
        //public IActionResult about()
        public async Task<IActionResult> About()
        {
            DataRetrieval dataR = new DataRetrieval();

            // Fetch data for different sections
            var loadedAbout = await dataR.GetData("about/");
            var rtnResult = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);

            var loadedResearch = await dataR.GetData("research/");
            var researchResult = JsonConvert.DeserializeObject<ResearchModel>(loadedResearch);

            var loadedResource = await dataR.GetData("resources/");
            var resourceResult = JsonConvert.DeserializeObject<ResourceModel>(loadedResource);

            var loadedNews = await dataR.GetData("news/");
            var newsResult = JsonConvert.DeserializeObject<NewsModel>(loadedNews);

            // Footer model setup
            var footerModel = new FooterModel
            {
                Social = new SocialModel
                {
                    Title = "Follow Us",
                    Tweet = "Join us on Twitter!",
                    By = "By RIT",
                    Twitter = "https://twitter.com/RIT",
                    Facebook = "https://facebook.com/RIT"
                },
                QuickLinks = new List<QuickLinkModel>
        {
            new QuickLinkModel { Title = "Home", Href = "/" },
            new QuickLinkModel { Title = "About", Href = "/about" },
            new QuickLinkModel { Title = "Courses", Href = "/course" },
            new QuickLinkModel { Title = "Employment", Href = "/Employment" },
            new QuickLinkModel { Title = "Research", Href = "/research" },
            new QuickLinkModel { Title = "Resources", Href = "/resources" },
            new QuickLinkModel { Title = "News", Href = "/news" },
            new QuickLinkModel { Title = "Degrees", Href = "/degrees" },
            new QuickLinkModel { Title = "Minors", Href = "/minors" },
        },
                Copyright = new CopyrightModel
                {
                    Title = "RIT Course Portal",
                    Html = "&copy; 2024 All Rights Reserved"
                }
            };

            // Creating a dynamic object (ExpandoObject)
            dynamic expando = new ExpandoObject();
            var comboModel = expando as IDictionary<string, object>;

            // Adding the models to the dynamic object
            comboModel.Add("About", rtnResult);
            comboModel.Add("Research", researchResult);
            comboModel.Add("Resources", resourceResult);
            comboModel.Add("News", newsResult);
            comboModel.Add("Footer", footerModel);

            // Return the view with the dynamic model
            return View(comboModel);
        }


        public async Task<IActionResult> Course()
		{
			// Load the data
			DataRetrieval dataR = new DataRetrieval();

			// Get About data
			var loadedAbout = await dataR.GetData("about/");
			var rtnResult = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);

			// Get Course data (as a list)
			var loadedCourse = await dataR.GetData("course/");
			var courseRtnResult = JsonConvert.DeserializeObject<List<CourseModel>>(loadedCourse);

			// Combine models using ExpandoObject
			dynamic expando = new ExpandoObject();
			var comboModel = expando as IDictionary<string, object>;

			comboModel.Add("About", rtnResult);
			comboModel.Add("Course", courseRtnResult);
			comboModel.Add("PageTitle", "test with object");

			return View(comboModel);
		}

		public async Task<IActionResult> Degree()
		{
			DataRetrieval dataR = new DataRetrieval();

			var loadedDegree = await dataR.GetData("degrees/");
			var rtnResult = JsonConvert.DeserializeObject<DegreeModel>(loadedDegree);

			return View(rtnResult);
		}

        public async Task<IActionResult> Minor()
        {
            DataRetrieval dataR = new DataRetrieval();

            var loadedMinor = await dataR.GetData("minors/");
            var rtnResult = JsonConvert.DeserializeObject<MinorModel>(loadedMinor);

            return View(rtnResult);
        }

        public async Task<IActionResult> Employment()
        {
            DataRetrieval dataR = new DataRetrieval();

            var loadedEmploy = await dataR.GetData("employment/");
            var rtnResult = JsonConvert.DeserializeObject<EmploymentModel>(loadedEmploy);

            return View(rtnResult);
        }
  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
