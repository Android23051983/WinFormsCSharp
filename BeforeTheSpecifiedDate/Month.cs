using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeTheSpecifiedDate
{
    internal static class YearsMonths
    {
        public static void GetYearsMonthsDays(DateTime EndDate, DateTime BeginDate, out int years, out int months, out int days)
        {
            var beginMonthDays = DateTime.DaysInMonth(BeginDate.Year, BeginDate.Month);
            var endMonthDays = DateTime.DaysInMonth(EndDate.Year, EndDate.Month);
            // get the full years
            years = EndDate.Year - BeginDate.Year - 1;
            // how many full months in the first year
            var firstYearMonths = 12 - BeginDate.Month;
            // how many full months in the last year
            var endYearMonths = EndDate.Month - 1;
            // full months
            months = firstYearMonths + endYearMonths;
            days = 0;
            // Particular end of month cases
            if (beginMonthDays == BeginDate.Day && endMonthDays == EndDate.Day)
            {
                months++;
            }
            else if (beginMonthDays == BeginDate.Day)
            {
                days += EndDate.Day;
            }
            else if (endMonthDays == EndDate.Day)
            {
                days += beginMonthDays - BeginDate.Day;
            }
            // For all the other cases
            else if (EndDate.Day > BeginDate.Day)
            {
                months++;
                days += EndDate.Day - BeginDate.Day;
            }
            else if (EndDate.Day < BeginDate.Day)
            {
                days += beginMonthDays - BeginDate.Day;
                days += EndDate.Day;
            }
            else
            {
                months++;
            }
            if (months >= 12)
            {
                years++;
                months = months - 12;
            }
        }

        public static void GetMonthsDays(DateTime EndDate, DateTime BeginDate, out int months, out int days)
        {
            var beginMonthDays = DateTime.DaysInMonth(BeginDate.Year, BeginDate.Month);
            var endMonthDays = DateTime.DaysInMonth(EndDate.Year, EndDate.Month);
            var firstYearMonths = 12 - BeginDate.Month;
            var endYearMonths = EndDate.Month - 1;
            months = firstYearMonths + endYearMonths;
            days = 0;
            if (beginMonthDays == BeginDate.Day && endMonthDays == EndDate.Day)
            {
                months++;
            }
            else if (beginMonthDays == BeginDate.Day)
            {
                days += EndDate.Day;
            }
            else if (endMonthDays == EndDate.Day)
            {
                days += beginMonthDays - BeginDate.Day;
            }
            // For all the other cases
            else if (EndDate.Day > BeginDate.Day)
            {
                months++;
                days += EndDate.Day - BeginDate.Day;
            }
            else if (EndDate.Day < BeginDate.Day)
            {
                days += beginMonthDays - BeginDate.Day;
                days += EndDate.Day;
            }
            else
            {
                months++;
            }
            if (months >= 12)
            {
                months = months - 12;
            }


        }
    }
}
