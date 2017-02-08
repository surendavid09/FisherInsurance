using System;

namespace FisherInsurance.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Price { get; set; }
    }

    public class claims
    {
        public int Id { get; set; }
        public string PolicyType { get; set; }
        public DateTime Lossdate { get; set; }
        public decimal LossAmount { get; set; }
    }
}