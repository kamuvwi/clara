using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations
{
    public class Mode
    {
        public static dynamic Mod(dynamic vArray)
        {
            int arraylen = Helpers.Array.ArrayLength(vArray);
            //dynamic[] vArray = new dynamic[arraylen];
            // Sort the array 
            Array.Sort(vArray);

            // find the max frequency using  
            // linear traversal 
            int max_count = 1, res = vArray[0];
            int curr_count = 1;

            for (int i = 1; i < arraylen; i++)
            {
                if (vArray[i] == vArray[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = vArray[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent 
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = vArray[arraylen - 1];
            }

            return res;


        }
    }
}
