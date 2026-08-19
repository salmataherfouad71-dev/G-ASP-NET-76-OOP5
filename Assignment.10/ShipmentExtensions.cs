using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType;
            if (shipment.GetType() == typeof(StandardShipment))
                shipmentType = "Standard";
            else if (shipment.GetType() == typeof(ExpressShipment))
                shipmentType = "Express";
            else
                shipmentType = "International";
            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} | {shipment.TrackingStatus}";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment.TrackingStatus == "Is Delivered")
                return true;
            else
                return false;
        }
    }
}
