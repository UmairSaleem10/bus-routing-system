using System;
using System.Collections.Generic;
using DotNetXtensions;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Graph_implementation__C_sharp_
{
    public class Graph
    {
        public Graph() { }

        public Graph(IEnumerable<Tuple<string, bool>> vertices, IEnumerable<Tuple<string, string, double, bool>> edges)
        {
            
            foreach (var vertex in vertices)
            {
                addVertex(vertex);
                //isStation(vertex.Item1, vertex.Item2);
                Console.WriteLine(vertex);
            }
            foreach (var edge in edges)
            { 
                addEdge(edge);
                Console.Write(edge.Item1 + " --> " + edge.Item2 + " & " + edge.Item3 + " " + edge.Item4); Console.WriteLine();
            }

        }

        //public Dictionary<T, HashSet<T>> adjecencyList { get; } = new Dictionary<T, HashSet<T>>();
        public Dictionary<Tuple<string, bool>, List<Tuple<double, string, bool>>> g = new Dictionary<Tuple<string,bool>, List<Tuple<double, string, bool>>>();

       /* public void addVertex(string vertex)
        {
            g[vertex] = new List<Tuple<double, string, bool>>();
        }*/

        public void addVertex(Tuple<string, bool> vertex)
        {
            g[vertex] = new List<Tuple<double, string, bool>>();
        }

        public bool isStation(string vertex, bool isStation1)
        {
            if (isStation1 == true)
                return true;
            return false;
        }

        public void addEdge(Tuple<string, string, double, bool> edge)
        {
            bool station = true;
            var t1 = Tuple.Create(edge.Item1, station);
            var t2 = Tuple.Create(edge.Item2, edge.Item4);
            if (g.ContainsKey(t1) && g.ContainsKey(t2))
            {
                g[t1].Add(Tuple.Create(edge.Item3, edge.Item2, edge.Item4));
                g[t2].Add(Tuple.Create(edge.Item3, edge.Item1, true));
            }
        }

     /*   public void removeVertex(Tuple<string, bool> vertex)
        {
            foreach(var values in g[vertex])
            {
                var ind = values.Item2;
                g.Remove(ind);
            }
        }*/

        public int totalEdges()
        {
            List<Tuple<string, bool>> keys= new List<Tuple<string, bool>>(g.Keys);
            int count = 0;

            foreach(var key in keys)
            {
                var ind = g[key];
                count = count + g[key].Count;
            }

            return count / 2;

        }

        public bool containEdge(Tuple<string, bool> source, Tuple<string, bool> destination)
        {
           foreach(var values in g[source])
            {
                if (values.Item2 == destination.Item1)
                {
                    return true;
                }
            }

            return false;
        }


        public void printGraph()
        {
            foreach (var node in g)
            {
                /*Console.Write(node.Key);
                Console.Write(" --> ");*/

                foreach (var values in g[node.Key])
                {
                    Console.WriteLine(node.Key + " distance till " + values + " is " + values.Item1 + "km & " + values.Item3);
                }
                Console.WriteLine();
            }
        }

       /* public void displayMap()
        {
            Console.WriteLine("\t Lahore Bus Routing App");
            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t---------------------------------------------------------");

            List<T> keys = new List<T>(g.Keys);

            foreach (var node in g)
            {
                var str = node + " =>\n";
                var ind = g[node.Key];

                List<string> values = new List<string>();
                foreach (var node1 in values)
                {
                    str = str + "\t" + node1 + "\t";
                    str = str + g[node1] + "\n";
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("\t------------------------");
            Console.WriteLine("\t---------------------------------------------------------");
*//*
        }*/


        public bool hasPath(Tuple<string, bool> source, Tuple<string, bool> destination, Dictionary<string, bool> processed)
        {
            if (containEdge(source, destination))
            {
                return true;
            }


            processed[source.Item1] = true;
            var vtx = g[source];
            List<Tuple<string, bool>> neighbours = new List<Tuple<string, bool>>();
            foreach (var node in vtx) {
                var n1 = Tuple.Create(node.Item2, node.Item3);
                neighbours.Add(n1);
            }

            foreach(var nbr in neighbours)
            {
                if(!processed.ContainsKey(nbr.Item1))
                {
                    if (hasPath(nbr, destination, processed))
                    {
                        Console.WriteLine(source.Item1 + " ---> " + destination.Item1);
                        return true;
                    }
                }
            }
            return false;

        }

        public void displayStations()
        {
            List<Tuple<string, bool>> s = new List<Tuple<string, bool>>(g.Keys);
            s.Sort();
            int i = 1;

            foreach(var node in s)
            { 
                    Console.WriteLine(i + ". " + node.Item1);
                    i++;
            }


        }

        public List<string> path = new List<string>();
        public Tuple<string, bool> NO_PARENT = null;
        public double Dijkistra(Tuple<string, bool> source, Tuple<string, bool> destination)
        {
            //List<double> dist = new List<double>();

            // pq.Enqueue(Tuple.Create(0, destination), List < Tuple.Create(0, destination) >>);

            Dictionary<string, string> parents1 = new Dictionary<string, string>();
            Dictionary<Tuple<string, bool>, Tuple<string, bool>> parents = new Dictionary<Tuple<string, bool>, Tuple<string, bool>>();

            Dictionary<Tuple<string, bool>, bool> visited = new Dictionary<Tuple<string, bool>, bool>();

            PriorityQueue<Tuple<double, Tuple<string, bool>>, Tuple<double, Tuple<string, bool>>> pq1 = new PriorityQueue<Tuple<double, Tuple<string, bool>>, Tuple<double, Tuple<string, bool>>>();
            PriorityQueue<Tuple<double, Tuple<string, bool>>> pq = new PriorityQueue<Tuple<double, Tuple<string, bool>>>(150);

            Dictionary<Tuple<string, bool>, double> costs = new Dictionary<Tuple<string, bool>, double>();

            foreach (var vertex in g)
            {
                parents[vertex.Key] = NO_PARENT;
            }
            costs = initializeCosts(costs, source);
            var t1 = Tuple.Create(costs[source], source);
            //pq.Enqueue(t1, t1);
            pq.Push(t1);
            parents[source] = source;
            
            while (pq.Count != 0)
            {
                //var current = pq.Peek().Item2;
                var current = pq.Top.Item2;
                pq.Dequeue();
                visited[current] = true;

                foreach (var edge in g[current])
                {
                    var t2 = Tuple.Create(edge.Item2, edge.Item3);
                    if (!visited.ContainsKey(t2))
                    {
                        if (costs[current] + edge.Item1 < costs[t2])
                        {
                            costs[t2] = costs[current] + edge.Item1;
                            parents[t2] = current;
                            //pq.Enqueue(Tuple.Create(edge.Item1, t2), Tuple.Create(edge.Item1, t2));
                            pq.Push(Tuple.Create(edge.Item1, t2));
                        }
                    }
                }

                    printPath(current, parents, destination);
                    Console.WriteLine();
                    Console.WriteLine();
                /*while (parents[current] != current)
                {
                    path.Add(current.Item1);
                    current = parents[current];
                }
                path.Reverse();

                foreach(var path1 in path)
                {
                    Console.Write(path1+ " ");
                }*/
            }
            return (costs[destination]);
        }
        

        public void printSolution(Tuple<string, bool> source, Dictionary<Tuple<string, bool>, Tuple<string, bool>> parents, Tuple<string, bool> destination)
        {
            Console.WriteLine("Vertex" + "\t\t\t" + "Path");
        
            foreach(var vertex in g)
            {
                if (vertex.Key != source)
                {
                    Console.WriteLine(source + "\t\t\t" + vertex.Key );
                    printPath(vertex.Key, parents, destination);
                }
            }
        }

        public void printPath(Tuple<string, bool> source, Dictionary<Tuple<string, bool>, Tuple<string, bool>> parents, Tuple<string, bool> destination)
        {
            if (source != destination)
            {
                if (parents[source] == source)
                {
                    return;
                }
                    printPath(parents[source], parents, destination);
                Console.Write(source + " --> ");
            }
            else
                return;
        }
        public Dictionary<Tuple<string, bool>, double> initializeCosts(Dictionary<Tuple<string, bool>, double> costs, Tuple<string, bool> source)
        {
            foreach(var vertex in g)
            {
                if (vertex.Key == source)
                {
                    costs[vertex.Key] = 0;
                }

                else
                    costs[vertex.Key] = double.MaxValue;
                

                foreach(var edge in vertex.Value)
                {
                    var t3 = Tuple.Create(edge.Item2, edge.Item3);
                    if (edge.Item2 == source.Item1)
                        costs[t3] = 0;

                    else if (!costs.ContainsKey(t3))
                        costs[t3] = double.MaxValue;

                }
            }
            return costs;
        }

        public int calculateFare(double distance)
        {
            double petrolPrice = 220.54;
            int mileage = 6;
            var farePerKM =(petrolPrice / mileage);
            var farePerson = 10;
            int totalFare = 0;
            farePerKM =Convert.ToInt32(farePerKM);

            if(distance>0 && distance<=5)
            {
                totalFare = Convert.ToInt32( 1 * farePerson);
            }
            else if(distance>5 && distance<=10)
            {
                totalFare = Convert.ToInt32(2 * farePerson);
            }
            else if(distance>10 && distance<=15)
            {
                totalFare = Convert.ToInt32(3 * farePerson);
            }
            else if (distance > 15 && distance <= 20)
            {
                totalFare = Convert.ToInt32(4 * farePerson);
            }
            else if (distance > 20 && distance <= 25)
            {
                totalFare = Convert.ToInt32(5 * farePerson);
            }
            else if (distance > 25 && distance <= 30)
            {
                totalFare = Convert.ToInt32(6 * farePerson);
            }
            else if (distance > 30 && distance <= 35)
            {
                totalFare = Convert.ToInt32(7 * farePerson);
            }
            else if (distance > 35 && distance <= 40)
            {
                totalFare = Convert.ToInt32(8 * farePerson);
            }
            else if (distance > 40 && distance <= 45)
            {
                totalFare = Convert.ToInt32(9 * farePerson);
            }
            else if (distance > 45 && distance <= 50)
            {
                totalFare = Convert.ToInt32(10 * farePerson);
            }
            else if (distance > 50 && distance <= 55)
            {
                totalFare = Convert.ToInt32(11 * farePerson);
            }
            else if (distance > 55 && distance <= 60)
            {
                totalFare = Convert.ToInt32(12 * farePerson);
            }
            else if (distance > 60 && distance <= 65)
            {
                totalFare = Convert.ToInt32(13 * farePerson);
            }
            else if (distance > 65 && distance <= 70)
            {
                totalFare = Convert.ToInt32(14 * farePerson);
            }
           
            return totalFare;
        }
       
        
        public int calculateEstimatedTime(double distance)
        {
            int time;
            time = (int)Convert.ToInt16(distance * 1.5);
            return time;
        }
















        /*public double shortestDistance(T source, T destination)
        {
            Dictionary<T, Tuple<double, T>> visited = new Dictionary<T, Tuple<double, T>>();
            Queue<T> queue = new Queue<T>();
            queue.Enqueue(source);

            *//*visited[source] = Tuple.Create(null, 0);*//*

            while (queue.Count > 0)
            {
                T current = queue.Dequeue();
                bool Equal = test<T>(current, destination);
                if (Equal)
                {
                    break;
                }

                foreach (var neighbour in g[current])
                {
                    if (!visited.ContainsKey(neighbour.Item2))
                    {
                        queue.Enqueue(neighbour.Item2);
                        visited[neighbour.Item2] = (visited[current].Item1++, neighbour.Item2);
                    }
                }
            }
            return visited[destination].Item1;
        }*/

        /* public void DijikstraAlgo(T source, T destination)
         {
             const int inf = 10 ^ 7;
             T[] dist= new T[g.Keys.Count];
             bool[] sptSet= new bool[g.Keys.Count];


             foreach(var node in g)
             {
                 dist[node.Key] = int.MaxValue;
                 sptSet[node.Key] = false;
             }

         }*/
        public static bool test<T>(T test, T test2) where T : class
        {
            return (test == test2);
        }
    }
}
