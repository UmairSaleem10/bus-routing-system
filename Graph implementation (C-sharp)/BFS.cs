using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_implementation__C_sharp_
{
    public class BFS
    {
        /*public static List<Tuple<int, T>> BFScode<T>(Graph<T> graph, T start)
        {
            var visited = new Dictionary<string, bool>();
            Stack<T> stack;
            stack.Push(start);
            visited[start] = true;

            if (!graph.g.ContainsKey(start))
            {
                return visited;
            }

            var queue = new Queue<T>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();

                if (visited.Contains(vertex))
                {
                    continue;
                }

                visited.Add(vertex);

                foreach (var neighbours in graph.g[vertex])
                {
                    if (!visited.Contains(neighbours))
                    {
                        queue.Enqueue(neighbours);
                    }

                }
            }
            return visited;
        }
    }
}*/





        public static Dictionary<Tuple<string, bool>, bool> BFScode(Graph graph, Tuple<string, bool> start)
        {
            Dictionary<Tuple<string, bool>, bool> visited = new Dictionary<Tuple<string, bool>, bool>();

            if (!graph.g.ContainsKey(start))
                return visited;

            var queue = new Queue<Tuple<string, bool>>();
            queue.Enqueue(start);
            

            visited[start] = true;
            

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                Console.Write(vertex + " --> ");

                

                visited[vertex] = true;

                foreach (var neighbor in graph.g[vertex])
                {
                    var t1 = Tuple.Create(neighbor.Item2, neighbor.Item3);
                    if (!visited.ContainsKey(t1))
                    {
                        queue.Enqueue(t1);
                        visited[t1] = true;
                        //Console.Write(neighbor.Item2 + " ");
                    }
                }

            }

            return visited;
            Console.WriteLine();
        }
    }
}