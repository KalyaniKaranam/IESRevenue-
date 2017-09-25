using System;
using System.Collections.Generic;

namespace IESRevenue.Helper
{
    public static class DateManipulation
    {
        public static List<string> DeriveStartDatesFromYearAndQuarter(string year, string quarter)
        {
            List<string> startDates = new List<string>();
            string firstDayOfTheMonth;
            switch (quarter)
            {
                case "ALL":
                    {
                        for (int i = 4; i <= 12; i++)
                        {
                            firstDayOfTheMonth = new DateTime(Convert.ToInt16(year), i, 1).ToString("yyyy-MM-dd");
                            startDates.Add(firstDayOfTheMonth);
                        }
                        for(int i=1;i<=3;i++)
                        {
                            firstDayOfTheMonth = new DateTime(Convert.ToInt16(year), i, 1).ToString("yyyy-MM-dd");
                            startDates.Add(firstDayOfTheMonth);
                        }
                        return startDates;
                    }
                case "Q4":
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            firstDayOfTheMonth = new DateTime(Convert.ToInt16(year), i, 1).ToString("yyyy-MM-dd");
                            startDates.Add(firstDayOfTheMonth);
                        }
                        return startDates;
                    }
                case "Q1":
                    {
                        for (int i = 4; i <= 6; i++)
                        {
                            firstDayOfTheMonth = new DateTime(Convert.ToInt16(year), i, 1).ToString("yyyy-MM-dd");
                            startDates.Add(firstDayOfTheMonth);
                        }
                        return startDates;
                    }
                case "Q2":
                    {
                        for (int i = 7; i <= 9; i++)
                        {
                            firstDayOfTheMonth = new DateTime(Convert.ToInt16(year), i, 1).ToString("yyyy-MM-dd");
                            startDates.Add(firstDayOfTheMonth);
                        }
                        return startDates;
                    }
                case "Q3":
                    {
                        for (int i = 10; i <= 12; i++)
                        {
                            firstDayOfTheMonth = new DateTime(Convert.ToInt16(year), i, 1).ToString("yyyy-MM-dd");
                            startDates.Add(firstDayOfTheMonth);
                        }
                        return startDates;
                    }
            }
            return startDates;
        }
    }
}
