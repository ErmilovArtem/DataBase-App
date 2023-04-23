
namespace LR7_BD
{
    partial class TypesForm
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
            this.sQLКолвоЗанятийВНеделюТипыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_Кол_во_занятий_в_неделю__Типы_TableAdapter = new LR7_BD.БД_ЛР_6DataSetTableAdapters.SQL_Кол_во_занятий_в_неделю__Типы_TableAdapter();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоЗанятийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ЛР_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLКолвоЗанятийВНеделюТипыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.типDataGridViewTextBoxColumn,
            this.колвоЗанятийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sQLКолвоЗанятийВНеделюТипыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(315, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // бД_ЛР_6DataSet
            // 
            this.бД_ЛР_6DataSet.DataSetName = "БД_ЛР_6DataSet";
            this.бД_ЛР_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLКолвоЗанятийВНеделюТипыBindingSource
            // 
            this.sQLКолвоЗанятийВНеделюТипыBindingSource.DataMember = "SQL Кол-во занятий в неделю (Типы)";
            this.sQLКолвоЗанятийВНеделюТипыBindingSource.DataSource = this.бД_ЛР_6DataSet;
            // 
            // sQL_Кол_во_занятий_в_неделю__Типы_TableAdapter
            // 
            this.sQL_Кол_во_занятий_в_неделю__Типы_TableAdapter.ClearBeforeFill = true;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.Width = 125;
            // 
            // колвоЗанятийDataGridViewTextBoxColumn
            // 
            this.колвоЗанятийDataGridViewTextBoxColumn.DataPropertyName = "Кол-во занятий";
            this.колвоЗанятийDataGridViewTextBoxColumn.HeaderText = "Кол-во занятий";
            this.колвоЗанятийDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвоЗанятийDataGridViewTextBoxColumn.Name = "колвоЗанятийDataGridViewTextBoxColumn";
            this.колвоЗанятийDataGridViewTextBoxColumn.Width = 125;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(57, 370);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(222, 46);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(343, 446);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "TypesForm";
            this.Text = "Количество занятий по типам";
            this.Load += new System.EventHandler(this.TypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ЛР_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLКолвоЗанятийВНеделюТипыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_ЛР_6DataSet бД_ЛР_6DataSet;
        private System.Windows.Forms.BindingSource sQLКолвоЗанятийВНеделюТипыBindingSource;
        private БД_ЛР_6DataSetTableAdapters.SQL_Кол_во_занятий_в_неделю__Типы_TableAdapter sQL_Кол_во_занятий_в_неделю__Типы_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоЗанятийDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exit;
    }
}