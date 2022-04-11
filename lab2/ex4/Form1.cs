using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator2.ex4
{
    public partial class Form1 : Form
    {
        Image model3;
        Image modelS;
        Image modelX;
        Image modelY;
        Image semi;
        Image roadster;
        Image cybertruck;
        Image quad;
        Image logo;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Tesla Model S");
            listBox1.Items.Add("Tesla Model 3");
            listBox1.Items.Add("Tesla Model X");
            listBox1.Items.Add("Tesla Model Y");
            listBox1.Items.Add("Tesla Cybertruck");
            listBox1.Items.Add("Tesla Roadster");
            listBox1.Items.Add("Tesla Semi");
            listBox1.Items.Add("Tesla Quad");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            model3 = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\model_3.jpg");
            logo = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\logo.jpg");
            modelS = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\model_S.jpg");
            modelX = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\model_X.jpg");
            modelY = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\model_Y.jpg");
            quad = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\quad.jpg");
            semi = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\semi.jpg");
            roadster = Image.FromFile("C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex4\\poze\\roadster.jpg");
            pictureBox1.Image = logo;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(listBox1.SelectedItem == "Tesla Model S")
            {
                pictureBox1.Image = modelS;      
            }

            if (listBox1.SelectedItem == "Tesla Model 3")
            {
                pictureBox1.Image = model3;
            }

            if (listBox1.SelectedItem == "Tesla Model X")
            {
                pictureBox1.Image = modelX;
            }

            if (listBox1.SelectedItem == "Tesla Model Y")
            {
                pictureBox1.Image = modelY;
            }

            if (listBox1.SelectedItem == "Tesla Cybertruck")
            {
                pictureBox1.Image = cybertruck;
            }

            if (listBox1.SelectedItem == "Tesla Roadster")
            {
                pictureBox1.Image = roadster;
            }

            if (listBox1.SelectedItem == "Tesla Semi")
            {
                pictureBox1.Image = semi;
            }

            if (listBox1.SelectedItem == "Tesla Quad")
            {
                pictureBox1.Image = quad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton3.Checked)
                MessageBox.Show("1 0 1 0","Result");
            else if (radioButton2.Checked && radioButton3.Checked)
                MessageBox.Show("0 1 1 0","Result");
            else if (radioButton1.Checked && radioButton4.Checked)
                MessageBox.Show("1 0 0 1","Result");
            else if (radioButton2.Checked && radioButton4.Checked)
                MessageBox.Show("0 1 0 1","Result");
        }
    }
}
