// ----------------------------------------------------------------------
// <copyright file="RapidUI.cs" company="none">

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
// <date>09/08/2012 22:10:37</date>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RapidSearch
{
    public partial class RapidUI : Form
    {
        bool stop;

        public RapidUI()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog o = new FolderBrowserDialog();
            o.Description = "Select the folder with the files.";
            if (o.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            txtFolderIn.Text = o.SelectedPath;

            o.Dispose();
            o = null;
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.CheckFileExists = true;
            if (o.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            txtFileIn.Text = o.FileName;
            txtDataIn.Text = BitConverter.ToString(File.ReadAllBytes(o.FileName)).Replace("-", " ");

            o.Dispose();
            o = null;
        }

        private void checkFileData_CheckedChanged(object sender, EventArgs e)
        {
            txtDataIn.Enabled = !checkFileData.Checked;
            txtFileIn.Enabled = checkFileData.Checked;
            btnSelectFile.Enabled = checkFileData.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            byte[] data;
            if (checkFileData.Checked)
                data = File.ReadAllBytes(txtFileIn.Text);
            else
            {
                string hex = txtDataIn.Text;
                hex = hex.Replace("\r\n", "");
                hex = hex.Replace(" ", "");

                if (hex.Length % 2 != 0)
                {
                    MessageBox.Show("Invalid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                data = new byte[hex.Length / 2];
                for (int i = 0; i < data.Length; i++)
                    data[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            txtLog.Text = "";

            SearchOption so = (checkOnlyTop.Checked ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);
            foreach (string file in Directory.GetFiles(txtFolderIn.Text, txtSearchPattern.Text, so))
            {
                byte[] f_data = File.ReadAllBytes(file);
                uint[] offsets;
                bool f = Search.Search_Bin(f_data, data, out offsets, false);
                if (!f)
                    continue;

                // Display offsets
                txtLog.Text += "Found in " + file + "\r\n";
                for (int i = 0; i < offsets.Length; i++)
                    txtLog.Text += "\tOffset: " + offsets[i].ToString("X") + "\r\n";
            }

            MessageBox.Show("Finish!");
        }

        private void txtDataIn_TextChanged(object sender, EventArgs e)
        {
            if (stop)
                return;

            stop = true;
            string t = txtDataIn.Text;
            txtDataIn.Text = "";
            t = t.Replace(" ", "");
            t = t.Replace("\r\n", "");

            for (int i = 0; i < t.Length; i++)
            {
                if (i % 2 == 0 && i != 0)
                    txtDataIn.Text += " ";
                if (i % 32 == 0 && i != 0)
                    txtDataIn.Text += "\r\n";

                txtDataIn.Text += t[i];
            }

            stop = false;
        }
    }
}
