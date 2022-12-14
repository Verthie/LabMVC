using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_LAB.Models.Person;

namespace WebAPImvc.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new PersonViewModel()
            {
                Persons = new PersonModel().GetPersons()
            };
            return View(model);
        }
    }
}
