using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
   public class Palindrome
    {
        public long GetPalindrome() {
            var i = Enumerable.Range(1, 999);
            var j = i.SelectMany(x => i, (x, y) => {
                return (x * y).ToString();
               
            }).Where (x=> x == string.Join(string.Empty,x.Reverse())).Select(x=>Convert.ToInt32(x)).Max();
            return 1;
        }
      
    }
}
