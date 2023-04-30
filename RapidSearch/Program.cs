// ----------------------------------------------------------------------
// <copyright file="Program.cs" company="none">

// Copyright (C) 2012
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by 
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful, 
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details. 
//
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>. 
//
// </copyright>

// <author>pleoNeX</author>
// <email>benito356@gmail.com</email>
// <date>09/08/2012 22:11:01</date>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace RapidSearch
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RapidUI());  
                return;
            }

            string folder = args[0];

            string file_in = args[1];
            byte[] rawData = File.ReadAllBytes(file_in);

            string key_search = "*.*";
            if (args.Length == 3)
                key_search = args[2];

            Console.WriteLine("Searching data from file: {0}", file_in);
            bool found = false;
            foreach (string file in Directory.GetFiles(folder, key_search))
            {
                uint[] offset;
                //Console.WriteLine("Reading: " + Path.GetFileName(file));

                bool b = Search.Search_Bin(File.ReadAllBytes(file), rawData, out offset, false);
                if (b && found)
                    File.AppendAllText("aai_log.txt", "¡¡Data found in more than one file!!\n");
                if (b)
                {
                    found = true;
                    Console.Write("Found data inside: {0} at offsets: ", file);
                    for (int i = 0; i < offset.Length; i++)
                        Console.Write("0x" + offset[i].ToString("X") + " ");
                    Console.WriteLine();
                    //Console.WriteLine("\nPress a key to continue searching...");
                    //Console.ReadKey(true);
                    File.AppendAllText("aai_log.txt", "\t<- Found in " + Path.GetFileName(file) + " at 0x" + offset[0].ToString("X") + "\n");
                    if (offset.Length > 1)
                        File.AppendAllText("aai_log.txt", "¡¡Offset length is bigger than 1!!\n");
                }
            }

            if (found)
            {
                try { File.Delete(file_in); }
                catch { }
            }
            //Console.WriteLine("End of search\nPress a key to quit.");
            //Console.ReadKey(true);
        }
    }
}
