using System;
using System.Collections.Generic;

namespace ShippingCompany.Models
{

  public class Parcel
  {

    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Weight { get; set; }
    public string Name { get; set; }

    private static List<Parcel> _parcels = new List<Parcel> { };

    public Parcel(int height, int length, int width, int weight, string name)
    {
      Height = height;
      Length = length;
      Width = width;
      Weight = weight;
      Name = name;
      _parcels.Add(this);
    }
    public static List<Parcel> GetAll()
    {
      return _parcels;
    }

    public int Volume()
    {
      return (Height * Width * Length);
    }

    public int CostToShip()
    {
      int calcVolume = Volume();
      if (calcVolume < 150 && Weight < 10)
        return 5;
      if (calcVolume > 150 && Weight < 10)
        return 8;
      if (calcVolume > 150 && Weight > 10)
        return 15;
      else
        return 0;
    }

  }
}