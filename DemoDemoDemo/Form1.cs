using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace DemoDemoDemo
{
    public partial class Form1 : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = db.edu.cchgeu.ru; Initial Catalog = 193_Goncharov; User = 193_Goncharov; Password = Qq123123;");

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите для поиска";
            textBox1.ForeColor = Color.Gray;

            comboBox1.Text = "Сортировка";
            comboBox1.ForeColor = Color.Black;
            comboBox1.Items.Add("Наименование");
            comboBox1.Items.Add("Минимальная стоимость");

            comboBox2.Text = "Фильтрация";
            comboBox2.ForeColor = Color.Black;


        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT Image FROM Product WHERE ID = '" + textBox1.Text + "' ";

            SqlCommand command = new SqlCommand(selectQuery, dataBase.GetConnection());

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            textBox2.Text = table.Rows[0][1].ToString();
            textBox3.Text = table.Rows[0][2].ToString();

            byte[] img = (byte[])table.Rows[0][3];


            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            adapter.Dispose();
        }

        private void button1_Next_Click(object sender, EventArgs e)
        {

        }
    }
}
