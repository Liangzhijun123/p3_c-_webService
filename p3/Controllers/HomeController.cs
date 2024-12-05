using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using p3.Models;
using p3.Services;
using Newtonsoft.Json;
using System.Dynamic;

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
            return View();
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
   
		//right click on About() to add a view
		//public IActionResult about()
		public async Task<IActionResult> About()
        {
            //let see if the DataRetrieval.cs is retriveable?
            DataRetrieval dr = new DataRetrieval();
            var stringAbout = await dr.GetData("about/");
            
            //now what?
                //u do casat to json (string currently)
                //create a model
                //put the json into the model
            var aboutModel = JsonConvert.DeserializeObject<AboutModel>(stringAbout);
            aboutModel.pageTitle = "About the iSchool";
            //feed the model to the view
            return View(aboutModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
