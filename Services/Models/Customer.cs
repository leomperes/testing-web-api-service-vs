using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType CustomerType { get; set; }
    }

    public enum CustomerType
    {
        Deadbeat,
        Standard,
        Premium
    }
}