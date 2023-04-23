using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LR7_BD
{
    public partial class DepartmentForm : Form
    {
        private OleDbConnection connection;
        public DepartmentForm()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            if (idDepart.Text != "" && maskedTextBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox2.Text != "")
            {
                int idDep = Convert.ToInt32(idDepart.Text);
                int numberTab = Convert.ToInt32(maskedTextBox1.Text);
                string name = textBox2.Text;
                string sortName = textBox3.Text;
                int count = Convert.ToInt32(maskedTextBox2.Text);

                string query = "INSERT INTO Кафедра ([Идентификатор кафедры], [Табельный номер], [Название], [Сокращенное название], [Количество ставок])" +
                                "VALUES (" + idDep + ", " + numberTab + ", '" + name + "', '" + sortName + "', " + count + ")";
                try
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
