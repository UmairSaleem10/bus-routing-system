

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graph_implementation__C_sharp_
{
    internal class path
    {
        string[] places;
        float distance;

        public path(string[] places, float distance)
        {
            this.places = places;
            this.distance = distance;
        }

        

        


       /* public void displayRoute(Graph_implementation__C_sharp_.Graph<string> g)
        {
            foreach(var route in g)
            {
                Console.WriteLine(g[route]);
            }
        }*/
    }
}
