using Microsoft.AspNetCore.Mvc;

namespace ArraysApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ArrayController : ControllerBase
{
   //declare an array with Random Numbers
   int [] myNumbers = {1, 4, 777, 78, 44, 33, 99, 102, 342};

   [HttpGet]
   [Route("Even")]
   
   public int[] GetEvenNumbers ()
   {

    //we are prefiling this array with zeros
    //then add even numbers into our evenNumbers array
    int[] evenNumbers = new int[myNumbers.Length];

    for(int i = 0; i < myNumbers.Length; i++)
    {
     if(myNumbers[i] % 2 == 0)
    {
      //the number is even
      //add the even number to evennumbers array

      evenNumbers[i] = myNumbers[i];

    }

    }
    return evenNumbers;


   }

   [HttpGet]
   [Route("EvenList")]

   public List<int> GetEvenNumbersByList()
   {
    List<int> evenList = new List<int>();

    for(int i = 0; i < myNumbers.Length; i++)
    {
     if(myNumbers[i] % 2 == 0)
     {
      //the number is even
     //add the number to the even list
    evenList.Add(myNumbers[i]);

     }
    
    }
     return evenList;

   }
}
