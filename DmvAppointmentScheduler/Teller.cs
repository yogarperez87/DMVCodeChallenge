using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DmvAppointmentScheduler
{
    public class Teller
    {
        public string id { get; set; }
        public string specialtyType { get; set; }
        public string multiplier { get; set; }
        public double accumulatedTime { get; set; }
    }

    public class TellerList
    {
        public List<Teller> Teller { get; set; }

        public void sort()
        {
            if (Teller != null)
            {
                Teller =
                    Teller
                        .OrderBy(c => c.specialtyType)
                        .ThenBy(c => Convert.ToDouble(c.multiplier))                        
                        .ToList<Teller>();
            }
        }
    }
}
