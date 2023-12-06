namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdUpdateTextBox = new System.Windows.Forms.TextBox();
            this.occupationUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.countryUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cityUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lastNameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.firstNameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dbComboBox = new System.Windows.Forms.ComboBox();
            this.editPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.createPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.occupationTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.countryTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(this.createBtn);
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 194);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "occupation";
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.Location = new System.Drawing.Point(82, 124);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(205, 22);
            this.occupationTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "country";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(82, 91);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(205, 22);
            this.countryTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "city";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(82, 63);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(205, 22);
            this.cityTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "last name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(82, 35);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "first name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(82, 7);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(205, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.Transparent;
            this.createBtn.Location = new System.Drawing.Point(3, 152);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(284, 37);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Add";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "create a new user";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(788, 510);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.IdUpdateTextBox);
            this.panel2.Controls.Add(this.occupationUpdateTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.countryUpdateTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cityUpdateTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lastNameUpdateTextBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.firstNameUpdateTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 175);
            this.panel2.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "occupation";
            // 
            // IdUpdateTextBox
            // 
            this.IdUpdateTextBox.Location = new System.Drawing.Point(90, 10);
            this.IdUpdateTextBox.Name = "IdUpdateTextBox";
            this.IdUpdateTextBox.ReadOnly = true;
            this.IdUpdateTextBox.Size = new System.Drawing.Size(205, 22);
            this.IdUpdateTextBox.TabIndex = 11;
            // 
            // occupationUpdateTextBox
            // 
            this.occupationUpdateTextBox.Location = new System.Drawing.Point(90, 146);
            this.occupationUpdateTextBox.Name = "occupationUpdateTextBox";
            this.occupationUpdateTextBox.Size = new System.Drawing.Size(205, 22);
            this.occupationUpdateTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "country";
            // 
            // countryUpdateTextBox
            // 
            this.countryUpdateTextBox.Location = new System.Drawing.Point(90, 119);
            this.countryUpdateTextBox.Name = "countryUpdateTextBox";
            this.countryUpdateTextBox.Size = new System.Drawing.Size(205, 22);
            this.countryUpdateTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "city";
            // 
            // cityUpdateTextBox
            // 
            this.cityUpdateTextBox.Location = new System.Drawing.Point(90, 91);
            this.cityUpdateTextBox.Name = "cityUpdateTextBox";
            this.cityUpdateTextBox.Size = new System.Drawing.Size(205, 22);
            this.cityUpdateTextBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "last name";
            // 
            // lastNameUpdateTextBox
            // 
            this.lastNameUpdateTextBox.Location = new System.Drawing.Point(90, 63);
            this.lastNameUpdateTextBox.Name = "lastNameUpdateTextBox";
            this.lastNameUpdateTextBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameUpdateTextBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "first name";
            // 
            // firstNameUpdateTextBox
            // 
            this.firstNameUpdateTextBox.Location = new System.Drawing.Point(90, 39);
            this.firstNameUpdateTextBox.Name = "firstNameUpdateTextBox";
            this.firstNameUpdateTextBox.Size = new System.Drawing.Size(205, 22);
            this.firstNameUpdateTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DodgerBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(5, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "create a new user";
            // 
            // dbComboBox
            // 
            this.dbComboBox.FormattingEnabled = true;
            this.dbComboBox.Items.AddRange(new object[] {
            "MSSQL",
            "MySQL"});
            this.dbComboBox.Location = new System.Drawing.Point(806, 12);
            this.dbComboBox.Name = "dbComboBox";
            this.dbComboBox.Size = new System.Drawing.Size(295, 24);
            this.dbComboBox.TabIndex = 18;
            this.dbComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.deleteBtn);
            this.editPanel.Controls.Add(this.updateBtn);
            this.editPanel.Controls.Add(this.label12);
            this.editPanel.Controls.Add(this.panel2);
            this.editPanel.Location = new System.Drawing.Point(803, 276);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(304, 241);
            this.editPanel.TabIndex = 19;
            this.editPanel.Visible = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Location = new System.Drawing.Point(8, 202);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(137, 36);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Gold;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Transparent;
            this.updateBtn.Location = new System.Drawing.Point(149, 202);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(144, 36);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createPanel
            // 
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.panel1);
            this.createPanel.Location = new System.Drawing.Point(806, 39);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(309, 231);
            this.createPanel.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1119, 529);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.dbComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox occupationUpdateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countryUpdateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cityUpdateTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lastNameUpdateTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox firstNameUpdateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox dbComboBox;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IdUpdateTextBox;
    }
}

