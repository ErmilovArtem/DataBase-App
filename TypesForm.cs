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
    public partial class TypesForm : Form
    {
        public TypesForm()
        {
            InitializeComponent();
        }

        private void TypesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_ЛР_6DataSet._SQL_Кол_во_занятий_в_неделю__Типы_". При необходимости она может быть перемещена или удалена.
            this.sQL_Кол_во_занятий_в_неделю__Типы_TableAdapter.Fill(this.бД_ЛР_6DataSet._SQL_Кол_во_занятий_в_неделю__Типы_);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
