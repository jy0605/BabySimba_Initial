using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySimba.Extensions
{
    // 확장형은 무조건 static이어야 함
    public static class StringExtensions
    {
        public static bool IsNumeric(this string s) // 사용할때는 "2354".IsNumeric()
        {
            long result;
            return long.TryParse(s, out result);
        }

        public static bool IsDatetime(this string s)
        {
            // null exception 잡아주기
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                DateTime result;
                return DateTime.TryParse(s, out result);
            }
        }


    }
}
