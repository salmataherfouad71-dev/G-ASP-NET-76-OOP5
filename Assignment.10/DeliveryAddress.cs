using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public class DeliveryAddress
    {
        public string City { set; get; }
        public string Street { set; get; }
        public int BuildingNumber { set; get; }
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"City:{City}\nStreet:{Street}\nBuilding Number:{BuildingNumber}";
        }
        public override string ToString()
        {
            return $"City:{City}\nStreet:{Street}\nBuilding Number:{BuildingNumber}";
        }
    }
}
