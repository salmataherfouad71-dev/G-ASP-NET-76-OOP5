using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public class ExpressShipment:Shipment,ITrackable,IInsurable
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 8 / 100;
        }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment :");
            Console.WriteLine($"Tracking Code:{TrackingCode}\nDescription:{Description}\nWeight:{Weight}\nDelivery Fee:{DeliveryFee}");
            Console.WriteLine($"Extra Fee:{ExtraFee}\nEstimated Cost:{EstimatedCost}");
        }
        public override Shipment DeepCopy()
        {
            return new ExpressShipment(TrackingCode,Description, Weight,DeliveryFee,new DeliveryAddress(destination.City,destination.Street,destination.BuildingNumber),ExtraFee);
        }
    }
}
