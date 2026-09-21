using System.Reflection.Metadata.Ecma335;
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
        public ActionResult<string> GetSum(string num1, string num2)
        // public string Sum(string num1, string num2)
        {
            bool isConverted1 = int.TryParse(num1, out int actualNum1);
            bool isConverted2 = int.TryParse(num2, out int actualNum2);
            if (isConverted1 == true && isConverted2 == true)
            {
                return Ok($"{actualNum1} + {actualNum2} = {actualNum1 + actualNum2}!");
            }
            else
            {
                return NotFound($"Error: One of your numbers are not valid! Try Again!");
            }
        }

        [HttpGet]//Time
        [Route("giveyourname/{name}/awaketime/{time}")]
        public string Time(string name, string time)
        {
            return $"So your name is {name} and you woke up at {time}.";
        }


        [HttpGet("compare2nums/{num3}/{num4}")]//Greater or Less
        public ActionResult<string> GetCompare(string num3, string num4)
        //public string Compare(string num3, string num4)
        {
            bool isConverted3 = int.TryParse(num3, out int actualNum3);
            bool isConverted4 = int.TryParse(num4, out int actualNum4);
            if (isConverted3 && isConverted4)
            {
                if (actualNum3 > actualNum4)
                {
                    return Ok($"{actualNum3} is greater than {actualNum4} and {actualNum4} is lesser than {actualNum3}!");
                }
                else if (actualNum3 < actualNum4)
                {
                    return Ok($"{actualNum3} is lesser than {actualNum4} and {actualNum4} is greater than {actualNum3}!");
                }
                else
                {
                    return Ok($"{actualNum3} and {actualNum4} are both equal!");
                }
            }
            else
            {
                return NotFound("Error: Invalid numbers! Try again!");
            }
        }
        [HttpGet("madlib/{word1}/{word2}/{word3}/{word4}/{word5}/{word6}/{word7}/{word8}/{word9}/{word10}")]//MadLib
        public string MadLib(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10)
        {  
        return $"Bats are so cool! They are {word1}, {word2} animals which have wings. They like to fly around at {word3} which makes some people scared of them. But bats are {word4}, and they don't want to hurt people. I have a pet bat that lives in {word5}. I like to feed him {word6} and {word7}. He likes to {word8}. I am his favorite person, but he also likes {word9}. I want to convince my parents to get me {word10} more bats.";
        }
    }
}