﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = Int32.Parse(Console.ReadLine());

            Dictionary<string,
                string> phonebook = new Dictionary<string,
                string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                phonebook[line[0]] = line[1];
            }

            string name;
            while ((name = Console.ReadLine()) != null)
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
			Console.ReadKey();
        }
    }
}
