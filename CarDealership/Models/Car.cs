using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private string _year;
    private int _price;
    private int _miles;

    private static List<Car> _instances = new List<Car>(){};

    public Car (string makeModel, string year, int price, int miles)
    {
      _makeModel = makeModel;
      _year = year;
      _price = price;
      _miles = miles;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetYear()
    {
      return _year;
    }
    public void SetYear(string newYear)
    {
      _year = newYear;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public static List<Car> GetList()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

  }
}
