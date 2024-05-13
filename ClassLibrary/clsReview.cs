using System;

namespace ClassLibrary
{
    public class clsReview
    {
        public bool IsApproved { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string CustomerName { get; set; }
        public string ReviewDescription { get; set; }
        public string ReviewTitle { get; set; }
        public int Rating { get; set; }
       
    }
}