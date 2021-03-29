using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Rohab
{
    public static class Date
    {
        private static string currentDate;

        public static void currentDate_Setter()
        {
             string d, m, y;
            d = DateTime.Today.Date.Day.ToString();
            m = DateTime.Today.Date.Month.ToString();
            y = DateTime.Today.Date.Year.ToString();
            currentDate = Shamsi(y + '/' + m + '/' + d);
        }

        public static string currentDate_Getter()
        {
            return currentDate;
        }

        public static string Shamsi(string date)
        {
            int[] arrMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] arrStart = { 21, 20, 21, 21, 22, 22, 23, 23, 23, 23, 22, 22 };
            char[] sep = { '/' };
            string[] arrDate = date.Split(sep);
            int year = Convert.ToInt32(arrDate[0]);
            int month = Convert.ToInt32(arrDate[1]);
            int day = Convert.ToInt32(arrDate[2]);
            if (year % 4 == 0)
            {
                for (int i = 2; i < 12; i++)
                    arrStart[i]--;
                arrMonths[1]++;
                if (month == 1) arrStart[11]++;
            }
            else if (year % 4 == 1)
            {
                arrStart[0]--;
                arrStart[1]--;
                if (month == 1) arrStart[11]--;
            }
            year = month <= 3 ? year - 622 : year - 621;
            if (month == 3 && day >= arrStart[2]) year++;
            if (day < arrStart[month - 1])
            {
                int i = month == 1 ? 11 : month - 2;
                day = day - arrStart[i] + arrMonths[i] + 1;
                month -= 3;
            }
            else
            {
                day = day - arrStart[month - 1] + 1;
                month -= 2;
            }
            if (month <= 0) month += 12;
            return year + "/" + Convert.ToString(month).PadLeft(2, '0') + "/" +
            Convert.ToString(day).PadLeft(2, '0');
       }

        public static string Shamsiwithtime(DateTime dateTime)
        {
            string date = dateTime.ToShortDateString();
            int[] arrMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] arrStart = { 21, 20, 21, 21, 22, 22, 23, 23, 23, 23, 22, 22 };
            char[] sep = { '/' };
            string[] arrDate = date.Split(sep);
            int month = Convert.ToInt32(arrDate[0]);
            int day = Convert.ToInt32(arrDate[1]);
            int year = Convert.ToInt32(arrDate[2]);
            if (year % 4 == 0)
            {
                for (int i = 2; i < 12; i++)
                    arrStart[i]--;
                arrMonths[1]++;
                if (month == 1) arrStart[11]++;
            }
            else if (year % 4 == 1)
            {
                arrStart[0]--;
                arrStart[1]--;
                if (month == 1) arrStart[11]--;
            }
            year = month <= 3 ? year - 622 : year - 621;
            if (month == 3 && day >= arrStart[2]) year++;
            if (day < arrStart[month - 1])
            {
                int i = month == 1 ? 11 : month - 2;
                day = day - arrStart[i] + arrMonths[i] + 1;
                month -= 3;
            }
            else
            {
                day = day - arrStart[month - 1] + 1;
                month -= 2;
            }
            if (month <= 0) month += 12;
            return (year + "/" + Convert.ToString(month).PadLeft(2, '0') + "/" +
            Convert.ToString(day).PadLeft(2, '0') + " " + DateTime.Now.ToString("HH:mm"));
        }

        public static int returnYearOfCurrentDate()
        {
            int yearNo = int.Parse(currentDate_Getter().Substring(0, 4));
            return yearNo;
        }

        public static int returnMonthOfCurrentDate()
        {
            int monthNo = int.Parse(currentDate_Getter().Substring(5, 2));
            return monthNo;
        }

        public static int returnDayOfCurrentDate()
        {
            int dayNo = int.Parse(currentDate_Getter().Substring(8, 2));
            return dayNo;
        }

        public static int returnYearOfInputDate(string inputDate)
        {
            if (inputDate.Trim().Length < 10)
                return 1400;

            int yearNo = int.Parse(inputDate.Substring(0, 4));
            return yearNo;
        }
 
        public static int returnMonthOfInputDate(string inputDate)
        {
            if (inputDate.Trim().Length < 10)
                return 0;

            int monthNo = int.Parse(inputDate.Substring(5, 2));
            return monthNo;
        }
        
        public static int returnDayOfInputDate(string inputDate)
        {
            int dayNo = int.Parse(inputDate.Substring(8, 2));
            return dayNo;
        }

        public static string returnLastDateOfaDate(string inputDate)
        {
            if (inputDate.Trim().Length < 10)
                return "";

            string lastYear= inputDate.Substring(0, 4);
            string lastMonth = inputDate.Substring(5, 2);
            string lastDay = "";

            if (int.Parse( lastMonth)>= 1 && int.Parse(lastMonth)<=6)
                lastDay = lastDay + "/31";
            else
                lastDay = lastDay + "/30";

            return lastYear+lastMonth+lastDay;
        }

        public static string returnLastDateOfaDate(string inputDate, int monthIndex)
        {
            string lastYear = inputDate.Substring(0, 4);
            string lastMonth = (monthIndex + 1).ToString("00");
            string lastDay = "";

            if (int.Parse(lastMonth) >= 1 && int.Parse(lastMonth) <= 6)
                lastDay = lastDay + "/31";
            else
                lastDay = lastDay + "/30";

            return lastYear + lastMonth + lastDay;
        }
    }
}
