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



        }
    }
}
