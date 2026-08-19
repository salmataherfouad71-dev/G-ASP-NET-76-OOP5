using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._10
{
    public class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[20];
        public string centerName { set; get; }
        public Driver Driver { set; get; }
        public Shipment this[int index]
        {
            get
            {
                if (index > 20 || index < 0)
                    return default;
                else
                    return shipments[index];
            }
            set
            {
                if (index >= 0 && index <= 20)
                    shipments[index] = value;
            }
        }
        public Shipment this[string code]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment?.TrackingCode == code)
                        return shipment;
                }
                return default;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            int counter = 0;
            foreach (Shipment item in shipments)
            {
                if (string.IsNullOrWhiteSpace(item?.TrackingCode))
                {
                    shipments[counter] = shipment;
                    Console.WriteLine("Shipment Added Successfully!");
                    return true;
                }
                counter++;
            }
            return false;
        }
        public bool RemoveShipment(string code)
        {
            int counter = 0;
            foreach (Shipment item in shipments)
            {
                if (item.TrackingCode == code)
                {
                    shipments[counter] = default;
                    Console.WriteLine("Shipment Removed Successfully!");
                    foreach (Shipment item2 in shipments)
                    {
                        int counter2 = 1;
                        if (item2 != null)
                        {
                            Shipment[] shipments = new Shipment[counter2];
                            shipments[counter2 - 1] = item2;
                        }
                    }
                    return true;
                }
                counter++;
            }
            return false;
        }
        public void PrintAllShipments()
        {
            int counter = 1;
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    Console.WriteLine($"Shipment number{counter} ");
                    shipment.PrintShipment();
                    Console.WriteLine("-------------------");
                    counter++;
                }
            }
        }
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine(shipment.CalculateInsurance());
        }
        public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in shipments)
            {
                if (t != null)
                {
                    Console.Write("Tracking Statuses:");
                    Console.WriteLine(t.GetTrackingStatus());
                }
            }
        }
        public void PrintInsurance()
        {
            foreach (IInsurable i in shipments)
            {
                if (i != null)
                {
                    Console.WriteLine($"Insurance:{i.CalculateInsurance()}");
                }
            }
        }
    }
}
