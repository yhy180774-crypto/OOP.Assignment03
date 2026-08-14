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

































        }
    }
}
