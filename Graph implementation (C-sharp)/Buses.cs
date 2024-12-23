using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_implementation__C_sharp_
{
    internal class Buses
    {
        public string model;
        public int year;
        public int seats;
        public DateTime time;

        public Buses()
        {

        }
        public Buses(string model, int year, int seats, DateTime time)
        {
            this.model=model; 
            this.year=year;
            this.seats=seats;
            this.time = time;
        }
    }
}
