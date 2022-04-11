using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator2.ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void scadereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void inmultireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void impartireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void restToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "%";
            try
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "AND";
            bool tb1, tb2;
                if (textBox1.Text == "1") tb1 = true;
                else tb1 = false;
                if(textBox2.Text == "1") tb2 = true;
                else tb2 = false; 
                if(tb1 && tb2) textBox3.Text = "1";
                else textBox3.Text = "0";
                if (textBox1.Text != "0" && textBox1.Text != "1") MessageBox.Show("When binary operating, type 0 or 1 in the boxes.", "Error");
        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "OR";
            bool tb1, tb2;
            if (textBox1.Text == "1") tb1 = true;
            else tb1 = false;
            if (textBox2.Text == "1") tb2 = true;
            else tb2 = false;
            if (tb1 || tb2) textBox3.Text = "1";
            else textBox3.Text = "0";
            if (textBox1.Text != "0" && textBox1.Text != "1") MessageBox.Show("When binary operating, type 0 or 1 in the boxes.", "Error");

        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "XOR";
            bool tb1, tb2;
            if (textBox1.Text == "1") tb1 = true;
            else tb1 = false;
            if (textBox2.Text == "1") tb2 = true;
            else tb2 = false;
            if (tb1 ^ tb2) textBox3.Text = "1";
            else textBox3.Text = "0";
            if (textBox1.Text != "0" && textBox1.Text != "1") MessageBox.Show("When binary operating, type 0 or 1 in the boxes.", "Error");

        }

        private void nXORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "NXOR";
            bool tb1, tb2;
            if (textBox1.Text == "1") tb1 = true;
            else tb1 = false;
            if (textBox2.Text == "1") tb2 = true;
            else tb2 = false;
            if (!(tb1 ^ tb2)) textBox3.Text = "1";
            else textBox3.Text = "0";
            if (textBox1.Text != "0" && textBox1.Text != "1") MessageBox.Show("When binary operating, type 0 or 1 in the boxes.", "Error");

        }

        private void nANDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "NAND";
            bool tb1, tb2;
            if (textBox1.Text == "1") tb1 = true;
            else tb1 = false;
            if (textBox2.Text == "1") tb2 = true;
            else tb2 = false;
            if (!(tb1 && tb2)) textBox3.Text = "1";
            else textBox3.Text = "0";
            if (textBox1.Text != "0" && textBox1.Text != "1") MessageBox.Show("When binary operating, type 0 or 1 in the boxes.", "Error");

        }

        private void nORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "NOR";
            bool tb1, tb2;
            if (textBox1.Text == "1") tb1 = true;
            else tb1 = false;
            if (textBox2.Text == "1") tb2 = true;
            else tb2 = false;
            if (!(tb1 || tb2)) textBox3.Text = "1";
            else textBox3.Text = "0";
            if (textBox1.Text != "0" && textBox1.Text != "1") MessageBox.Show("When binary operating, type 0 or 1 in the boxes.", "Error");

        }
    }
}
