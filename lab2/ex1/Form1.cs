using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator2.ex1
{
    public partial class Form1 : Form
    {
        private static string userName;
        private static string password;
        public Form1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "C:\\Users\\kovex\\OneDrive - Technical University of Cluj-Napoca\\AN 3 2021-2022\\Semestrul 2\\ii\\laborator2\\laborator2\\laborator2\\ex1\\credentials.txt");
            string line;
            if ((line = streamReader.ReadLine()) != null)
                userName = line;
            if ((line = streamReader.ReadLine()) != null)
                password = line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userName == usernameTextBox.Text && password == passwordTextBox.Text)
            {
                    this.Hide();
                    Form2 form2 = new Form2();
                    string hello = "Hello " + userName;
                    form2.label1.Text = hello;
                    form2.ShowDialog();    
            } else
            {
                anunt.Text = "Wrong username or password.";
            }
        }
    }
}
