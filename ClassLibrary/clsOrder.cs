using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool OrderCompleted { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
    }

}