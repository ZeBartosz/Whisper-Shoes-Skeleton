using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DataAdded { get; set; }
        public string CustomerId { get; set; }
        public int ItemId { get; set; }
        public float TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
    }
}