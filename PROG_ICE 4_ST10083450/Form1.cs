using System.Data.SqlClient;

namespace PROG_ICE_4_ST10083450
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.cs))
                {
                    connection.Open();
                    String sql = "Select * from login where username='" + tbxUsername.Text + "' " + "and password= '" + tbxPassword.Text + "';";

                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Completed");
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials");
                    }
                    reader.Close();
                    command.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}