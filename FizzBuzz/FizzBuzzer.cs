using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzz
{
    public class FizzBuzzer
    {

        public string Generate(int value)
        {
            if ((value % 3 == 0) && (value % 5 == 0))
            {
                string word = "FizzBuzz";
                return Convert.ToString(word);
            }       
            
            if (value % 5 == 0)
            {
                string word = "Buzz";
                return Convert.ToString(word);
            }
          
           if(value%3!=0 && value % 5!= 0)
            {
                return Convert.ToString(value);
            }
            else
            {
                string word = "Fizz";
                return Convert.ToString(word);
            }

        }
    }
}
