// ----------------------------------------------------------------------
// <copyright file="RapidUI.Designer.cs" company="none">

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
// <date>09/08/2012 22:10:51</date>
// -----------------------------------------------------------------------
namespace RapidSearch
{
    partial class RapidUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtDataIn = new System.Windows.Forms.TextBox();
            this.txtFolderIn = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtFileIn = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkFileData = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPattern = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkOnlyTop = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(376, 373);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 40);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search!";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(366, 19);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(90, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtDataIn
            // 
            this.txtDataIn.Enabled = false;
            this.txtDataIn.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataIn.Location = new System.Drawing.Point(6, 71);
            this.txtDataIn.Multiline = true;
            this.txtDataIn.Name = "txtDataIn";
            this.txtDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataIn.Size = new System.Drawing.Size(450, 96);
            this.txtDataIn.TabIndex = 2;
            this.txtDataIn.TextChanged += new System.EventHandler(this.txtDataIn_TextChanged);
            // 
            // txtFolderIn
            // 
            this.txtFolderIn.Location = new System.Drawing.Point(48, 19);
            this.txtFolderIn.Name = "txtFolderIn";
            this.txtFolderIn.Size = new System.Drawing.Size(312, 20);
            this.txtFolderIn.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(0, 273);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(370, 152);
            this.txtLog.TabIndex = 4;
            // 
            // txtFileIn
            // 
            this.txtFileIn.Location = new System.Drawing.Point(48, 21);
            this.txtFileIn.Name = "txtFileIn";
            this.txtFileIn.Size = new System.Drawing.Size(312, 20);
            this.txtFileIn.TabIndex = 5;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(366, 17);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(90, 23);
            this.btnSelectFolder.TabIndex = 6;
            this.btnSelectFolder.Text = "Select folder";
            this.btnSelectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data:";
            // 
            // checkFileData
            // 
            this.checkFileData.AutoSize = true;
            this.checkFileData.Checked = true;
            this.checkFileData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFileData.Location = new System.Drawing.Point(366, 48);
            this.checkFileData.Name = "checkFileData";
            this.checkFileData.Size = new System.Drawing.Size(88, 17);
            this.checkFileData.TabIndex = 11;
            this.checkFileData.Text = "Data from file";
            this.checkFileData.UseVisualStyleBackColor = true;
            this.checkFileData.CheckedChanged += new System.EventHandler(this.checkFileData_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search pattern:";
            // 
            // txtSearchPattern
            // 
            this.txtSearchPattern.Location = new System.Drawing.Point(92, 45);
            this.txtSearchPattern.Name = "txtSearchPattern";
            this.txtSearchPattern.Size = new System.Drawing.Size(112, 20);
            this.txtSearchPattern.TabIndex = 14;
            this.txtSearchPattern.Text = "*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkOnlyTop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchPattern);
            this.groupBox1.Controls.Add(this.txtFolderIn);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 72);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder to search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFileIn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkFileData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnSelectFile);
            this.groupBox2.Controls.Add(this.txtDataIn);
            this.groupBox2.Location = new System.Drawing.Point(0, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 173);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search data";
            // 
            // checkOnlyTop
            // 
            this.checkOnlyTop.AutoSize = true;
            this.checkOnlyTop.Checked = true;
            this.checkOnlyTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOnlyTop.Location = new System.Drawing.Point(366, 47);
            this.checkOnlyTop.Name = "checkOnlyTop";
            this.checkOnlyTop.Size = new System.Drawing.Size(94, 17);
            this.checkOnlyTop.TabIndex = 15;
            this.checkOnlyTop.Text = "Only top folder";
            this.checkOnlyTop.UseVisualStyleBackColor = true;
            // 
            // RapidUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RapidUI";
            this.Text = "Rapid Search ~~ by pleonex";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtDataIn;
        private System.Windows.Forms.TextBox txtFolderIn;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtFileIn;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkFileData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPattern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkOnlyTop;
    }
}