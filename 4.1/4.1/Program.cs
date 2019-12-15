using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            SymbolsIterative(str);
            Console.WriteLine();
            SymbolsString(str);            
        }
        static void SymbolsIterative(string s)
        {
            for (int i=0; i<s.Length; i++)
            {
                bool flag = true;
                for (int j=0; j<s.Length; j++)
                {
                    if ((s[i]==s[j])&&(i!=j))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.Write(s[i] + " ");
                }
            }
        }
        static void SymbolsString (string s)
        {
            for (int i=0; i<s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                {
                    Console.Write(s[i] + " ");
                }
            }
            
        }
    }
}
