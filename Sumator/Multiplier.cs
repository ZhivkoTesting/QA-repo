using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator
{
    public class Multiplier
    {
        public static int multi (int [] nums
            ) {
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            { 
              var curent = nums[i];
              result = result * curent;
            }
            return result;
        }
    }
}
