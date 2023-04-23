
namespace LR7_BD
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numAuditAdd = new System.Windows.Forms.MaskedTextBox();
            this.numGroupAdd = new System.Windows.Forms.MaskedTextBox();
            this.idSubjectAdd = new System.Windows.Forms.MaskedTextBox();
            this.numTeacherAdd = new System.Windows.Forms.MaskedTextBox();
            this.dayAdd = new System.Windows.Forms.MaskedTextBox();
            this.timeAdd = new System.Windows.Forms.MaskedTextBox();
            this.typeAdd = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер аудитории:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер группы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Идентификатор предмета:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(585, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Табельный номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(764, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "День проведения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(943, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Время проведения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(1122, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Тип:";
            // 
            // numAuditAdd
            // 
            this.numAuditAdd.Location = new System.Drawing.Point(17, 36);
            this.numAuditAdd.Mask = "0000";
            this.numAuditAdd.Name = "numAuditAdd";
            this.numAuditAdd.Size = new System.Drawing.Size(166, 32);
            this.numAuditAdd.TabIndex = 7;
            // 
            // numGroupAdd
            // 
            this.numGroupAdd.Location = new System.Drawing.Point(195, 36);
            this.numGroupAdd.Mask = "0000";
            this.numGroupAdd.Name = "numGroupAdd";
            this.numGroupAdd.Size = new System.Drawing.Size(134, 32);
            this.numGroupAdd.TabIndex = 8;
            // 
            // idSubjectAdd
            // 
            this.idSubjectAdd.Location = new System.Drawing.Point(341, 36);
            this.idSubjectAdd.Mask = "00";
            this.idSubjectAdd.Name = "idSubjectAdd";
            this.idSubjectAdd.Size = new System.Drawing.Size(236, 32);
            this.idSubjectAdd.TabIndex = 9;
            // 
            // numTeacherAdd
            // 
            this.numTeacherAdd.Location = new System.Drawing.Point(589, 36);
            this.numTeacherAdd.Mask = "00";
            this.numTeacherAdd.Name = "numTeacherAdd";
            this.numTeacherAdd.Size = new System.Drawing.Size(167, 32);
            this.numTeacherAdd.TabIndex = 10;
            // 
            // dayAdd
            // 
            this.dayAdd.Location = new System.Drawing.Point(768, 36);
            this.dayAdd.Mask = "00/00/0000";
            this.dayAdd.Name = "dayAdd";
            this.dayAdd.Size = new System.Drawing.Size(163, 32);
            this.dayAdd.TabIndex = 11;
            this.dayAdd.ValidatingType = typeof(System.DateTime);
            // 
            // timeAdd
            // 
            this.timeAdd.Location = new System.Drawing.Point(947, 36);
            this.timeAdd.Mask = "00:00";
            this.timeAdd.Name = "timeAdd";
            this.timeAdd.Size = new System.Drawing.Size(175, 32);
            this.timeAdd.TabIndex = 12;
            this.timeAdd.ValidatingType = typeof(System.DateTime);
            // 
            // typeAdd
            // 
            this.typeAdd.Location = new System.Drawing.Point(1129, 36);
            this.typeAdd.Name = "typeAdd";
            this.typeAdd.Size = new System.Drawing.Size(160, 32);
            this.typeAdd.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(525, 84);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(279, 42);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить занятие";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1306, 149);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeAdd);
            this.Controls.Add(this.timeAdd);
            this.Controls.Add(this.dayAdd);
            this.Controls.Add(this.numTeacherAdd);
            this.Controls.Add(this.idSubjectAdd);
            this.Controls.Add(this.numGroupAdd);
            this.Controls.Add(this.numAuditAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавление записи";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox numAuditAdd;
        private System.Windows.Forms.MaskedTextBox numGroupAdd;
        private System.Windows.Forms.MaskedTextBox idSubjectAdd;
        private System.Windows.Forms.MaskedTextBox numTeacherAdd;
        private System.Windows.Forms.MaskedTextBox dayAdd;
        private System.Windows.Forms.MaskedTextBox timeAdd;
        private System.Windows.Forms.TextBox typeAdd;
        private System.Windows.Forms.Button addButton;
    }
}