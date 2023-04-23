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
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet._SQL_Расписание__многотабл___сорт_". При необходимости она может быть перемещена или удалена.
            this.sQL_Расписание__многотабл___сорт_TableAdapter.Fill(this.бД_ЛР_6DataSet._SQL_Расписание__многотабл___сорт_);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
