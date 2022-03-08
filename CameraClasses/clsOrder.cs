using System;

namespace CameraClasses
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int OrderID { get; set; }
        public DateTime DateOfOrder { get; set; }
        public bool PaymentStatus { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string Quantity { get; set; }
    }
}