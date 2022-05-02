using System;

namespace BabySimba.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime firstDateOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }
        public static DateTime lastDateOfMonth(this DateTime date)
        {
            // DateTime.DaysInmonth라는 function 있음. 연 월 정보만 주면 마지막 날짜를 return.
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
    }
}
