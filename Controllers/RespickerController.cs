//Chris Martinez
//10/27/22
//Restaurant Picker - End Point
//peer review: Jessie Lamzon
//Code works well and get rsults from all the food choices.  I like how list was used for this project.  Nice clean code.  Good job!

using Microsoft.AspNetCore.Mvc;

namespace MartinezCResPickEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RespickerController : ControllerBase
{
 [HttpGet]
 [Route("Select/{foodKinds}")]

 public string RestaurantSelector(string foodKinds)
 {

  Random randomNum = new Random();
  string result = "select from these categories, you can thank us later! : Mexican, Asian, American, FastFood,";
  List<string> mexican = new List<string>() { "El Tepeyac", "Los Aburridos", "Montezuma", "Mi Mexico Lindo", "El Stockton", "El Maestro Ken'z Takos", "Los Ricos", "Las Bonitas", "TEPITO", "TacoKing" };
  List<string> asian = new List<string>() { "Little Tokyo", "Matsuhisa", "Phat Thai", "LoMeinz", "SupremeLederRoll", "YingandYang", "Korean Taquisa", "Kung Lao's", "Lord China", "Fresh Delicacies", "Ken Lee's Noodle" };
  List<string> american = new List<string>() { "Maverick's", "German Frankies", "Chicago Dogs", " Two Rivers", "Mezzaluna", "The HeavyHitters", "The Wise Guy", "Last Frontier Burgers", "Trouts", "BrewPub", "Locals Coner", "Chris's Local spot", "Miller Time", "Whole in the Wall" };
  List<string> fastfood = new List<string>() { "Taco Bell", "Panda Express", "Chick-fil-A", "Subway", "KFC", "Popeyes", "Raising Canes", "La Estrella", "Sonic", "In and Out" };
  if (foodKinds == "mexican")
  {
   int mex = randomNum.Next(0, 10);
   result = mexican[mex];

   //i need a random randomizer restaurant from my 1st category which is mex
   // i need to return the restaurant name
  }
  else if (foodKinds == "asian")
  {
   int Asian = randomNum.Next(0, 10);
   result = asian[Asian];
  }
  else if (foodKinds == " American")
  {
   int American = randomNum.Next(0, 10);
   result = american[American];

  }
  else
  {
   int FastFood = randomNum.Next(0, 10);
   result = fastfood[FastFood];

  }
  return result;

 }


}
