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
    public partial class Form4 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataTable dt;
        private SqlCommand cmd;
        private int ID = 0;

        public Form4()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kovex\OneDrive - Technical University of Cluj-Napoca\AN 3 2021-2022\Semestrul 2\ii\laborator2\laborator3\baze-de-date\baze-de-date\Database1.mdf; Integrated Security = True";
            DisplayData();
        }


        private void DisplayData()
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Facultati", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void ClearData()
        {
            textB_code.Text = "";
            textB_Fname.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if(textB_Fname.Text != "" && textB_code.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Facultati (Code, NameFac) VALUES (@Cod, @NumeFacultate)",conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Cod", Convert.ToInt32(textB_code.Text));
                cmd.Parameters.AddWithValue("@NumeFacultate", textB_Fname.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserat cu succes!");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                DisplayData();
                ClearData();
            } else
            {
                MessageBox.Show("Completati datele de inserat!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (textB_code.Text != "" && textB_Fname.Text != "")
            {
                cmd = new SqlCommand("UPDATE Facultati SET Code = @Cod, NameFac = @NumeF WHERE Id = @Id",conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Cod", Convert.ToInt32(textB_code.Text));
                cmd.Parameters.AddWithValue("@NumeF", textB_Fname.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully.");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                DisplayData();
                ClearData();
            }
            else MessageBox.Show("Selectati datele de modificat!");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textB_Fname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textB_code.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("DELETE FROM Facultati WHERE Id = @ID",conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Linie stearsa cu succes.");
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                DisplayData();
                ClearData();
            }
            else MessageBox.Show("Selectati un rand pentru stergere!");
        }
    }
}
