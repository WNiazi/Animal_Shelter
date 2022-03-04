using Microsoft.AspNetCore.Mvc;

namespace AnimalShelter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}

//this is stating home page, look at the index under home and return the view