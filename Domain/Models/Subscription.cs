using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Subscription
    {
        public int Id { get; set; }
       
        public string? UserName { get; set; }
        public string? SubscriptionLevel { get; set; }
        public int? NumberOfRequests { get; set; }
    }
}
