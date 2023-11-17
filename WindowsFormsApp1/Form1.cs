using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, path;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult
.OK)
            {
                files = openFileDialog1.SafeFileNames;
                path = openFileDialog1.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
        }
    }
}
