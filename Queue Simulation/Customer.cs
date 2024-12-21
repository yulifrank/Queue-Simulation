using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Simulation
{
    public class Customer
    {
        static int count = 1;
        public int Id { get; set; }
        public DateTime ArrivalTime { get; set; }
        public double ServiceTime { get; set; }
        public Customer( double serviceTime)
        {
            Id = count;
            count += 1;
            ArrivalTime = DateTime.Now; 
            ServiceTime = serviceTime;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
