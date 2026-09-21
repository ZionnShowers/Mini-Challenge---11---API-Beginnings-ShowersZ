//Zionn Showers
//9-21-2026
//Mini Challenge # 11 - API Beginnings
//I basically looked back at the original code to see how I could input the same code but into an API format. I made the user input have the ability to enter their name, add two numbers together, and say the time they wake up.
//Peer Review:
//Review:
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge___11___API_Beginnings.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewApiController : ControllerBase
    {
        [HttpGet]//Hello
        [Route("enterfirstname/{firstname}/enterlastname/{lastname}")]
        public string Name(string firstname, string lastname)
        {
            return $"Hello {firstname} {lastname}!";
        }

        [HttpGet]//Adding 2 numbers
        [Route("addnum1/{num1}/addnum2/{num2}")]
        public string Sum(string num1, string num2)
        {
        bool isConverted1 = int.TryParse(num1, out int actualNum1);
        bool isConverted2 = int.TryParse(num2, out int actualNum2);
        if (isConverted1 == true && isConverted2 ==true)
            {
            return $"{actualNum1} + {actualNum2} = {actualNum1 + actualNum2}!";
            }
        else
            {
            return "Error: One of your numbers are not valid! Try Again!";
            }
        }
        [HttpGet]//Time
        [Route("giveyourname/{name}/awaketime/{time}")]
        public string Time(string name, string time)
        {
            return $"So your name is {name} and you woke up at {time}.";
        }
    }
}