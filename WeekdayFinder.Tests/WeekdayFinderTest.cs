using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WeekdayFinder.Models;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayFinderTest
  {
    [TestMethod]
    public void Day_ReturnstheDay_String()
    {
      string expected = "Thursday";
      WeekdayFinderClass wkd = new WeekdayFinderClass("08/10/2017");
      string actual = wkd.Day();
      Assert.AreEqual(expected, actual)
    }
  }
}
