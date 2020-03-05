using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DmvAppointmentScheduler
{
    public class Customer
    {
        public string Id { get; set; }
        public string type { get; set; }
        public string duration { get; set; }
    }

    public class CustomerList
    {
        public List<Customer> Customer { get; set; }

        public void sort()
        {
            Customer =
               Customer
                   .OrderByDescending(c => Convert.ToDouble(c.duration))
                   .ToList<Customer>();
        }
    }
}
