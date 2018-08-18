using System;
using System.Linq;

namespace P02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    break;
                }

                if (command[0] == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    break;
                }

                if (command[0] == "Delete")
                {
                    int numberToDelete = int.Parse(command[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == numberToDelete)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                    }
                }

                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    list.Insert(position, element);
                }
            }
        }
    }
}
