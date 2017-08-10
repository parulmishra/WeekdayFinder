using System;
using System.Collections.Generic;


namespace WeekdayFinder.Models
{
  public class WeekdayFinderClass
  {
    private string _date;
    public WeekdayFinderClass(string date)
    {
      _date = date;
    }
    public string Day()
    {
      string day = "";
      DateTime date = new DateTime(_date);
      DateTime.Parse(date);
      day = date.DayOfWeek;
      return day;
    }
  }
}
