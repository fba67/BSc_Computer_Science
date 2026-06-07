using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_Formula
{
    class Program
    {
        int[] vertex;
        int[,] AMatrix;
        int[,] AdjacencyMatrix;
        int Length;
        public void SetVertex()
        {
            Console.WriteLine("Please enter the number of vertices");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("You must enter a number greater than 1");
                n = Convert.ToInt32(Console.ReadLine());
            }
            vertex = new int[n];
            for (int i = 0; i < n; i++)
                vertex[i] = i;
        }
        public void SetEdges()
        {
            AdjacencyMatrix = new int[vertex.Length, vertex.Length];
            for (int i = 0; i < vertex.Length; i++)
                for (int j = 0; j < vertex.Length; j++)
                    AdjacencyMatrix[i, j] = 0;
            string end = "";
            while (end != "e")
            {
                Console.WriteLine("please enter the source index");
                int s = Convert.ToInt32(Console.ReadLine
                    ());
                Console.WriteLine("please enter the destination index");
                int d = Convert.ToInt32(Console.ReadLine());
                AdjacencyMatrix[s, d] = 1;
                Console.WriteLine("if you are done press: e");
                end = Convert.ToString(Console.ReadLine());
            }
            //AdjacencyMatrix[0, 1] = AdjacencyMatrix[0, 2] = 1;
            //AdjacencyMatrix[1, 2] = 1;
            //AdjacencyMatrix[2, 0] = 1;
        }
        public string ConvertToK_Formula()
        {
            SetVertex();
            SetEdges();
            int numofstars = 0;
            String[] K_formula = new String[vertex.Length];
            for (int i = 0; i < vertex.Length; i++)
            {
                numofstars = 0;
                for (int j = 0; j < vertex.Length; j++)
                    if (AdjacencyMatrix[i, j] == 1)
                        numofstars++;
                for (int k = 0; k < numofstars; k++)
                    K_formula[i] += "*";
                K_formula[i] += i.ToString();
                for (int j = 0; j < vertex.Length; j++)
                    if (AdjacencyMatrix[i, j] == 1)
                        K_formula[i] += j.ToString();
            }
            for (int k = 0; k < vertex.Length - 1; k++)
            {
                int ind = K_formula[0].IndexOf((k + 1).ToString());
                K_formula[0] = K_formula[0].Remove(ind, 1);
                K_formula[0] = K_formula[0].Insert(ind, K_formula[k + 1].ToString());
            }
            Console.WriteLine("the k_formula is:");
            Console.WriteLine(K_formula[0]);
            return K_formula[0];
        }
        public int[,] ConvertToGraph(string kformula)
        {
            AMatrix = new int[kformula.Length, kformula.Length];
            for (int i = 0; i < kformula.Length; i++)
                for (int j = 0; j < kformula.Length; j++)
                    AMatrix[i, j] = 0;
            Length = kformula.Length;

            converttograph(ref kformula);
            int r,c,a=0,b=0;
            for (r = 0; r < Length; r++)
                if (AMatrix[0, r] == 1)
                    a=r;
            for (c = 0; c < Length; c++)
                if (AMatrix[c, 0] == 1)
                    b=c;
            if (a > b)
                Length = a+1;
            else Length = b+1;
            
            int[,] amtrix = new int[Length, Length];
            for (int s = 0; s < Length; s++)
                for (int k = 0; k < Length; k++)
                    amtrix[s, k] = AMatrix[s, k];
            Console.WriteLine(Length);
            Print();
            return amtrix;
        }
        private void converttograph(ref string kformula)
        {
            int nodes = 0;
            int length = kformula.Length;
            int ind = 0, numofstars = 0, index = 0;
            int c = 0;
            while (c < length)
            {
                if (kformula[ind] != '*' && kformula[ind + 1] != '*')
                {
                    index = ind;
                    break;
                }
                ind++;
                c++;
            }
            while (ind >= 0)
            {

                while (--ind >= 0 && kformula[ind] == '*') numofstars++;//ind goes at start of proper star
                ind++;
                bool sequence = true;
                for (int i = 1; i <= numofstars; i++)
                    if (kformula[index + i] == '*')
                    {
                        sequence = false;
                        break;
                    }
                string kf;
                if (ind >= 0 && sequence)
                {
                    Compact(index, ind, ref kformula, numofstars);
                    index = --ind;
                    nodes++;
                }
                else if (!sequence)
                {
                    int startp = index;
                    while (kformula[startp++] != '*') ;
                    startp--;
                    kf = kformula.Remove(0, startp);
                    converttograph(ref kf);
                    kformula = kformula.Remove(startp);
                    kformula = kformula.Insert(startp,kf);
                    ind = 0;
                    c = 0;
                    while (c < length)
                    {
                        if (kformula[ind] != '*' && kformula[ind + 1] != '*')
                        {
                            index = ind;
                            break;
                        }
                        ind++;
                        c++;
                    }
                }
                numofstars = 0;
            }
        }
        public void Print()
        {
            Console.WriteLine("The Adjacency matrix is:");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                    Console.Write(AMatrix[i, j] + "  ");
                Console.WriteLine("\n");
            }
        }

        public void Compact(int index, int ind, ref string kformula, int numofstars)
        {
            int nextindex = index + 1;
            for (int i = 0; i < numofstars; i++)
            {
                int x = Convert.ToInt32(kformula[index].ToString());
                //Console.WriteLine(kformula[index]);
                int y = int.Parse(kformula[nextindex++].ToString());// Console.WriteLine(y);
                AMatrix[x, y] = 1;
            }
            string temp = kformula[index].ToString();
            kformula = kformula.Remove(ind, (2 * numofstars) + 1);//index-=(numofstars);
            kformula = kformula.Insert(ind, temp);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConvertToK_Formula();
            string input = "**0*1*202";
            p.ConvertToGraph( input);
        }
    }
}
