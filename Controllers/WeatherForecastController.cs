// using Microsoft.AspNetCore.Mvc;

// namespace MartinezCResPickEndPoint.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class WeatherForecastController : ControllerBase
// {
//     private static readonly string[] Summaries = new[]
//     {
//         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//     };

//     private readonly ILogger<WeatherForecastController> _logger;

//     public WeatherForecastController(ILogger<WeatherForecastController> logger)
//     {
//         _logger = logger;
//     }

//     [HttpGet(Name = "GetWeatherForecast")]
//     public IEnumerable<WeatherForecast> Get()
//     {
//         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//         {
//             Date = DateTime.Now.AddDays(index),
//             TemperatureC = Random.Shared.Next(-20, 55),
//             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//         })
//         .ToArray();
//     }
// }




// // //Chris Martinez
// //10/19/22
// // Restaurant Picker #9
// //GitHub Mini Challenges
// //As the final assignemt in this long saga of mini Challenges, I was able to create program that allows the user to select from threes different Categories, of food and the system
// //will hand pick the best 10 restaurant options per category, and if not we can shuffle them all together so the program can pick what's best for ya!



// Console.Clear();
// string[] Restaurant = new string[] { "El Tepeyac", "Los Aburridos", "Montezuma", "Mi Mexico Lindo", "El Stockton", 
// "El Maestro Ken'z Takos", "Los Ricos", "Las Bonitas", "TEPITO", "TacoKing", "Little Tokyo", "Matsuhisa", "Phat Thai", "LoMeinz", "SupremeLederRoll", "YingandYang",
//  "Korean Taquisa", "Kung Lao's", "Lord China", "Fresh Delicacies", "Ken Lee's Noodle", "Maverick's", "German Frankies", "Chicago Dogs", " Two Rivers", "Mezzaluna", "The HeavyHitters", "The Wise Guy", 
//  "Last Frontier Burgers", "Trouts", "BrewPub", "Locals Coner", "Chris's Local spot", "Miller Time", "Whole in the Wall" };
// bool endComida = true;
// Random randomNum = new Random();


// Console.WriteLine("||||||||||||||---- RESTAURANT PICKER----||||||||||||||\n");
// Console.WriteLine("----------------YOU WON'T HAVE TO EVER GO HUNGRY------------");
// Console.WriteLine("-----WE HAVE HAND PICKED THE BEST EATERIES IN THE CITY FOR YOU! ------------");
// Console.WriteLine("-----SELECT FROM THESE 4 CATEGORIES, AND WELL DO THE REST.------------");
// Console.WriteLine("--YOU CAN THANKS US LATER!!!! --------------------------------------------------------\n");
// Console.WriteLine("Press 1  All Eateries\nPress 2 Mexican\nPress 3 FastFood\nPress 4 AsianFusion\nPress \"END\" and enter to quit\n|||||||| ||||||||");


// while (endComida == true)
// {
//     int mexican = randomNum.Next(0, 10);
//     int asian = randomNum.Next(11, 21);
//     int fastFood = randomNum.Next(22, 34);
//     int surpriseMe = randomNum.Next(0, 34);

    
//     string userInput = Console.ReadLine();
//     Console.Clear();

//     switch (userInput)
//     {
//         case "1":
//             Console.WriteLine($"You're New Joint Is... \n\n|||||||| {Restaurant[surpriseMe]} ||||||||\n");
//             break;
//         case "2":
//             Console.WriteLine($"You're New Hang Out is... \n\n|||||||| {Restaurant[mexican]} ||||||||\n");
//             break;
//         case "3":
//             Console.WriteLine($"You're New Table Awaits at... \n\n|||||||| {Restaurant[fastFood]} ||||||||\n");
//             break;
//         case "4":
//             Console.WriteLine($"You're New Favorite Chiil out place is... \n\n|||||||| {Restaurant[asian]} ||||||||\n");
//             break;
//         case "N":
//             endComida = false;
//             break;
//         default:
//             Console.WriteLine("\n |||||||| Incorrect Input ||||||||\n");
//             break;
//     }
// }



// // Console.Clear();
// // Console.WriteLine("||||||||||||||---- RESTAURANT PICKER----||||||||||||||\n");

// // Console.WriteLine("----------------YOU WON'T HAVE TO EVER GO HUNGRY------------\n");

// // Console.WriteLine("-----WE HAVE HAND PICKED THE BEST EATERIES IN THE CITY FOR YOU! ------------\n");

// // Console.WriteLine("-----SELECT FROM THESE 3 CATEGORIES, AND WELL DO THE REST.------------\n");

// // Console.WriteLine("--YOU CAN THANKS US LATER!!!! ----------------------\n");

// // Console.WriteLine("-----1.MEXICAN");
// // Console.WriteLine("-----2.ASIAN FUSION");
// // Console.WriteLine("-----3.FAST FOOD AMERICANA");
// // string food;
// // Console.WriteLine("Enter Number");
// // food = Console.ReadLine();
// // int a = Convert.ToInt32(food);
// // Console.WriteLine("Your input: {0}", a);