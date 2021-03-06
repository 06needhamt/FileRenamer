﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dirSelect.ShowDialog(this);
            txtPath.Text = dirSelect.SelectedPath;
        }

        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            string RenameOperation = cboOperation.SelectedItem.ToString();
            pgbProgress.Value = pgbProgress.Minimum;
            switch(RenameOperation)
            {
                case "All Lower Case":
                {
                    LowerCaseNames();
                    break;
                }
                case "All Upper Case":
                {
                    UpperCaseNames();
                    break;
                }
                case "Spaces To Underscores":
                {
                    SpacesToUnderScores();
                    break;
                }
                case "Underscores To Spaces":
                {
                    UnderScoresToSpaces();
                    break;
                }
                case "Dashes To Underscores":
                {
                    DashesToUnderScores();
                    break;
                }
                case "Add String to start of name":
                {
                    AddCharacter();
                    break;
                }
                case "Remove String from File Name":
                {
                    RemoveString();
                    break;
                }
                default:
                {
                    MessageBox.Show("Please Select An Operation");
                    break;
                }

            }
        }

        private void RemoveString()
        {
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach(var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                if (file.Name.Contains(txtRemoveString.Text))
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.Replace(txtRemoveString + "_", string.Empty));
                    pgbProgress.Increment(1);
                    filesrenamed++;
                }
                else
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name);
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filesrenamed + " Files were renamed");
        }

        private void DashesToUnderScores()
        {
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach (var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                if (file.Name.Contains('-'))
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.Replace('-', '_'));
                    pgbProgress.Increment(1);
                    filesrenamed++;
                }
                else
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name);
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filesrenamed + " Files were renamed");
        }

        private void AddCharacter()
        {
            string stringtoadd = txtCharacter.Text;
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach (var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.Insert(0, stringtoadd));
                pgbProgress.Increment(1);
                filesrenamed++;
            }
                
            MessageBox.Show(filesrenamed + " Files were renamed");
   
        }

        private bool HasUpperCase(string str)
        {
            return !string.IsNullOrEmpty(str) && str.Any(c => char.IsUpper(c));
        }

        private bool HasLowerCase(string str)
        {
            return !string.IsNullOrEmpty(str) && str.Any(c => char.IsLower(c));
        }

        private void LowerCaseNames()
        {
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach (var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                //file.Delete();
                if (HasUpperCase(file.Name))
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.ToLower());
                    pgbProgress.Increment(1);
                    filesrenamed++;
                }
                else
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name);
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filesrenamed + " Files were renamed");
        }

        private void UpperCaseNames()
        {
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach (var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                //file.Delete();
                if (HasLowerCase(file.Name))
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.ToUpper());
                    pgbProgress.Increment(1);
                    filesrenamed++;
                }
                else
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name);
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filesrenamed++ + " Files were renamed");
        }
        private void SpacesToUnderScores()
        {
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach (var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                if (file.Name.Contains(' '))
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.Replace(' ', '_'));
                    pgbProgress.Increment(1);
                    filesrenamed++;
                }
                else
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name);
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filesrenamed + " Files were renamed");
        }
        private void UnderScoresToSpaces()
        {
            int filesrenamed = 0;
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            CreateOrEmptyDirectory(directory);
            foreach (var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                if (file.Name.Contains('_'))
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name.Replace('_', ' '));
                    pgbProgress.Increment(1);
                    filesrenamed++;
                }
                else
                {
                    File.Copy(directory + "\\" + file.Name, directory + "\\" + "Renamed" + "\\" + file.Name);
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filesrenamed + " Files were renamed");
        }

        private bool CreateOrEmptyDirectory(string directory)
        {
            if (Directory.Exists(directory + "\\" + "Renamed"))
            {
                foreach (string fileName in System.IO.Directory.GetFiles(directory + "\\" + "Renamed"))
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileName);
                    fileInfo.Attributes = FileAttributes.Normal;
                }
                Directory.Delete(directory + "\\" + "Renamed", true);
            }
            Directory.CreateDirectory(directory + "\\" + "Renamed");

            return true;
        }

        private void cboOperation_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboOperation.Text.Equals("Add String to start of name"))
            {
                txtCharacter.Enabled = true;
            }
            else
            {
                txtCharacter.Enabled = false;
            }

            if(cboOperation.Text.Equals("Remove String from File Name"))
            {
                txtRemoveString.Enabled = true;
            }
            else
            {
                txtRemoveString.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
