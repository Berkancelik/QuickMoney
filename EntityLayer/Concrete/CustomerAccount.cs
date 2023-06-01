﻿namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
