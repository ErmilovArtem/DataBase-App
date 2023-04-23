
namespace LR7_BD
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.бД_ЛР_6DataSet = new LR7_BD.БД_ЛР_6DataSet();
            this.sQLРасписаниемноготаблСортBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_Расписание__многотабл___сорт_TableAdapter = new LR7_BD.БД_ЛР_6DataSetTableAdapters.SQL_Расписание__многотабл___сорт_TableAdapter();
            this.номерАудиторииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.короткоеНазваниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ЛР_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLРасписаниемноготаблСортBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерАудиторииDataGridViewTextBoxColumn,
            this.номерГруппыDataGridViewTextBoxColumn,
            this.короткоеНазваниеDataGridViewTextBoxColumn,
            this.деньПроведенияDataGridViewTextBoxColumn,
            this.времяПроведенияDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sQLРасписаниемноготаблСортBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // бД_ЛР_6DataSet
            // 
            this.бД_ЛР_6DataSet.DataSetName = "БД_ЛР_6DataSet";
            this.бД_ЛР_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLРасписаниемноготаблСортBindingSource
            // 
            this.sQLРасписаниемноготаблСортBindingSource.DataMember = "SQL Расписание (многотабл + сорт)";
            this.sQLРасписаниемноготаблСортBindingSource.DataSource = this.бД_ЛР_6DataSet;
            // 
            // sQL_Расписание__многотабл___сорт_TableAdapter
            // 
            this.sQL_Расписание__многотабл___сорт_TableAdapter.ClearBeforeFill = true;
            // 
            // номерАудиторииDataGridViewTextBoxColumn
            // 
            this.номерАудиторииDataGridViewTextBoxColumn.DataPropertyName = "Номер аудитории";
            this.номерАудиторииDataGridViewTextBoxColumn.HeaderText = "Номер аудитории";
            this.номерАудиторииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерАудиторииDataGridViewTextBoxColumn.Name = "номерАудиторииDataGridViewTextBoxColumn";
            this.номерАудиторииDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерГруппыDataGridViewTextBoxColumn
            // 
            this.номерГруппыDataGridViewTextBoxColumn.DataPropertyName = "Номер группы";
            this.номерГруппыDataGridViewTextBoxColumn.HeaderText = "Номер группы";
            this.номерГруппыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерГруппыDataGridViewTextBoxColumn.Name = "номерГруппыDataGridViewTextBoxColumn";
            this.номерГруппыDataGridViewTextBoxColumn.Width = 125;
            // 
            // короткоеНазваниеDataGridViewTextBoxColumn
            // 
            this.короткоеНазваниеDataGridViewTextBoxColumn.DataPropertyName = "Короткое название";
            this.короткоеНазваниеDataGridViewTextBoxColumn.HeaderText = "Короткое название";
            this.короткоеНазваниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.короткоеНазваниеDataGridViewTextBoxColumn.Name = "короткоеНазваниеDataGridViewTextBoxColumn";
            this.короткоеНазваниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // деньПроведенияDataGridViewTextBoxColumn
            // 
            this.деньПроведенияDataGridViewTextBoxColumn.DataPropertyName = "День проведения";
            this.деньПроведенияDataGridViewTextBoxColumn.HeaderText = "День проведения";
            this.деньПроведенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.деньПроведенияDataGridViewTextBoxColumn.Name = "деньПроведенияDataGridViewTextBoxColumn";
            this.деньПроведенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяПроведенияDataGridViewTextBoxColumn
            // 
            this.времяПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Время проведения";
            this.времяПроведенияDataGridViewTextBoxColumn.HeaderText = "Время проведения";
            this.времяПроведенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяПроведенияDataGridViewTextBoxColumn.Name = "времяПроведенияDataGridViewTextBoxColumn";
            this.времяПроведенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.Width = 125;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(273, 341);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(222, 46);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 399);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ScheduleForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ЛР_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLРасписаниемноготаблСортBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_ЛР_6DataSet бД_ЛР_6DataSet;
        private System.Windows.Forms.BindingSource sQLРасписаниемноготаблСортBindingSource;
        private БД_ЛР_6DataSetTableAdapters.SQL_Расписание__многотабл___сорт_TableAdapter sQL_Расписание__многотабл___сорт_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерАудиторииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерГруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn короткоеНазваниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exit;
    }
}