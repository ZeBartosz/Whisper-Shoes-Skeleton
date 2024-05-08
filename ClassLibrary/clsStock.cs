using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool stockAutoRestock { get; set; }
        public DateTime stockLastRestocked { get; set; }
        public int stockRestockThreshold { get; set; }
        public int stockQuantity { get; set; }
        public string stockDescription { get; set; }
        public string stockName { get; set; }
    }
}