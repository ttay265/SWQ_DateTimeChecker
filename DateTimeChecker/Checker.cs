using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker
{
    public class Checker
    {
        public static int DateInMonth(byte month, short year = 0)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7
                || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            if (month == 2)
            {
                if (year % 400 == 0)
                {
                    return 29;
                }
                else if (year % 100 == 0)
                {
                    return 28;
                }
                else if (year % 4 == 0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else
            {
                return 0;
            }
        }

        public static bool IsValidDate(short Year, byte Month, byte Day)
        {
            if (Month >= 1 && Month <= 12)
            {
                if (Day >= 1)
                {
                    if (Day <= DateInMonth(Month, Year))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
