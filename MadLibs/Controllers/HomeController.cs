using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string firstName, string secondName, string animal, string exclamation, string verb, string noun)
    {
      GameVariables userInput = new GameVariables();
      userInput.FirstName = firstName;
      userInput.SecondName = secondName;
      userInput.Animal = animal;
      userInput.Exclamation = exclamation;
      userInput.Verb = verb;
      userInput.Noun = noun;
      return View(userInput);
    }

  }
}