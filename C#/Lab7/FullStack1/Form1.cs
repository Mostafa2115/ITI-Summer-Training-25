using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace FullStack1
{
    public partial class Form1 : Form
    {
        SqlDataAdapter adapter;
        SqlConnection connection;
        DataSet ds;
        SqlCommand select;
        SqlCommand insert;
        public Form1()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter();
            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=FS_DB;Integrated Security=True;TrustServerCertificate=True";
            ds = new DataSet();

            select = new SqlCommand();
            select.Connection = connection;
            select.CommandText = "Select * From Employee";
            adapter.SelectCommand = select;

            insert = new SqlCommand();
            insert.Connection = connection;
            insert.CommandText = "Insert Into Employee (id, Emp_name, Emp_dept) Values(@id, @Emp_name, @Emp_dept)";
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, 0, "id");
            SqlParameter nameParam = new SqlParameter("@Emp_name", SqlDbType.VarChar, 50, "Emp_name");
            SqlParameter departmentParam = new SqlParameter("@Emp_dept", SqlDbType.VarChar, 50, "Emp_dept");
            insert.Parameters.Add(idParam);
            insert.Parameters.Add(nameParam);
            insert.Parameters.Add(departmentParam);
            adapter.InsertCommand = insert;


            SqlCommand delete = new SqlCommand();
            delete.Connection = connection;
            delete.CommandText = "DELETE FROM Employee WHERE id = @id";
            SqlParameter idParamD = new SqlParameter("@id", SqlDbType.Int, 0, "id");
            delete.Parameters.Add(idParamD);
            adapter.DeleteCommand = delete;


        }
        // connect to DB
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            adapter.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds.Tables[0];

        }
        // insert data
        private void button2_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Count > 0 && ds.Tables[0].Columns.Contains("id") && ds.Tables[0].Columns.Contains("Emp_name") && ds.Tables[0].Columns.Contains("Emp_dept"))
            {
                DataRow row = ds.Tables[0].NewRow();
                row["id"] = int.Parse(textBox1.Text);
                row["Emp_name"] = textBox2.Text;
                row["Emp_dept"] = textBox3.Text;
                ds.Tables[0].Rows.Add(row);
                //adapter.Update(ds.Tables[0]);
            }
            else
            {
                MessageBox.Show("No tables available in the DataSet.");
            }

        }
        // save to DB

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            adapter.Update(ds);
            connection.Close();
            MessageBox.Show("Data updated successfully.");

        }
        // delete row

        private void button4_Click(object sender, EventArgs e)
        {
            // delete the selected row
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dataGridView1.SelectedRows)
                {
                    if (!dgvRow.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(dgvRow);
                    }
                }
                MessageBox.Show("Row deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
