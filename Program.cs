using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    class Program
    {

        private static string SourceString;
        private static Stack<int> Ints = new Stack<int>();
        private static Stack<Dictionary<char,int>> Chars = new Stack<Dictionary<char, int>>();
        private static void Parse(string PString) {

            foreach (char Current in PString) {

                if (Priorities.Keys.Contains(Current)) {

                //    Chars.Push(new Dictionary<char, int>(Current,));
                }
                else if (Enumerable.Range(0,10).Contains(int.Parse(Current.ToString()))) {

                    Ints.Push(int.Parse(Current.ToString()));
                }
            }
        }
        private static Dictionary<char, int> Priorities;
        static public void InitPriorities() {

            Priorities = new Dictionary<char, int>();
            Priorities.Add('(',1); //TODO 
            Priorities.Add(')',1); //TODO
            Priorities.Add('-', 1);
            Priorities.Add('+', 1);
            Priorities.Add('/', 2);
            Priorities.Add('*', 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(Directory.GetCurrentDirectory());
            InitPriorities();

            //input
            Console.WriteLine("Input");
            SourceString = Console.ReadLine();

            

        }
    }
}
