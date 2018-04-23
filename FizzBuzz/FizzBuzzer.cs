using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzz
{
    public class FizzBuzzer
    {
        string word;

        public string Generate(int value)
        {
            if ((value % 3 == 0) && (value % 5 == 0))
            {
                 word = "FizzBuzz";
                return Convert.ToString(word);
            }       
            
            if (value % 5 == 0)
            {
                 word = "Buzz";
                return Convert.ToString(word);
            }
          
           if(value%3!=0 && value % 5!= 0)
            {
                return Convert.ToString(value);
            }
            else
            {
                 word = "Fizz";
                return Convert.ToString(word);
            }

        }
    }
}
