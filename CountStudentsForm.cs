using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR7_BD
{
    public partial class CountStudentsForm : Form
    {
        public CountStudentsForm()
        {
            InitializeComponent();
        }

        private void CountStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet._SQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_". При необходимости она может быть перемещена или удалена.
            this.sQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter.Fill(this.бД_ЛР_6DataSet._SQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
