namespace Assignment._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            /*
             a)If it a value type is copies the value,but if it reference type it copies 
               the reference (address).
             b)No,If it a value type it just change the value of the object.If it is a
               reference type it just starts pointing to the assigned object.
             c)Object Copying:It creates a new independent object(shallow-deap) .
               Reference Copying:It just copies the address (assignment)*/
            #endregion
            #region Question02
            /*
             a)Shallow Copy:It creates a new object that copies the values of value types
               and the address of the reference types.
             b)Deap Copy:It creates a completely new object that copies all the values of the data.
             c)It just copy the address so the changes in the new object will affect the original 
               variable except for the string (because it is immutable).
             d)It copy its value so the changes in the new object will never affect the original variable.
             e)Deap copy is safer when you want to edit the data and you don't want those
               changes to accidentally break or alter the original object.*/
            #endregion
            #region Question03
            /*
             a)-A static field belongs to the class not to the object,so no need to create
               an object in order to access it,and we access it using the class name.
               -A instance field belongs to the object.Its value differ from one object to 
               another, and we access it using the object name.
             b)A static method is a method that belongs to the class and its behavior does not 
               change from one object to another.We call it using the class name.
               No.
             c)A static constructor is a parameterless constructor.We use it to initialize
               fields.It starts executing automatically with the first use of the class.
             d)A static class is a class that every member in it is static.No you cannot 
               create an object from a static class.*/
            #endregion
            #region Question04
            /*
             a)Extension Method:It is a method that allow you to add new methods to an existing data type
                without modifying the original source code.
             b)this.
             c)In a static class.
             d)No.*/
            #endregion
            #region Question05
            /*
             a)It a class that can be split across two or more files.
             b)This makes the code easy to read and maintain.Also Partial Class is used
              when there is more than one developer are working with the same project. 
             c)Partial Methods are methods that can be declared in one partial class and 
               implemented in the other part.
             d)The c# compiler remove it so there is no error.*/
            #endregion
            #endregion
            #region Part02
            DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");
            DeliveryCenter center = new DeliveryCenter();
            Console.Write("Enter Tracking Code:");
            string standardTrackingCode = Console.ReadLine();
            Console.Write("Enter Description:");
            string standardDescription = Console.ReadLine();
            Console.Write("Enter Wight:");
            decimal StandardWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Delivery Fee:");
            decimal StandardDeliveryFee = decimal.Parse(Console.ReadLine());
            Console.Write("Enter City:");
            string standardcity = Console.ReadLine();
            Console.Write("Enter Street:");
            string standardStreet = Console.ReadLine();
            Console.Write("Enter Building Number:");
            int standardBuildingNumber = int.Parse(Console.ReadLine());
            StandardShipment standard = new StandardShipment(standardTrackingCode, standardDescription, StandardWeight, StandardDeliveryFee, new DeliveryAddress(standardcity, standardStreet, standardBuildingNumber));
            center.AddShipment(standard);
            DeliveryUtilities.PrintSeparator();
            Console.Write("Enter Tracking Code:");
            string ExpressTrackingCode = Console.ReadLine();
            Console.Write("Enter Description:");
            string ExpressDescription = Console.ReadLine();
            Console.Write("Enter Wight:");
            decimal ExpressWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Delivery Fee:");
            decimal ExpressDeliveryFee = decimal.Parse(Console.ReadLine());
            Console.Write("Enter City:");
            string Expresscity = Console.ReadLine();
            Console.Write("Enter Street:");
            string ExpressStreet = Console.ReadLine();
            Console.Write("Enter Buildng Number:");
            int ExpressBuildingNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Extra Fee:");
            decimal ExpressExtraFee = decimal.Parse(Console.ReadLine());
            ExpressShipment express = new ExpressShipment(ExpressTrackingCode, ExpressDescription, ExpressWeight, ExpressDeliveryFee, new DeliveryAddress(Expresscity, ExpressStreet, ExpressBuildingNumber), ExpressExtraFee);
            center.AddShipment(express);
            DeliveryUtilities.PrintSeparator();
            Console.Write("Enter Tracking Code:");
            string internationalTrackingCode = Console.ReadLine();
            Console.Write("Enter Description:");
            string internationalDescription = Console.ReadLine();
            Console.Write("Enter Wight:");
            decimal internationalWeight = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Delivery Fee:");
            decimal internationalDeliveryFee = decimal.Parse(Console.ReadLine());
            Console.Write("Enter City:");
            string internationalcity = Console.ReadLine();
            Console.Write("Enter Street:");
            string internationalStreet = Console.ReadLine();
            Console.Write("Enter Buildng Number:");
            int internationalBuildingNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Destination Country:");
            string destination = Console.ReadLine();
            Console.Write("Enter Customs Fee:");
            decimal customsFee = decimal.Parse(Console.ReadLine());
            InternationalShipment international = new InternationalShipment(internationalTrackingCode, internationalDescription, internationalWeight, internationalDeliveryFee, new(internationalcity, internationalStreet, internationalBuildingNumber), destination, customsFee);
            center.AddShipment(international);
            DeliveryUtilities.PrintSeparator();
            center.PrintAllShipments();
            Console.WriteLine("Total Shipments Created:"+Shipment.GetTotalShipmentsCreated());
            DeliveryUtilities.PrintSystemTitle("Object Copying");
            StandardShipment standard1 = standard;
            Console.WriteLine("Original Shipment : " + standard.TrackingCode);
            Console.WriteLine("Assigned Shipment : " + standard1.TrackingCode);
            Console.WriteLine("Same Object : True");
            DeliveryUtilities.PrintSystemTitle("Shallow Copy");
            Shipment standard2=standard.ShallowCopy();
            Console.WriteLine("Original Shipment Address : " + standard.destination.City);
            Console.WriteLine("Copied Shipment Address : " + standard2.destination.City);
            Console.WriteLine("Changing copied shipment address...");
            standard2.destination.City = "Giza";
            Console.WriteLine("Original Shipment Address : " + standard.destination.City);
            Console.WriteLine("Copied Shipment Address : " + standard2.destination.City);
            Console.WriteLine("Same DeliveryAddress Object : True");
            DeliveryUtilities.PrintSystemTitle("Deep Copy");
            Shipment standard3 = standard.DeepCopy();
            Console.WriteLine("Original Shipment Address : " + standard.destination.City);
            Console.WriteLine("Copied Shipment Address : " + standard3.destination.City);
            Console.WriteLine("Changing copied shipment address...");
            standard3.destination.City = "Cairo";
            Console.WriteLine("Original Shipment Address : " + standard.destination.City);
            Console.WriteLine("Copied Shipment Address : " + standard3.destination.City);
            Console.WriteLine("Same DeliveryAddress Object : False");
            DeliveryUtilities.PrintSystemTitle("Extension Methods");
            standard.TrackingStatus = "Is Delivered";
            express.TrackingStatus = "Out For Delivery";
            international.TrackingStatus = "Is Ready";
            standard.GetSummary();
            express.GetSummary();
            international.GetSummary();
            Console.WriteLine($"{standard.TrackingCode} Is Delivered :{standard.IsDelivered()}");
            Console.WriteLine($"{international.TrackingCode} Is Delivered :{international.IsDelivered()}");
            DeliveryUtilities.PrintSystemTitle("Tracking Status");
            international.UpdateTrackingStatus("Out For Delivery");
            DeliveryUtilities.PrintSystemTitle("Static Utilities");

            #endregion
        }
    }
}
