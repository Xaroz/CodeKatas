using System;
using System.Collections.Generic;

namespace CodeKatas
{
    public class Day1
    {
        public string Add(params string [] numbers)
        {
            double sum = 0;
            foreach (string number in numbers)
            {
                
                if (string.IsNullOrEmpty(number))
                {
                    continue;
                }                                                      
                else
                {
                    string new_delimiter = "";
                    if (number[0] == '\\' && number[1] == '\\')
                    {
                        int counter = 0;
                        for (int i = 2; i < number.Length; i++)
                        {
                            if (counter > 0 && number[i] == '\n')
                                break;
                            new_delimiter += number[i];
                            counter++;
                        }
                    }
                    //stopped here                   
                    if (number[number.Length - 1] == ',' || number[number.Length - 1] == '\n')
                        throw new Exception("Number expected but EOF found");
                    string[] x = number.Split(new string[] {"," , "\n"}, StringSplitOptions.None);
                    for (int i = 0; i < x.Length; i++) 
                    {
                        if (String.IsNullOrEmpty(x[i]))
                            throw new Exception("Number expected but delimiter found at position " + i);
                        double y = Convert.ToDouble(x[i]);                      
                        sum += y;
                    }
                }

            }                           
            string ans = Convert.ToString(sum);
            return ans;
        }


    }
}
