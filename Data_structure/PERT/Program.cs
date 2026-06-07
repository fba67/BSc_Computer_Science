using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PERT
{
    class Program
    {
        int[] vertex;
        int[,] weight;
        int length;
        int[] TE, TL;
        int[]Path;
        void SetVertices()
        {
            Console.WriteLine("Please enter the number of vertices:");
            length = Convert.ToInt32(Console.ReadLine());
            vertex = new int[length];
            for (int i = 0; i < length; i++)
            {
                vertex[i] = i;
            }
        }
        void Weight(int source, int destination, int w)
        {
            weight[source, destination] = w;
        }
        public void SetWeight()
        {
            weight = new int[length,length];
            for (int i = 0; i < vertex.Length; i++)
                for (int j = 0; j < vertex.Length; j++)
                    weight[i, j] = 0;
            string end = "";
            //while (end != "e")
            //{
            //    //Console.WriteLine("Please enter: source index"); int source = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine("Please enter: destination index"); int destination = Convert.ToInt32(Console.ReadLine());
            //    //Console.WriteLine("Please enter: weight"); int w = Convert.ToInt32(Console.ReadLine());
            //    //Weight(source, destination, w);
            //    //Console.WriteLine("if you are done press: e");
            //    //end = Convert.ToString(Console.ReadLine());
            //}
            Weight(0, 1, 2);
            Weight(0,2,1);
            Weight(2, 3, 3);
            Weight(1, 3, 4);
            //Weight(2, 0, 5);
            //Weight(0,3,9);
            //Weight(2,3,3);
        }
        void FindTE()
        {
            int i, j;
            TE = new int[length];
            for (i = 0; i < length; i++)
                TE[i] = 0;
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length; j++)
                {
                    if (weight[i,j] != 0)
                    {
                        TE[j] = System.Math.Max(TE[j], weight[i,j] + TE[i]);
                    }
                }
            }
        }
        void FindTL()
        {
            TL = new int[length];
            int[,] revweight = new int[length,length];
            int i, j;
            for (i = 0; i < length; i++)
                TL[i] = TE[length - 1];
            for (i = 0; i < length; i++)
                for (j = 0; j < length; j++)
                    revweight[i, j] = weight[j, i];
            for (i = length - 1; i >= 0; i--)
                for (j = length - 2; j >= 0; j--)
                {
                    if (revweight[i,j] != 0)
                        TL[j] = System.Math.Min(TL[j], TL[i] - revweight[i,j]);
                }
            TL[0] = 0;
        }
        public void PrintTE()
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine("TE["+i+"]= "+TE[i]);
            Console.WriteLine();
        }
        public void PrintTL()
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine("TL[" + i + "]= " + TL[i]);
            Console.WriteLine();
        }
        public void CriticalPath(int i,int k,bool IsFirst){
            if (IsFirst)
            {
                Path = new int[length];
                for (int m = 0; m < length; m++)
                    Path[m] = -1;
                IsFirst = false;
            }
            int j;
            if (k != length - 1)
            {
                Path[i] = k;
                for (j = i + 1; j < length; j++)
                {
                    if (weight[k,j] != 0)
                        CriticalPath( i + 1, j,IsFirst);
                }
                Path[i] = -1;
            }
            else
            {
                Path[i] = k;
                bool flag = true;
                for (j = 0; j < length; j++)
                {
                    if (Path[j] != -1 && TE[Path[j]] != TL[Path[j]])
                        flag = false;
                }
                if (flag)
                {
                    for (j = 0; j < length; j++)
                    {
                        if (Path[j] != -1)
                        {
                            Console.Write("{0} ", Path[j]);
                        }
                    }
                    Console.WriteLine();
                }
                Path[i] = -1;
            }
        }
        public void PERT()
        {
            SetVertices();
            SetWeight();
            FindTE();
            FindTL();
            Console.WriteLine("The critical path is:");
            CriticalPath(0,0,true);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PERT();
            p.PrintTE();
            p.PrintTL();
        }
    }
}
