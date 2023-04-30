// ----------------------------------------------------------------------
// <copyright file="Search.cs" company="none">

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
// <date>09/08/2012 22:18:21</date>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RapidSearch
{
    public static class Search
    {
        public static bool Search_Bin(byte[] data, byte[] rawData, out uint[] offsets, bool pause)
        {
            List<uint> offsets_list = new List<uint>();
            bool f = false;
            bool found = false;

            for (int i = 0; i < data.Length; i++)
            {
                int b = 0;
                int c = i;
                do
                {
                    if (b == rawData.Length)
                    {
                        f = true;
                        offsets_list.Add((uint)i);
                        
                        if (pause)
                        {
                            Console.WriteLine("Found!");
                            Console.WriteLine("Offset: " + i.ToString("x"));
                            Console.ReadKey(true);
                        }
                        break;
                    }

                    if (c >= data.Length)
                        break;

                    if (data[c++] == rawData[b++])
                        found = true;
                    else
                        found = false;

                } while (found);
            }

            offsets = offsets_list.ToArray();
            return f;
        }
    }
}
