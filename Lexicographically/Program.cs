using System;
using System.Linq;

namespace Lexicographically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teste = SmallestEquivalentString("cgokcgerolkgksgbhgmaaealacnsshofjinidiigbjerdnkolc", "rjjlkbmnprkslilqmbnlasardrossiogrcboomrbcmgmglsrsj", "bxbwjlbdazfejdsaacsjgrlxqhiddwaeguxhqoupicyzfeupcn");
            Console.WriteLine(teste);
        }

        public static string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            List<char[]> graph = new List<char[]>();

            for (int i = 0; i < s1.Count(); i++)
            {
                bool containsS1 = false;
                bool containsS2 = false;

                for (int j = 0; j < graph.Count(); j++)
                {
                    if (graph[j].Contains(s1[i]))
                    {
                        var auxS1Graph = graph[j];
                        List<char[]> auxS2Graph = new List<char[]>();
                        for (int k = 0; k < graph.Count(); k++)
                        {
                            if (graph[k].Contains(s2[i]))
                                auxS2Graph.Add(graph[k]);
                        }

                        string auxUnion = string.Empty;

                        if (auxS2Graph.Any())
                        {
                            auxS2Graph.Add(graph[j]);
                            foreach (char[] item in auxS2Graph)
                            {
                                graph.Remove(item);
                                for (int k = 0;k < item.Count(); k++)
                                {
                                    auxUnion = auxUnion + item[k];
                                }
                            }
                            graph()
                        }

                        if (!graph[j].Contains(s2[i]))
                            graph[j] = graph[j].Append(s2[i]).ToArray();

                        containsS1 = true;
                        break;
                    }

                    if (graph[j].Contains(s2[i]))
                    {
                        if (!graph[j].Contains(s1[i]))
                            graph[j] = graph[j].Append(s1[i]).ToArray();
                         
                        containsS2 = true;
                        break;
                    }
                }

                if (!containsS1 && !containsS2)
                {
                    if (s1[i] == s2[i])
                    {
                        graph.Add(new char[] { s1[i] });
                    }
                    else
                    {
                        graph.Add(new char[] { s1[i], s2[i] });
                    }
                }
            }

            foreach (char[] item in graph)
            {
                Console.Write("representative:" + GetRepresentativeCaractere(item) + " - ");
                Console.WriteLine(item);
            }

            string result = string.Empty;

            for (int i = 0; i < baseStr.Count(); i++)
            {
                bool aux = false;
                for (int j = 0; j < graph.Count(); j++)
                {
                    if (graph[j].Contains(baseStr[i]))
                    {
                        aux = true;
                        result = result + GetRepresentativeCaractere(graph[j]);
                        break;
                    }
                }

                if (!aux)
                {
                    result = result + baseStr[i];
                }
            }

            return result;
        }

        public static char GetRepresentativeCaractere(char[] chars)
        {
            char representative = chars[0];
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] < representative)
                    representative = chars[i];
            }

            return representative;
        }
    }


    public class Solution
    {
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            List<char[]> graph = new List<char[]>();

            for (int i = 0; i < s1.Count(); i++)
            {
                bool containsS1 = false;
                bool containsS2 = false;

                for (int j = 0; j < graph.Count(); j++)
                {
                    if (graph[j].Contains(s1[i]))
                    {
                        if (!graph[j].Contains(s2[i]))
                            graph[j] = graph[j].Append(s2[i]).ToArray();

                        containsS1 = true;
                        break;
                    }

                    if (graph[j].Contains(s2[i]))
                    {
                        if (!graph[j].Contains(s1[i]))
                            graph[j] = graph[j].Append(s1[i]).ToArray();

                        containsS2 = true;
                        break;
                    }
                }

                if (!containsS1 && !containsS2)
                {
                    if (s1[i] == s2[i])
                    {
                        graph.Add(new char[] { s1[i] });
                    }
                    else
                    {
                        graph.Add(new char[] { s1[i], s2[i] });
                    }
                }
            }

            string result = string.Empty;

            for (int i = 0; i < baseStr.Count(); i++)
            {
                bool aux = false;
                for (int j = 0; j < graph.Count(); j++)
                {
                    if (graph[j].Contains(baseStr[i]))
                    {
                        aux = true;
                        result = result + GetRepresentativeCaractere(graph[j]);
                        break;
                    }
                }

                if (!aux)
                {
                    result = result + baseStr[i];
                }
            }

            return result;
        }

        public char GetRepresentativeCaractere(char[] chars)
        {
            char representative = chars[0];
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] < representative)
                    representative = chars[i];
            }

            return representative;
        }
    }
}

