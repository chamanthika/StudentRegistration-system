namespace StudentRegistration
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            txtName = new TextBox();
            txtCourse = new TextBox();
            txtFee = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 47);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCourse);
            groupBox1.Controls.Add(txtFee);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(44, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 265);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            // 
            // button1
            // 
            button1.Location = new Point(19, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(140, 205);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(164, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(134, 23);
            txtName.TabIndex = 5;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(164, 77);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(134, 23);
            txtCourse.TabIndex = 4;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(164, 122);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(134, 23);
            txtFee.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 122);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 2;
            label4.Text = "Fee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 1;
            label3.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 39);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit, Delete });
            dataGridView2.Location = new Point(393, 88);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(641, 173);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Student name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Course";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fee";
            Column4.Name = "Column4";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // button3
            // 
            button3.Location = new Point(919, 293);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 436);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtCourse;
        private TextBox txtFee;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button button3;
    }
}
