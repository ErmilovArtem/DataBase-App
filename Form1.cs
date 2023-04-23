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
    public partial class Form1 : Form
    {

        // public string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
        private OleDbConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = БД_ЛР_6.mdb";
            connection = new OleDbConnection(connectionString);
            connection.Open();
            dataGridView1.Columns[5].DefaultCellStyle.Format = "HH:mm";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet.Кафедра". При необходимости она может быть перемещена или удалена.
            this.кафедраTableAdapter.Fill(this.бД_ЛР_6DataSet.Кафедра);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet.Аудитория". При необходимости она может быть перемещена или удалена.
            this.аудиторияTableAdapter.Fill(this.бД_ЛР_6DataSet.Аудитория);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet.Предмет". При необходимости она может быть перемещена или удалена.
            this.предметTableAdapter.Fill(this.бД_ЛР_6DataSet.Предмет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet.Преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.бД_ЛР_6DataSet.Преподаватель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet.Группа". При необходимости она может быть перемещена или удалена.
            this.группаTableAdapter.Fill(this.бД_ЛР_6DataSet.Группа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet.Занятие". При необходимости она может быть перемещена или удалена.
            this.занятиеTableAdapter.Fill(this.бД_ЛР_6DataSet.Занятие);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        private void deleteLesson_Click(object sender, EventArgs e)
        {
            int number;
            if (numAuditorium.Text != "")
            {
                number = Convert.ToInt32(numAuditorium.Text);
                string query = "DELETE FROM Занятие WHERE [Номер аудитории] = " + number;
                OleDbCommand command = new OleDbCommand(query, connection);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            } 
            
        }

        private void updateLesson_Click(object sender, EventArgs e)
        {
            int id;
            int numder;
            if (idSubject.Text != "" && numberTeacher.Text != "" )
            {
                id = Convert.ToInt32(idSubject.Text);
                numder = Convert.ToInt32(numberTeacher.Text);

                //string query = "UPDATE Занятие SET [Табельный номер] =" + numder + " WHERE [Идентификатор предмета] = " + id;
                string query_check_id = "Select * From Занятие Where [Идентификатор предмета] = " + id;
                string query_check_number = "Select * From Преподаватель Where [Табельный номер] = " + numder;
                OleDbCommand comm_check_id = new OleDbCommand(query_check_id, connection);
                OleDbCommand comm_check_num = new OleDbCommand(query_check_number, connection);

                int count_id = Convert.ToInt32(comm_check_id.ExecuteScalar());
                int count_num = Convert.ToInt32(comm_check_num.ExecuteScalar());
                if (count_id > 0 && count_num > 0)
                {
                    string query = "UPDATE Занятие SET [Табельный номер] =" + numder + " WHERE [Идентификатор предмета] = " + id;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные изменены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
            
        }

        private void addLesson_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Owner = this;
            addForm.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.кафедраTableAdapter.Fill(this.бД_ЛР_6DataSet.Кафедра);
            this.аудиторияTableAdapter.Fill(this.бД_ЛР_6DataSet.Аудитория);
            this.предметTableAdapter.Fill(this.бД_ЛР_6DataSet.Предмет);
            this.преподавательTableAdapter.Fill(this.бД_ЛР_6DataSet.Преподаватель);
            this.группаTableAdapter.Fill(this.бД_ЛР_6DataSet.Группа);
            this.занятиеTableAdapter.Fill(this.бД_ЛР_6DataSet.Занятие);
        }

        private void todayLessonsButton_Click(object sender, EventArgs e)
        {
            ScheduleForm schedule = new ScheduleForm();
            schedule.Owner = this;
            schedule.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteGroup_Click(object sender, EventArgs e)
        {
            if (numGroup1.Text != "")
            {
                int number = Convert.ToInt32(numGroup1.Text);
                string querty_check = "Select * From Группа Where[Номер группы] = " + number;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Группа WHERE Группа.[Номер группы] =" + number;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void updateGroup_Click(object sender, EventArgs e)
        {
            if (numGroup2.Text != "" && countStudents.Text != "")
            {
                int number = Convert.ToInt32(numGroup2.Text);
                int countStudents = Convert.ToInt32(this.countStudents.Text);

                string querty_check = "Select * From Группа Where [Номер группы] = " + number;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());

                if (count > 0)
                {
                    string query = "UPDATE Группа SET [Количество студентов] =" + countStudents + " WHERE [Номер группы] = " + number;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные добавлены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void addGroup_Click(object sender, EventArgs e)
        {
            if (numGropAdd.Text != "" && facultyAdd.Text != "" && countStudentsAdd.Text != "")
            {
                int numGroup = Convert.ToInt32(numGropAdd.Text);
                string faculty = facultyAdd.Text;
                int countStudents = Convert.ToInt32(countStudentsAdd.Text);

                //string query_check = "select * from Аудитория, Группа, Предмет, Преподаватель where "

                string query = "INSERT INTO Группа ([Номер группы], [Факультет], [Количество студентов])" +
                                "VALUES (" + numGroup + ", '" + faculty + "', " + countStudents + ")";
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

        private void button1_Click(object sender, EventArgs e)
        {
            CountStudentsForm countStudents = new CountStudentsForm();
            countStudents.Owner = this;
            countStudents.Show();
        }

        /// <summary>
        /// удаление преподавателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (numberTeacher1.Text != "")
            {
                int number = Convert.ToInt32(numberTeacher1.Text);
                string querty_check = "Select * From Преподаватель Where[Табельный номер] = " + number;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Преподаватель WHERE Преподаватель.[Табельный номер] =" + number;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// Обновление должности преподавателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (numberTeacher2.Text != "" && textBox1.Text != "")
            {
                int number = Convert.ToInt32(numberTeacher2.Text);
                string post = textBox1.Text;

                string querty_check = "Select * From Преподаватель Where [Табельный номер] = " + number;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());

                if (count > 0)
                {
                    string query = "UPDATE Преподаватель SET [Должность] ='" + post + "' WHERE [Табельный номер] = " + number;
                    try
                    {
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные обновлены!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Введенные данные неверны!");
                    }

                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// добавление преподавателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            AddTeacherForm teacherForm = new AddTeacherForm();
            teacherForm.Owner = this;
            teacherForm.Show();
        }
        /// <summary>
        /// кол-во занятий по типам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            TypesForm types = new TypesForm();
            types.Owner = this;
            types.Show();
        }
        /// <summary>
        /// удаление предмета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                int id = Convert.ToInt32(maskedTextBox1.Text);
                string querty_check = "Select * From Предмет Where[Идентификатор предмета] = " + id;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Предмет WHERE Предмет.[Идентификатор предмета] =" + id;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
        
        /// <summary>
        /// обновление предмета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text != "" && maskedTextBox3.Text != "")
            {
                int id = Convert.ToInt32(maskedTextBox2.Text);
                int countH = Convert.ToInt32(maskedTextBox3.Text);

                string querty_check = "Select * From Предмет Where [Идентификатор предмета] = " + id;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());

                if (count > 0)
                {
                    string query = "UPDATE Предмет SET [Количество часов] =" + countH + " WHERE [Идентификатор предмета] = " + id;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные обновлены!");

                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }

            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
        /// <summary>
        /// добавление предмета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (maskedTextBox4.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox5.Text != "" && maskedTextBox6.Text != "")
            {
                int id = Convert.ToInt32(maskedTextBox4.Text);
                string name = textBox2.Text;
                string sortName = textBox3.Text;
                int countH = Convert.ToInt32(maskedTextBox5.Text);
                int numTab = Convert.ToInt32(maskedTextBox6.Text);

                //string query_check = "select * from Аудитория, Группа, Предмет, Преподаватель where "

                string query = "INSERT INTO Предмет ([Идентификатор предмета], [Название], [Короткое название], [Количество часов], [Табельный номер])" +
                                "VALUES (" + id + ", '" + name + "', '" + sortName + "', " + countH + ", " + numTab + ")";
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

        /// <summary>
        /// удалить аудиторию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            if (maskedTextBox11.Text != "")
            {
                int number = Convert.ToInt32(maskedTextBox11.Text);
                string querty_check = "Select * From Аудитория Where[Номер аудитории] = " + number;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Аудитория WHERE Аудитория.[Номер аудитории] =" + number;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// обновить аудиторию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            if (maskedTextBox12.Text != "" && textBox5.Text != "")
            {
                int number = Convert.ToInt32(maskedTextBox12.Text);
                string type = textBox5.Text;

                string querty_check = "Select * From Аудитория Where [Номер аудитории] = " + number;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());

                if (count > 0)
                {
                    string query = "UPDATE Аудитория SET [Тип аудитории] ='" + type + "' WHERE [Номер аудитории] = " + number;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные обновлены!");

                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// Добавить аудиторию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (maskedTextBox9.Text != "" && maskedTextBox7.Text != "" && maskedTextBox10.Text != "" && textBox4.Text != "" && maskedTextBox8.Text != "")
            {
                int number = Convert.ToInt32(maskedTextBox9.Text);
                int floor = Convert.ToInt32(maskedTextBox7.Text);
                int corpus = Convert.ToInt32(maskedTextBox10.Text);
                string type = textBox4.Text;
                int capacity = Convert.ToInt32(maskedTextBox8.Text);

                //string query_check = "select * from Аудитория, Группа, Предмет, Преподаватель where "

                string query = "INSERT INTO Аудитория ([Номер аудитории], [Этаж], [Корпус], [Тип аудитории], [Вместимость])" +
                                "VALUES (" + number + ", " + floor + ", " + corpus + ", '" + type + "', " + capacity + ")";
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

        /// <summary>
        /// запрос с параметром по аудитории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            if (maskedTextBox13.Text != "")
            {
                int number = Convert.ToInt32(maskedTextBox13.Text);
                string query = "Select Занятие.[Номер группы], Занятие.[Номер аудитории], Предмет.[Короткое название], Занятие.[Дата проведения], Занятие.[Время проведения], Занятие.[Тип] " +
                               "From Предмет INNER JOIN Занятие ON Предмет.[Идентификатор предмета] = Занятие.[Идентификатор предмета]" +
                               "Where (Занятие.[Номер аудитории] = " + @number + ")";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@number", number);

                int sum = this.dataGridView8.Columns.Count;
                for (int i = 0; i < sum; i++)
                {
                    this.dataGridView7.Columns.RemoveAt(0);
                }

                OleDbDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    List<string[]> data = new List<string[]>();
                    // получаем строки одну за другой, и для каждой строки...
                    while (rd.Read())
                    {
                        data.Add(new string[6]);

                        data[data.Count - 1][0] = rd[0].ToString();
                        data[data.Count - 1][1] = rd[1].ToString();
                        data[data.Count - 1][2] = rd[2].ToString();
                        data[data.Count - 1][3] = rd[3].ToString();
                        data[data.Count - 1][4] = rd[4].ToString();
                        data[data.Count - 1][5] = rd[5].ToString();
                    }

                    rd.Close();
                    
                    var column1 = new DataGridViewTextBoxColumn();
                    var column2 = new DataGridViewTextBoxColumn();
                    var column3 = new DataGridViewTextBoxColumn();
                    var column4 = new DataGridViewTextBoxColumn();
                    var column5 = new DataGridViewTextBoxColumn();
                    var column6= new DataGridViewTextBoxColumn();

                    column1.HeaderText = "Номер группы";
                    column2.HeaderText = "Номер аудитории";
                    column3.HeaderText = "Короткое название";
                    column4.HeaderText = "Дата проведения";
                    column5.HeaderText = "Время проведения";
                    column6.HeaderText = "Тип";
                    

                    dataGridView7.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4, column5, column6 });

                    foreach (string[] s in data)
                        dataGridView7.Rows.Add(s);
                }
                else
                {
                    MessageBox.Show("По запросу ничего не найдено");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
        /// <summary>
        /// Удаление кафедры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            if (maskedTextBox15.Text != "")
            {
                int id = Convert.ToInt32(maskedTextBox15.Text);
                string querty_check = "Select * From Кафедра Where[Идентификатор кафедры] = " + id;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count > 0)
                {
                    string query = "DELETE FROM Кафедра WHERE Кафедра.[Идентификатор кафедры] =" + id;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// Обновление кафедры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (maskedTextBox14.Text != "" && maskedTextBox16.Text != "")
            {
                int id = Convert.ToInt32(maskedTextBox14.Text);
                int countStav = Convert.ToInt32(maskedTextBox16.Text);

                string querty_check = "Select * From Кафедра Where [Идентификатор кафедры] = " + id;
                OleDbCommand comm = new OleDbCommand(querty_check, connection);
                int count = Convert.ToInt32(comm.ExecuteScalar());

                if (count > 0)
                {
                    string query = "UPDATE Кафедра SET [Количество ставок] ='" + countStav + "' WHERE [Идентификатор кафедры] = " + id;
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные обновлены!");

                }
                else
                {
                    MessageBox.Show("Данных с указанными параметрами не существует!");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// добавление кафедры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            DepartmentForm department = new DepartmentForm();
            department.Owner = this;
            department.Show();
        }

        /// <summary>
        /// Вывод информациии о кафедрах и преподавателях
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            if (maskedTextBox17.Text != "")
            {
                int id = Convert.ToInt32(maskedTextBox17.Text);
                string query = "Select Кафедра.[Сокращенное название], Преподаватель.[Фамилия], Преподаватель.[Имя], Преподаватель.[Стаж работы] " +
                               "From Кафедра INNER JOIN Преподаватель ON Кафедра.[Идентификатор кафедры] = Преподаватель.[Идентификатор кафедры]" +
                               "Where (Преподаватель.[Идентификатор кафедры] = " + @id + ")";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                int sum = this.dataGridView8.Columns.Count;
                for (int i = 0; i < sum; i++)
                {
                    this.dataGridView8.Columns.RemoveAt(0);
                }

                OleDbDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    List<string[]> data = new List<string[]>();
                    // получаем строки одну за другой, и для каждой строки...
                    while (rd.Read())
                    {
                        data.Add(new string[6]);

                        data[data.Count - 1][0] = rd[0].ToString();
                        data[data.Count - 1][1] = rd[1].ToString();
                        data[data.Count - 1][2] = rd[2].ToString();
                        data[data.Count - 1][3] = rd[3].ToString();
                    }

                    rd.Close();

                    var column1 = new DataGridViewTextBoxColumn();
                    var column2 = new DataGridViewTextBoxColumn();
                    var column3 = new DataGridViewTextBoxColumn();
                    var column4 = new DataGridViewTextBoxColumn();
                    
                    column1.HeaderText = "Сокращенное название";
                    column2.HeaderText = "Фамилия";
                    column3.HeaderText = "Короткое название";
                    column4.HeaderText = "Стаж работы";


                    dataGridView8.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4});

                    foreach (string[] s in data)
                        dataGridView8.Rows.Add(s);
                }
                else
                {
                    MessageBox.Show("По запросу ничего не найдено");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        /// <summary>
        /// вывод информации по должностям преподавателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                string post = textBox6.Text;
                string query = "Select Преподаватель.[Фамилия], Преподаватель.[Имя], Преподаватель.[Стаж работы], Предмет.[Короткое название] " +
                               "From Преподаватель INNER JOIN Предмет ON Преподаватель.[Табельный номер] = Предмет.[Табельный номер]" +
                               "Where (Преподаватель.[Должность] = '" + @post + "')";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@post", post);

                int sum = this.dataGridView9.Columns.Count;
                for (int i = 0; i < sum; i++)
                {
                    this.dataGridView9.Columns.RemoveAt(0);
                }

                OleDbDataReader rd = command.ExecuteReader();
                if (rd.HasRows)
                {
                    List<string[]> data = new List<string[]>();
                    // получаем строки одну за другой, и для каждой строки...
                    while (rd.Read())
                    {
                        data.Add(new string[6]);

                        data[data.Count - 1][0] = rd[0].ToString();
                        data[data.Count - 1][1] = rd[1].ToString();
                        data[data.Count - 1][2] = rd[2].ToString();
                        data[data.Count - 1][3] = rd[3].ToString();
                    }

                    rd.Close();

                    var column1 = new DataGridViewTextBoxColumn();
                    var column2 = new DataGridViewTextBoxColumn();
                    var column3 = new DataGridViewTextBoxColumn();
                    var column4 = new DataGridViewTextBoxColumn();

                    column1.HeaderText = "Фамилия";
                    column2.HeaderText = "Имя";
                    column3.HeaderText = "Стаж работы";
                    column4.HeaderText = "Короткое название";


                    dataGridView9.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });

                    foreach (string[] s in data)
                        dataGridView9.Rows.Add(s);
                }
                else
                {
                    MessageBox.Show("По запросу ничего не найдено");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }
    }
}
