using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-ATBVJFQ\\SQLEXPRESS; Initial Catalog=regdb; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true;
        string sql;

        public void Load()
        {
            try
            {
                sql = "select * from student";
                cmd = new SqlCommand(sql, con);
                con.Open();

                read = cmd.ExecuteReader();
                dataGridView2.Rows.Clear();

                while (read.Read())
                {
                    dataGridView2.Rows.Add(read[0], read[1], read[2], read[3]);
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void getId(string id)
        {
            sql = "select * from student where id ='" + id + "' ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                txtName.Text = read[1].ToString();
                txtCourse.Text = read[2].ToString();
                txtFee.Text = read[3].ToString();

            }
            con.Close();
        }







        //if the mode is true means add records otherwise update the record

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string course = txtCourse.Text;
            string fee = txtFee.Text;

            if (Mode == true)
            {
                sql = "insert into student(stdname,course,fee) values(@stdname,@course,@fee)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stdname", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@fee", fee);
                MessageBox.Show("Record Added!");
                cmd.ExecuteNonQuery();

                txtName.Clear();
                txtCourse.Clear();
                txtFee.Clear();
                txtName.Focus();
            }
            else
            {
                id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                sql = "update student set stdname = @stdname, course= @course, fee= @fee where id =@id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@stdname", name);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@fee", fee);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Record Updated!");
                cmd.ExecuteNonQuery();

                txtName.Clear();
                txtCourse.Clear();
                txtFee.Clear();
                txtName.Focus();
                button1.Text = "Save";
                Mode = true;
            }
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                getId(id);
                button1.Text = "Edit";


            }
            else if (e.ColumnIndex == dataGridView2.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from student where id = @id";

                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                con.Close();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCourse.Clear();
            txtFee.Clear();
            txtName.Focus();
            button1.Text = "Save";
            Mode = true;
        }
    }
}
