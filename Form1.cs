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

namespace Examentest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examenDataSet1.examen' table. You can move, or remove it, as needed.
            this.examenTableAdapter1.Fill(this.examenDataSet1.examen);

        }

        private void buttonAjt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U783UJF\\SQLEXPRESS;Initial Catalog=TestExamen;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into examen values('" + int.Parse(textBox1.Text) + "', '" + int.Parse(textBox2.Text) + "', '" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+ "')", con);
            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté avec success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
