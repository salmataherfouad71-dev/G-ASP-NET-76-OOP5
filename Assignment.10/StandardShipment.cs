using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public class StandardShipment:Shipment,ITrackable,IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 5 / 100;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment :");
            Console.WriteLine($"Tracking Code:{TrackingCode}\nDescription:{Description}\nWeight:{Weight}\nDelivery Fee:{DeliveryFee}");
            Console.WriteLine($"Estimated Cost:{EstimatedCost}");
        }
        public override Shipment DeepCopy()
        {
            return new StandardShipment(TrackingCode,Description,Weight,DeliveryFee,new DeliveryAddress(destination.City,destination.Street,destination.BuildingNumber));
        }
    }
}
