using System;

namespace Assignment2_Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userDict = { "rocky", "usf", "hello", "apple" };
            string keywords = "uaf";
            var result = DictSearch(userDict, keywords);
            Console.WriteLine(result);
        }

         public static bool DictSearch(string[] userDict, string keyword)
          {
             try
             {

             foreach (var item in userDict)
              {
                  //temp is a counter which will check the no. of letters matched. If more than 2 then condition will fail
                  //index is for the string's index
                  int temp = 0, index = 0;
                  while (temp < 2 && index < item.Length && index < keyword.Length)
                  {
                      if (item[index] != keyword[index] && item.Length == keyword.Length)  
                          //if the keyword index is not equal to item's index and 
                          //Length of both should be same. 
                          temp++;
                      index++;
                  }
                  if (temp < 2 && temp != 0)
                      return true;
              }
              return false;
          }
    }
}
    

