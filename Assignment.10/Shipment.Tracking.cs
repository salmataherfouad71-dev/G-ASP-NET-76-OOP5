using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public partial class Shipment
    {
        public string TrackingStatus { set; get; }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} {TrackingStatus}.";
        }
        public void UpdateTrackingStatus(string status)
        { 
            TrackingStatus=status;
            OnTrackingStatusChanged(status);
        }
        public partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine("Tracking status changed to:"+newStatus);
        }
    }
}
