namespace OOP.Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01

            /// 01) What is the difference between Method Overloading and Method Overriding?
            ///
            /// 
            /// Method Overloading means having multiple methods with the same name
            /// but different parameters.
            ///
            /// Method Overriding means that a child class provides a new implementation
            /// for a virtual method inherited from the parent class.
            ///
            /// Example:
            ///
            /// public void UpdateWeight(double newWeight)
            /// {
            /// }
            ///
            /// public void UpdateWeight(double newWeight, double extraPackingWeight)
            /// {
            /// }
            ///
            /// // The two methods have the same name but different parameters.
            /// // This is Method Overloading.

            #endregion


            #region Question02

            /// 02) What is the difference between Static Binding and Dynamic Binding?
            ///
            /// Answer:
            /// Static Binding means that the method to execute is determined at compile time.
            ///
            /// Dynamic Binding means that the method to execute is determined at runtime
            /// according to the actual object type.
            ///
            /// Example:
            ///
            /// Shipment shipment = new ExpressShipment();
            /// shipment.PrintShipment();
            ///
            /// // The variable type is Shipment.
            /// // The actual object type is ExpressShipment.
            /// // ExpressShipment.PrintShipment() is called at runtime.
            /// // This is Dynamic Binding.

            #endregion

            #region Question03

            /// 03) What is the purpose of the sealed keyword when applied to a class?
            ///
            ///
            /// The sealed keyword prevents other classes from inheriting from the class.
            ///
            /// Example:
            ///
            /// public sealed class CompletedShipment : Shipment
            /// {
            /// }
            ///
            /// // CompletedShipment can inherit from Shipment.
            /// // But another class cannot inherit from CompletedShipment.

            #endregion



            #region Question04

            /// 04) What is the difference between a sealed class and a sealed method?
            ///
            /// 
            /// A sealed class prevents other classes from inheriting from it.
            ///
            /// A sealed method prevents child classes from overriding that method again.
            ///
            /// Example:
            ///
            /// public sealed class CompletedShipment : Shipment
            /// {
            /// }
            ///
            /// public sealed override string GenerateCustomsReport()
            /// {
            ///     return "Customs Report";
            /// }
            ///
            /// // The sealed class cannot be inherited.
            /// // The sealed method cannot be overridden again.

            #endregion

            #region Question05

            /// 05) Can a sealed method be overridden? Why?
            ///
            /// Answer:
            /// No, a sealed method cannot be overridden.
            ///
            /// The sealed keyword prevents further child classes from overriding
            /// the method.
            ///
            /// Example:
            ///
            /// public sealed override string GenerateCustomsReport()
            /// {
            ///     return "Priority Customs Report";
            /// }
            ///
            /// // Another child class cannot override GenerateCustomsReport() again.

            #endregion


            #region Question06

            /// 06) Convert EstimatedCost to a virtual property so each derived class
            /// can calculate its own cost.
            ///
            /// public virtual decimal EstimatedCost
            /// {
            ///     get
            ///     {
            ///         return DeliveryFee + ((decimal)Weight * 5);
            ///     }
            /// }
            ///
            /// // The property is virtual so derived classes can override it.

            #endregion



            #region Question07

            /// 07) Convert PrintShipment() to a virtual method so every child class
            /// can override it.
            ///
            /// public virtual void PrintShipment()
            /// {
            ///     Console.WriteLine("Tracking Code: " + TrackingCode);
            ///     Console.WriteLine("Description: " + Description);
            ///     Console.WriteLine("Weight: " + Weight + " KG");
            ///     Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
            ///     Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
            /// }
            ///
            /// // The virtual keyword allows derived classes to override this method.

            #endregion


            #region Question08

            /// 08) Add two overloaded versions of the weight-update method.
            ///
            /// public void UpdateWeight(double newWeight)
            /// {
            ///     if (newWeight > 0)
            ///         Weight = newWeight;
            /// }
            ///
            /// public void UpdateWeight(double newWeight, double extraPackingWeight)
            /// {
            ///     if (newWeight > 0 && extraPackingWeight >= 0)
            ///         Weight = newWeight + extraPackingWeight;
            /// }
            ///
            /// // The first method updates the weight normally.
            /// // The second method updates the weight after adding packing weight.
            /// // This is Method Overloading.

            #endregion

            #region Question09

            /// 09) Use constructor chaining so every derived class calls the base Shipment constructor.
            ///
            /// public StandardShipment(
            ///     string trackingCode,
            ///     string description,
            ///     double weight,
            ///     decimal deliveryFee,
            ///     DeliveryAddress destination)
            ///     : base(trackingCode, description, weight, deliveryFee, destination)
            /// {
            /// }
            ///
            /// // base(...) calls the constructor of the Shipment class.
            /// // This avoids repeating initialization code.

            #endregion



            #region Question10

            /// 10) Override EstimatedCost in ExpressShipment.
            ///
            /// public override decimal EstimatedCost
            /// {
            ///     get
            ///     {
            ///         return DeliveryFee + ((decimal)Weight * 5) + ExtraFee;
            ///     }
            /// }
            ///
            /// // ExpressShipment adds ExtraFee to the normal shipment cost.

            #endregion


            #region Question11

            /// 11) Override EstimatedCost in InternationalShipment.
            ///
            /// public override decimal EstimatedCost
            /// {
            ///     get
            ///     {
            ///         return DeliveryFee
            ///              + ((decimal)Weight * 5)
            ///              + CustomsFee;
            ///     }
            /// }
            ///
            /// // InternationalShipment adds CustomsFee to the normal shipment cost.

            #endregion




            #region Question12

            /// 12) Override PrintShipment() in every derived class.
            ///
            /// public override void PrintShipment()
            /// {
            ///     Console.WriteLine("Express Shipment");
            ///     Console.WriteLine("Tracking Code: " + TrackingCode);
            ///     Console.WriteLine("Description: " + Description);
            ///     Console.WriteLine("Weight: " + Weight + " KG");
            ///     Console.WriteLine("Delivery Fee: " + DeliveryFee + " EGP");
            ///     Console.WriteLine("Extra Fee: " + ExtraFee + " EGP");
            ///     Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
            /// }
            ///
            /// // Each child class can print its own additional information.

            #endregion



            #region Question13

            /// 13) Create a Driver class and add a Driver property to DeliveryCenter.
            /// This represents Aggregation.
            ///
            /// public class Driver
            /// {
            ///     public int DriverId { get; set; }
            ///     public string FullName { get; set; }
            ///     public string PhoneNumber { get; set; }
            /// }
            ///
            /// public class DeliveryCenter
            /// {
            ///     public Driver Driver { get; set; }
            /// }
            ///
            /// // The Driver can exist independently from DeliveryCenter.
            /// // Therefore, this is Aggregation.

            #endregion


            #region Question14

            /// 14) Every Shipment owns exactly one DeliveryAddress.
            /// This represents Composition.
            ///
            /// public class Shipment
            /// {
            ///     public DeliveryAddress Destination { get; set; }
            /// }
            ///
            /// // DeliveryAddress is used as part of the Shipment.
            /// // The Shipment has its own destination address.
            /// // Therefore, this represents Composition.

            #endregion


            #region Question15

            /// 15) Modify PrintAllShipments() to loop through the Shipment array
            /// and simply call shipment.PrintShipment().
            ///
            /// public void PrintAllShipments()
            /// {
            ///     foreach (Shipment shipment in shipments)
            ///     {
            ///         if (shipment != null)
            ///         {
            ///             shipment.PrintShipment();
            ///             Console.WriteLine();
            ///         }
            ///     }
            /// }
            ///
            /// // No manual type-checking is required.
            /// // The correct PrintShipment() is selected automatically
            /// // using Dynamic Binding.

            #endregion


            #region Question16

            /// 16) Create a DeliveryHelper class with a static PrintShipmentDetails()
            /// method that receives a Shipment.
            ///
            /// public static class DeliveryHelper
            /// {
            ///     public static void PrintShipmentDetails(Shipment shipment)
            ///     {
            ///         if (shipment != null)
            ///         {
            ///             shipment.PrintShipment();
            ///         }
            ///     }
            /// }
            ///
            /// // The method accepts the parent type Shipment.
            /// // The correct overridden method is called automatically.

            #endregion

            #region Question17

            /// 17) Create a sealed CompletedShipment class that inherits from Shipment.
            ///
            /// public sealed class CompletedShipment : Shipment
            /// {
            ///     public CompletedShipment(
            ///         string trackingCode,
            ///         string description,
            ///         double weight,
            ///         decimal deliveryFee,
            ///         DeliveryAddress destination)
            ///         : base(trackingCode, description, weight, deliveryFee, destination)
            ///     {
            ///     }
            /// }
            ///
            /// // The sealed keyword prevents another class from inheriting
            /// // from CompletedShipment.

            #endregion


            #region Question18

            /// 18) In InternationalShipment, add a virtual GenerateCustomsReport() method.
            /// In PriorityInternationalShipment, override it and make the override sealed.
            ///
            /// public virtual string GenerateCustomsReport()
            /// {
            ///     return $"Customs Report: {TrackingCode} - {DestinationCountry}";
            /// }
            ///
            /// public sealed override string GenerateCustomsReport()
            /// {
            ///     return $"Priority Customs Report: {TrackingCode} - {DestinationCountry}";
            /// }
            ///
            /// // virtual allows overriding.
            /// // override changes the implementation.
            /// // sealed prevents further overriding.

            #endregion


            #region Question19

            /// 19) Create a Driver.
            ///
            /// Driver driver = new Driver(
            ///     1,
            ///     "Ahmed Mohamed",
            ///     "01012345678");

            #endregion



            #region Question20

            /// 20) Create a DeliveryCenter and assign the Driver to it.
            ///
            /// DeliveryCenter center = new DeliveryCenter();
            ///
            /// center.Driver = driver;

            #endregion



            #region Question21

            /// 21) Create one StandardShipment.
            ///
            /// DeliveryAddress address1 =
            ///     new DeliveryAddress("Cairo", "Tahrir Street", 15);
            ///
            /// StandardShipment standardShipment =
            ///     new StandardShipment(
            ///         "SH001",
            ///         "Laptop",
            ///         3,
            ///         80,
            ///         address1);

            #endregion



            #region Question22

            /// 22) Create one ExpressShipment.
            ///
            /// DeliveryAddress address2 =
            ///     new DeliveryAddress("Giza", "Dokki Street", 20);
            ///
            /// ExpressShipment expressShipment =
            ///     new ExpressShipment(
            ///         "SH002",
            ///         "Mobile Phone",
            ///         2,
            ///         60,
            ///         address2,
            ///         30);

            #endregion



            #region Question23

            /// 23) Create one InternationalShipment.
            ///
            /// DeliveryAddress address3 =
            ///     new DeliveryAddress("Cairo", "Nasr City", 30);
            ///
            /// InternationalShipment internationalShipment =
            ///     new InternationalShipment(
            ///         "SH003",
            ///         "Television",
            ///         8,
            ///         120,
            ///         address3,
            ///         "Germany",
            ///         100);

            #endregion



            #region Question24

            /// 24) Add all shipments to the DeliveryCenter.
            ///
            /// center.AddShipment(standardShipment);
            /// center.AddShipment(expressShipment);
            /// center.AddShipment(internationalShipment);

            #endregion




            #region Question25

            /// 25) Print all shipments using PrintAllShipments().
            ///
            /// center.PrintAllShipments();
            ///
            /// // The method uses the Shipment array.
            /// // Dynamic Binding automatically calls the correct PrintShipment()
            /// // for StandardShipment, ExpressShipment, and InternationalShipment.

            #endregion



            #region Question26

            /// 26) Call DeliveryHelper.PrintShipmentDetails() for each shipment.
            ///
            /// DeliveryHelper.PrintShipmentDetails(standardShipment);
            ///
            /// DeliveryHelper.PrintShipmentDetails(expressShipment);
            ///
            /// DeliveryHelper.PrintShipmentDetails(internationalShipment);
            ///
            /// // The correct PrintShipment() method is called automatically.

            #endregion










        }
    }
}
