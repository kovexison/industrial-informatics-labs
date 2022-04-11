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
    public partial class Form3 : Form
    {
        private SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;

        private int selectedFacId;
        private int selectedUniId;

        private int selectedUniCode;
        private String selectedUniCity;

        public Form3()
        {
            InitializeComponent();
            refreshLists();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void refreshLists()
        {
            listBoxUniv.Items.Clear();
            listBoxFacultati.Items.Clear();
            myCon.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kovex\OneDrive - Technical University of Cluj-Napoca\AN 3 2021-2022\Semestrul 2\ii\laborator2\laborator3\baze-de-date\baze-de-date\Database1.mdf; Integrated Security = True";
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                string name = dr.ItemArray.GetValue(1).ToString();
                listBoxUniv.Items.Add(name);
            }
            myCon.Close();
        }

        private void listBoxUniv_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFacultati.Items.Clear();
            textBoxOras.Clear();
            textBoxCod.Clear();
            int code = 0;
            String univSelected = listBoxUniv.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (univSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxOras.Text = dr.ItemArray.GetValue(2).ToString();
                    selectedUniCity = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    selectedUniCode = code;
                    textBoxCod.Text = code.ToString();
                    selectedUniId = Convert.ToInt32(dr.ItemArray.GetValue(0));
                    numeUnitextBox.Text = dr.ItemArray.GetValue(1).ToString();
                }
            }

            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBoxFacultati.Items.Add(nameFac);
                }
            }
        }

        private void listBoxFacultati_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNumeNouFac.Clear();
            textBoxNumeNouFac.Text = listBoxFacultati.SelectedItem.ToString();
            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (dr.ItemArray.GetValue(2).ToString() == listBoxFacultati.SelectedItem.ToString())
                {
                    selectedFacId = Convert.ToInt32(dr.ItemArray.GetValue(0));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNumeNouFac.Text == listBoxFacultati.SelectedItem.ToString())
            {
                MessageBox.Show("Numele facultatii nu a fost schimbat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                myCon.Open();
                String query = "UPDATE Facultati SET NameFac = @NameFac WHERE Id = @Id";
                SqlCommand updateCommand = new SqlCommand(query, myCon);
                updateCommand.Parameters.AddWithValue("@Id", selectedFacId);
                updateCommand.Parameters.AddWithValue("@NameFac", textBoxNumeNouFac.Text);
                try
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Numele facultatii a fost schimbat cu success.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                myCon.Close();
                refreshLists();
                textBoxNumeNouFac.Clear();
            }
        }

        private void changeOkButton_Click(object sender, EventArgs e)
        {
            bool messageShown = false;
            if (listBoxUniv.SelectedIndex.ToString() == numeUnitextBox.Text && selectedUniCity == textBoxOras.Text)
            {
                MessageBox.Show("Nu ati schimbat nimic.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                myCon.Open();
                if(listBoxUniv.SelectedIndex.ToString() != numeUnitextBox.Text)
                {
                    String query = "UPDATE Universitati SET NameUniv = @NewNameUniv WHERE Id = @Id";
                    SqlCommand updateCommand = new SqlCommand(query, myCon);
                    updateCommand.Parameters.AddWithValue("@NewNameUniv", numeUnitextBox.Text);
                    updateCommand.Parameters.AddWithValue("@Id", selectedUniId);
                    try
                    {
                        updateCommand.ExecuteNonQuery();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (selectedUniCity!= textBoxOras.Text)
                {
                    String query = "UPDATE Universitati SET City = @NewCity WHERE Id = @Id";
                    SqlCommand updateCommand = new SqlCommand(query, myCon);
                    updateCommand.Parameters.AddWithValue("@NewCity", textBoxOras.Text);
                    updateCommand.Parameters.AddWithValue("@Id", selectedUniId);
                    try
                    {
                        updateCommand.ExecuteNonQuery();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                myCon.Close();
            }
        }
    }
}
