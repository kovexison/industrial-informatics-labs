using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baze_de_date
{
    public partial class Form2 : Form
    {
        private SqlConnection myCon = new SqlConnection();
        private DataSet dsUniv;
        private DataSet dsFac;
        private int currentId = 0;
        private Form1 parentForm;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kovex\OneDrive - Technical University of Cluj-Napoca\AN 3 2021-2022\Semestrul 2\ii\laborator2\laborator3\baze-de-date\baze-de-date\Database1.mdf; Integrated Security = True";
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            currentId = dsUniv.Tables["Universitati"].Rows.Count + 1;
            myCon.Close();
        }

        private void addUniButton_Click(object sender, EventArgs e)
        {
            myCon.Open();
            String universityName = textBoxNumeUni.Text;
            String universityCity = textBoxOrasUni.Text;
            int codUni = Convert.ToInt32(textBoxCodUni.Text);

            String query = "INSERT INTO Universitati (NameUniv, City, Code)";
            query += " VALUES (@NameUniv, @City, @Code)";
            SqlCommand insertCommand = new SqlCommand(query, myCon);
            //insertCommand.Parameters.AddWithValue("@Id", currentId);
            insertCommand.Parameters.AddWithValue("@NameUniv", universityName);
            insertCommand.Parameters.AddWithValue("@City", universityCity);
            insertCommand.Parameters.AddWithValue("@Code", codUni);
            try
            {
                insertCommand.ExecuteNonQuery();
                MessageBox.Show(universityName + " adaugat cu succes in baza de date.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            myCon.Close();
            //SqlDataAdapter daUniv = new SqlDataAdapter("INSERT INTO Universitati (Id, NameUniv, City, Code) VALUES (" + currentId +", "+universityName+", "+universityCity+", "+codUni+")", myCon);

        }

        private void adaugaFacsButton_Click(object sender, EventArgs e)
        {
            myCon.Open();
            TextBox[] facNameBoxes = { textBoxFac1, textBoxFac2, textBoxFac3, textBoxFac4 };
            List<String> facNames = new List<String>();
            foreach(TextBox facBox in facNameBoxes)
            {
                if(facBox.Text != "")
                {
                    facNames.Add(facBox.Text);
                }
            }
            bool messageShown = false;
            if(facNames.Count > 0)
            foreach(String facName in facNames)
            {
                String query = "INSERT INTO Facultati (Code, NameFac)";
                query += " VALUES (@Code, @NameFac)";
                int codUni = Convert.ToInt32(textBoxCodUni.Text);
                SqlCommand insertCommand = new SqlCommand(query, myCon);
                insertCommand.Parameters.AddWithValue("@Code", codUni);
                insertCommand.Parameters.AddWithValue("@NameFac", facName);
                try
                {
                    insertCommand.ExecuteNonQuery();
                        if (!messageShown)
                        {
                            MessageBox.Show("Facultate adaugata cu succes in baza de date.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            messageShown = true;
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            myCon.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
