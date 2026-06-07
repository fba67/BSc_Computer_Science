using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace APSP
{
    class Program
    {
        int source;
        int[,] weight;
        int[] Set;
        int[] vertex;
        int[] Distance;
        int fullind = 0;
        ArrayList path;
        ArrayList[] paths;
        public void SetVertex()
        {
            Console.WriteLine("Please enter the number of vertices");
            int n=Convert.ToInt32(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("You must enter a number greater than 1");
                n = Convert.ToInt32(Console.ReadLine());
            }
            vertex = new int[n];
            for (int i = 0; i < n; i++)
                vertex[i] = i;
        }
        public void SetWeight()
        {
            weight = new int[vertex.Length, vertex.Length];
            for (int i = 0; i < vertex.Length; i++)
                for (int j = 0; j < vertex.Length; j++)
                    weight[i, j] = 999999;
            string end="";
            //while (end != "e")
            //{
            //    //Console.WriteLine("Please enter: source index"); int source = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine("Please enter: destination index"); int destination = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine("Please enter: weight"); int w = Convert.ToInt32(Console.ReadLine());
            //    //Weight(source, destination, w);
            //    //Console.WriteLine("if you are done press: e");
            //    //end = Convert.ToString(Console.ReadLine());
            //}
            Weight(0, 1, 1);
            Weight(1,2,2);
            Weight(0, 2, 5);
            //Weight(2, 0, 5);
            //Weight(0,3,9);
            //Weight(2,3,3);
        }
        void Weight(int source, int destination, int w)
        {
            weight[source, destination] = w;
        }
        public void AllPairsShortestPath()
        {
            SetVertex();
            Console.WriteLine("\nAll Pairs Shortest Path are:");
            for (int i = 0; i < vertex.Length; i++)
            {
                Dijkstra(i);
                Print();
            }
        }
        void setgraph(int s)
        {
            source = s;
            SetWeight();
            paths = new ArrayList[vertex.Length];
            for (int i = 0; i < vertex.Length; i++)
                paths[i] = new ArrayList();
            Set = new int[vertex.Length];
            Distance = new int[vertex.Length];
        }
        public void Dijkstra(int s)
        {
            fullind = 0;
            setgraph(s);
            Set[fullind++] = vertex[source];
            for (int i = 0; i < vertex.Length; i++)//initializing the distance array by weight array
                Distance[i] = weight[source, i];
            for (int i = 0; i < vertex.Length - 1; i++)
            {
                int vertx = SelectVertex();
                if (paths[vertx].Count == 0)
                    paths[vertx].Add(vertx);
                else
                {
                    if ((int)(paths[vertx][paths[vertx].Count - 1]) != vertx)
                        paths[vertx].Add(vertx);}
                    Set[fullind++] = vertx;
                foreach (int var in Subtract(vertex, Set))
                {
                    int temp = Distance[var];
                    Distance[var] = Min(Distance[var], Distance[vertx] + weight[vertx, var]);
                    if (temp > Distance[var] )
                    {
                        paths[var].Clear();
                        paths[var].AddRange(paths[vertx]);
                        //paths[var].Add(var);
                    }
                    //else
                        paths[var].Add(var);
                }
            }
        }
        public void Print()
        {
            //Console.WriteLine("\nshortest paths");
            for (int i = 0; i < Distance.Length; i++)
            {
                if (i == source)
                    continue;
                if (Distance[i] == 999999)
                    Console.WriteLine("\nThere is no path from " + source + " to " + (i).ToString());
                else
                {
                    Console.WriteLine("\nThe shortest path from " + source + " to " + (i).ToString() + " is: " + Distance[i]);
                    //for (int i = 0; i < vertex.Length; i++)
                    //{
                        paths[i].Insert(0, source);
                        ArrayList al = paths[i];
                        if (i == source) continue;
                        for (int j = 0; j < paths[i].Count; j++)
                            Console.Write(al[j]);
                        Console.WriteLine();
                    //}
                }
            }
        }
        int Min(int a, int b)
        {
            if (a > b)
                return b;
            return a;
        }
        int SelectVertex()
        {
            int[] sbtrct = Subtract(vertex, Set);
            int ind;
            ind = MinInd(Distance, sbtrct);
            return ind;
        }
        int MinInd(int[]a,int[]b) {//finds the minimum value and returns it's index
            int index = b[0]; int min = a[index];
            foreach(int var in b) 
            {
                if (a[var] < min)
                {
                    index = var;
                    min = a[var];
                }
            }
            return index;
        }
        public int[] Subtract(int[]vertex,int[]Set)
        {
            int[] result = new int[vertex.Length-fullind]; int k = 0; bool contain = false;
            for (int i = 0; i < vertex.Length; i++)
            {
                contain = false;
                for (int j = 0; j < Set.Length; j++)
                {
                    if (vertex[i] == Set[j])
                    {
                        contain = true;
                        break;
                    }
                }
                if (!contain)
                    result[k++] = vertex[i];
                
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] vertex = { 0,1,2,3,4,5,6};
            int[] weight = {10, 3,7,1,6,4,9};
            Program p = new Program();
            //p.Dijkstra(0);
            //p.Print();
            p.AllPairsShortestPath();
            Console.ReadLine();
        }
    }
}
