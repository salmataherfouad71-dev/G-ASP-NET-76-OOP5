using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public abstract partial class Shipment:ITrackable
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public static int TotalShipmentsCreated;
        public DeliveryAddress destination { set; get; }
        public string TrackingCode
        {
            protected set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
            get { return trackingCode; }
        }
        public string Description
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
            get { return description; }
        }
        public decimal Weight
        {
            set
            {
                if (value >= 0)
                    weight = value;
            }
            get { return weight; }
        }
        public decimal DeliveryFee
        {
            protected set
            {
                if (value > 0)
                    deliveryFee = value;
            }
            get { return deliveryFee; }
        }
        public abstract decimal EstimatedCost { get; }
        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            destination = default;
            TrackingStatus = "No Information";
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Weight = weight;
            Description = description;
            DeliveryFee = deliveryFee;
            this.destination = destination;
            TotalShipmentsCreated++;
        }
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized...");
        }
        public void UpdateDiliveryFee(decimal newFee)
        {
            if (newFee > 0)
                deliveryFee = newFee;
        }
        public abstract void PrintShipment();
        public void UpdateWeight(decimal weight)
        {
            Weight = weight;
        }
        public void UpDateWeight(decimal weight, decimal extra)
        {
            Weight = weight + extra;
        }
        public Shipment CopyShipment()
        {
            return this;
        }
        public Shipment ShallowCopy()
        { 
            return (Shipment)this.MemberwiseClone() ;
        }
        public abstract Shipment DeepCopy();
     
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        public partial void OnTrackingStatusChanged(string newStatus);
    }
}
