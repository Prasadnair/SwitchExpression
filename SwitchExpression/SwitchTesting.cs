using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExpression
{
    internal class SwitchTesting
    {


        public static string GetWeekDayByNumberUsingSwitchCase(int day)
        {
            var weekDay = string.Empty;
            switch (day)
            {
                case 1:
                    weekDay = "Monday";
                    break;
                case 2:
                    weekDay = "Tuesday";
                    break;
                case 3:
                    weekDay = "Wednesday";
                    break;
                case 4:
                    weekDay = "Thursday";
                    break;
                case 5:
                    weekDay = "Friday";
                    break;
                case 6:
                    weekDay = "Saturday";
                    break;
                case 7:
                    weekDay = "Sunday";
                    break;
                default:
                    weekDay = "Sorry, Its hard to find";
                    break;
            }
            return weekDay;
        }

        public static string GetWeekDayByNumberUsingSwitchExpression(int day)
        {
            var dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Sorry, Its hard to find"
            };
            return dayName;
        }
    }
}
