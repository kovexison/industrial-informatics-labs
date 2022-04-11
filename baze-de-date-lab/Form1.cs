using System.Data.SqlClient;
using System.Data;

namespace baze_de_date
{
    public partial class Form1 : Form
    {
        private SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;

        public Form1()
        {
            InitializeComponent();
            refreshLists();
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
            foreach(DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if(univSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxOras.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBoxCod.Text = code.ToString();
                }
            }

            foreach(DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if(code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBoxFacultati.Items.Add(nameFac);
                }
            }
        }

        private void addUnivButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void deleteUniButton_Click(object sender, EventArgs e)
        {
            Exception errorOccurred = null;
            String uniToDelete = listBoxUniv.SelectedItem.ToString();
            if (string.IsNullOrEmpty(uniToDelete))
            {
                MessageBox.Show("Pentru a sterge o Universitate, trebuie sa selectati una.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int code = -1;
                foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                {
                    if (uniToDelete == dr.ItemArray.GetValue(1).ToString())
                    {
                        code = Convert.ToInt32(dr.ItemArray.GetValue(3));
                    }
                }
                if (code != -1)
                {
                    String query = "DELETE FROM Facultati WHERE Code = @Code";
                    myCon.Open();
                    SqlCommand deleteFacCommand = new SqlCommand(query, myCon);
                    deleteFacCommand.Parameters.AddWithValue("@Code", code);

                    query = "DELETE FROM Universitati WHERE NameUniv = @Name";
                    SqlCommand deleteUniCommand = new SqlCommand(query, myCon);
                    deleteUniCommand.Parameters.AddWithValue("@Name", uniToDelete);
                    try
                    {
                        deleteFacCommand.ExecuteNonQuery();
                        deleteUniCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        errorOccurred = ex;
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (errorOccurred == null)
                        MessageBox.Show(uniToDelete + " deleted successfully.");
                    myCon.Close();
                    refreshLists();
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
            
        }

        private void deleteFacultyButton_Click(object sender, EventArgs e)
        {
            String facToDelete = listBoxFacultati.SelectedItem.ToString();
            if (string.IsNullOrEmpty(facToDelete))
            {
                MessageBox.Show("Pentru a sterge o Facultate, trebuie sa selectati una.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                myCon.Open();
                String query = "DELETE FROM Facultati WHERE NameFac = @NameToDelete";
                SqlCommand deleteCommand = new SqlCommand(query, myCon);
                deleteCommand.Parameters.AddWithValue("@NameToDelete", facToDelete);
                try
                {
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show(facToDelete + " deleted successfully from database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                myCon.Close();
                refreshLists();
            }
        }

        private void dataGridViewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().ShowDialog();
        }
    }
}