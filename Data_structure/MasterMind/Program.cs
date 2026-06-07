using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind
{
    class Program
    {
        string number;
        string[] Possibilities = new string[4536];
        public void SetPossibilities()
        {
            int C = 0;
            for (int i = 1023; i <= 9876; i++)
            {
                number = i.ToString();
                if (Remove(number) == null) continue;
                else Possibilities[C++] = number;
            }
            string mynubber = "";
            int digitplace = 0;
            int digitnplace = 0;
            Console.WriteLine("Please consider a for dissimilar digit number");
            while (digitplace != 4)
            {
                mynubber = FindNum();
                Console.WriteLine("Is: "+mynubber+"?");
                Console.WriteLine("Please enter the numbers of correct digit which are in correct place!");
                digitplace = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the numbers of correct digit which are not in correct place!");
                digitnplace = int.Parse(Console.ReadLine());
                CleanUp(mynubber, digitplace, digitnplace);
            }
            Console.WriteLine("Your number was "+mynubber);
        }

        public string Remove(string s)//remove the numbers with same digits
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        s = null;
                        return s;
                    }
                }
            }
            return s;
        }

        public string FindNum()
        {
            Random r1 = new Random();
            int index = r1.Next(0, 4536);
            string P = " ";
            while (true)
            {
                if (Possibilities[index] != null)
                {
                    P = Possibilities[index];
                    Possibilities[index] = null;
                    break;
                }
                index++;
                if (index > 4535)
                    index = 0;

            }
            return P;
        }

        public void CleanUp(string s, int dp, int dnp)
        {
            if (dp == 0 && dnp == 0)
            {
                for (int i = 0; i < 4536; i++)
                {
                    if (Possibilities[i] != null)
                    {
                        if (Possibilities[i][0] == s[0] || Possibilities[i][0] == s[1] || Possibilities[i][0] == s[2] || Possibilities[i][0] == s[3])
                        {
                            Possibilities[i] = null;
                            continue;
                        }
                        if (Possibilities[i][1] == s[1] || Possibilities[i][1] == s[0] || Possibilities[i][1] == s[2] || Possibilities[i][1] == s[3])
                        {
                            Possibilities[i] = null;
                            continue;
                        }
                        if (Possibilities[i][2] == s[2] || Possibilities[i][2] == s[1] || Possibilities[i][2] == s[0] || Possibilities[i][2] == s[3])
                        {
                            Possibilities[i] = null;
                            continue;
                        }
                        if (Possibilities[i][3] == s[3] || Possibilities[i][3] == s[1] || Possibilities[i][3] == s[2] || Possibilities[i][3] == s[0])
                        {
                            Possibilities[i] = null;
                            continue;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < 4536; i++)//the number of correct digits in wrong place
                {
                    int dnpcounter = 0;

                    if (Possibilities[i] != null)
                    {
                        if (Possibilities[i][0] == s[1] || Possibilities[i][0] == s[2] || Possibilities[i][0] == s[3])
                        { dnpcounter++; }
                        if (Possibilities[i][1] == s[0] || Possibilities[i][1] == s[2] || Possibilities[i][1] == s[3])
                        { dnpcounter++; }
                        if (Possibilities[i][2] == s[1] || Possibilities[i][2] == s[0] || Possibilities[i][2] == s[3])
                        { dnpcounter++; }
                        if (Possibilities[i][3] == s[1] || Possibilities[i][3] == s[2] || Possibilities[i][3] == s[0])
                        { dnpcounter++; }

                        if (dnpcounter < dnp)
                        {
                            Possibilities[i] = null;
                        }
                    }
                }

                for (int i = 0; i < 4536; i++)//the number of correct digits in correct place
                {
                    int dpcounter = 0;
                    if (Possibilities[i] != null)
                    {
                        if (Possibilities[i][0] == s[0]) { dpcounter++; }
                        if (Possibilities[i][1] == s[1]) { dpcounter++; }
                        if (Possibilities[i][2] == s[2]) { dpcounter++; }
                        if (Possibilities[i][3] == s[3]) { dpcounter++; }

                        if (dpcounter < dp)
                        {
                            Possibilities[i] = null;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.SetPossibilities();
        }
    }
}