using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Deadlock
{
    internal class Deadlock
    {
        static Dictionary<string, object> dict;
        static HashSet<object> set;
        public static List<object> deadlockList;

        public Deadlock()
        {
            dict = new Dictionary<string, object>();
            set = new HashSet<object>();
            deadlockList = new List<object>();
        }

        public void input(string process, string resourceOwned, string resourceRequest)
        {
            string[] rrList = resourceRequest.Split(',');
            string[] roList = resourceOwned.Split(',');
            if (resourceOwned != "") { 
                foreach (string ro in roList)
                {
                    dict[ro] = process;
                }
            } 
            dict[process] = rrList;

            set.Add(process);
            set.UnionWith(roList);
            set.UnionWith(rrList);
        }
        public void output()
        {
            printSet();
            printDict();
            printDeadlock();
        }

        public void run()
        {
            List<object> chooseList = new List<object>(set);
            foreach (object item in chooseList)
            {
                findDeadlock(item, new List<object>());
            }
        }

        public void findDeadlock(object c, List<object> l)
        {
            if (l.Contains(c))
            {
                l.Add(c);
                deadlockList.Add(new List<object>(l));
                return;
            }

            if (!dict.ContainsKey(c.ToString()))
            {
                return;
            }

            l.Add(c);
            if (dict[c.ToString()] is string[])
            {
                foreach (var i in (string[])dict[c.ToString()])
                {
                    findDeadlock(i, l);
                }
            }
            else
            {
                findDeadlock(dict[c.ToString()], l);
            }
        }
        public void printSet()
        {
            Console.Write("Set : ");
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void printDict()
        {
            Console.Write("Dict : \n");
            foreach (var item in dict)
            {
                Console.Write($"{item.Key}: ");
                if (item.Value is string)
                {
                    Console.WriteLine(item.Value);
                }
                else
                {
                    foreach (var i in (string[])item.Value)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void printDeadlock()
        {
            Console.WriteLine("Deadlocks: ");
            foreach (var dl in deadlockList)
            {
                Console.Write("[ ");
                foreach (var di in (List<object>)dl)
                {
                    Console.Write($"{di} ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
