
namespace LR7_BD
{
    partial class CountStudentsForm
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
            this.sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter = new LR7_BD.БД_ЛР_6DataSetTableAdapters.SQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествостудентовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ЛР_6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.факультетDataGridViewTextBoxColumn,
            this.количествостудентовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // бД_ЛР_6DataSet
            // 
            this.бД_ЛР_6DataSet.DataSetName = "БД_ЛР_6DataSet";
            this.бД_ЛР_6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource
            // 
            this.sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource.DataMember = "SQL Итоговый запрос (Кол-во студентов на ф-те)";
            this.sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource.DataSource = this.бД_ЛР_6DataSet;
            // 
            // sQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter
            // 
            this.sQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter.ClearBeforeFill = true;
            // 
            // факультетDataGridViewTextBoxColumn
            // 
            this.факультетDataGridViewTextBoxColumn.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.факультетDataGridViewTextBoxColumn.Name = "факультетDataGridViewTextBoxColumn";
            this.факультетDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествостудентовDataGridViewTextBoxColumn
            // 
            this.количествостудентовDataGridViewTextBoxColumn.DataPropertyName = "Количество_студентов";
            this.количествостудентовDataGridViewTextBoxColumn.HeaderText = "Количество_студентов";
            this.количествостудентовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествостудентовDataGridViewTextBoxColumn.Name = "количествостудентовDataGridViewTextBoxColumn";
            this.количествостудентовDataGridViewTextBoxColumn.Width = 125;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(134, 361);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 42);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Выход";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CountStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(435, 441);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CountStudentsForm";
            this.Text = "Количество студентов на факультетах";
            this.Load += new System.EventHandler(this.CountStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_ЛР_6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_ЛР_6DataSet бД_ЛР_6DataSet;
        private System.Windows.Forms.BindingSource sQLИтоговыйЗапросКолвоСтудентовНаФтеBindingSource;
        private БД_ЛР_6DataSetTableAdapters.SQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter sQL_Итоговый_запрос__Кол_во_студентов_на_ф_те_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествостудентовDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addButton;
    }
}