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
    public partial class AddTeacherForm : Form
    {

        private OleDbConnection connection;

        public AddTeacherForm()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }
        /// <summary>
        /// добавление преподавателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, EventArgs e)
        {
            if (numTeacherAdd.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && maskedTextBox1.Text != "" && maskedTextBox2.Text != "")
            {
                int numerTeacher = Convert.ToInt32(numTeacherAdd.Text);
                string surname = textBox1.Text;
                string name = textBox2.Text;
                string patronymic = textBox3.Text;
                string post = textBox4.Text;
                int experience = Convert.ToInt32(maskedTextBox1.Text);
                int id = Convert.ToInt32(maskedTextBox2.Text);

                string query = "INSERT INTO Преподаватель ([Табельный номер], [Фамилия], [Имя], [Отчество], [Должность], [Стаж работы], [Идентификатор кафедры])" +
                                "VALUES (" + numerTeacher + ", '" + surname + "', '" + name + "', '" + patronymic + "', '" + post + "', " + experience + ", " + id + ")";
                try
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введенные данные неверны!");
                }


            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numTeacherAdd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
