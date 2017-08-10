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
    public string GetDate()
    {
      return _date;
    }
    public string Day()
    {
      DateTime date = new DateTime(_date);
      string day = date.DayOfWeek.ToString();
      return day;
    }
  }
}
