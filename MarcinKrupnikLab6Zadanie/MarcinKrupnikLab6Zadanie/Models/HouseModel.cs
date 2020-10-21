using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinKrupnikLab6Zadanie.Models
{
    public class HouseModel
    {
        public string Type { get; set; }
        public int Area { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public string City { get; set; }
        public HouseModel(string type, int area, int numberOfRooms, decimal price, string city, string photo)
        {
            Type = type;
            Area = area;
            NumberOfRooms = numberOfRooms;
            Price = price;
            City = city;
            Photo = photo;

        }
    }
}
