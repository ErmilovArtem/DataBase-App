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
//using LR7_BD.Form1.UpdateTables;

namespace LR7_BD
{
    public partial class AddForm : Form
    {
        private OleDbConnection connection;

        public AddForm()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (numAuditAdd.Text != "" && numGroupAdd.Text != "" && idSubjectAdd.Text != "" && numTeacherAdd.Text != "" && dayAdd.Text != "" && timeAdd.Text != "" && typeAdd.Text != "")
            {
                int numAuditorium = Convert.ToInt32(numAuditAdd.Text);
                int numGroup = Convert.ToInt32(numGroupAdd.Text);
                int idSub = Convert.ToInt32(idSubjectAdd.Text);
                int numTeacher = Convert.ToInt32(numTeacherAdd.Text);
                string day = dayAdd.Text;
                string time = timeAdd.Text;
                string type = typeAdd.Text;

                //string query_check = "select * from Аудитория, Группа, Предмет, Преподаватель where "

                string query = "INSERT INTO Занятие ([Номер аудитории], [Номер группы], [Идентификатор предмета], [Табельный номер], [День проведения], [Время проведения], Тип)" +
                                "VALUES (" + numAuditorium + ", " + numGroup + ", " + idSub + ", " + numTeacher + ", '" + day + "', #" + time + "#, '" + type + "')";
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

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 Form1 = new Form1();
            //Form1.UpdateTables();
        }
    }
}
