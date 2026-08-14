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














        }
    }
}
