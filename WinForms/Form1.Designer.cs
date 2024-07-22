namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Company = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            License = new DataGridViewTextBoxColumn();
            Production = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(254, 323);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(421, 323);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(597, 323);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Company, Model, State, License, Production });
            dataGridView1.Location = new Point(30, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(746, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 6;
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Width = 125;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            Model.ReadOnly = true;
            Model.Width = 125;
            // 
            // State
            // 
            State.HeaderText = "State";
            State.MinimumWidth = 6;
            State.Name = "State";
            State.ReadOnly = true;
            State.Width = 125;
            // 
            // License
            // 
            License.HeaderText = "License";
            License.MinimumWidth = 6;
            License.Name = "License";
            License.ReadOnly = true;
            License.Width = 125;
            // 
            // Production
            // 
            Production.HeaderText = "Production";
            Production.MinimumWidth = 6;
            Production.Name = "Production";
            Production.ReadOnly = true;
            Production.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 5;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 27);
            textBox2.TabIndex = 6;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(389, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 27);
            textBox3.TabIndex = 7;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(389, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 27);
            textBox4.TabIndex = 8;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(389, 325);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(238, 27);
            textBox5.TabIndex = 9;
            textBox5.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 55);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 10;
            label1.Text = "Company";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 123);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 11;
            label2.Text = "Model";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 197);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 12;
            label3.Text = "State";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 264);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 13;
            label4.Text = "License";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 325);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 14;
            label5.Text = "Production year";
            label5.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(346, 391);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 15;
            button5.Text = "Done";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(275, 197);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(238, 27);
            textBox6.TabIndex = 16;
            textBox6.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 123);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 17;
            label6.Text = "Car ID:";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(285, 204);
            label7.Name = "label7";
            label7.Size = new Size(217, 20);
            label7.TabIndex = 18;
            label7.Text = "No car with that id is registered";
            label7.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button5;
        private TextBox textBox6;
        private Label label6;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn License;
        private DataGridViewTextBoxColumn Production;
        private Label label7;
    }
}
