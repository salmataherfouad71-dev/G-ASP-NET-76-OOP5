using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public class InternationalShipment:Shipment,ITrackable,IInsurable
    {
        private string destinationCountry;
        private decimal customsFee;
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }
        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 12 / 100;
        }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment :");
            Console.WriteLine($"Tracking Code:{TrackingCode}\nDescription:{Description}\nWeight:{Weight}\nDelivery Fee:{DeliveryFee}");
            Console.WriteLine($"Destination Country:{DestinationCountry}\nCustoms Fee:{CustomsFee}");
            Console.WriteLine($"Estimated Cost:{EstimatedCost}");
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Report from internaitonl Shipment!");
        }
        public override Shipment DeepCopy()
        {
            return new InternationalShipment(TrackingCode,Description,Weight,DeliveryFee,new DeliveryAddress(destination.City,destination.Street,destination.BuildingNumber),DestinationCountry,CustomsFee);
        }
    }
}
