using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator2.ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(path: "C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex2\\items.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
                listBox1.Items.Add(line);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
