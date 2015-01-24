using System;
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
            int filecount = Directory.EnumerateFiles(txtPath.Text).Count();
            pgbProgress.Maximum = filecount;
            string directory = txtPath.Text;
            foreach(var file in new DirectoryInfo(directory).GetFiles("*.*"))
            {
                //file.Delete();
                if(HasUpperCase(file.Name))
                {
                    File.Move(directory + "/" +  file.Name, directory + "/" + file.Name.ToLower());
                    pgbProgress.Increment(1);
                }
                else
                {
                    pgbProgress.Increment(1);
                    continue;
                }
            }
            MessageBox.Show(filecount + " Files were renamed");
        }

        bool HasUpperCase(string str)
        {
            return !string.IsNullOrEmpty(str) && str.Any(c => char.IsUpper(c));
        }
    }
}
