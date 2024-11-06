namespace Lab1Activity2_data_grid_view_
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            id_textbox = new TextBox();
            price_textbox = new TextBox();
            name_textbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(360, 197);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 227);
            button1.Name = "button1";
            button1.Size = new Size(360, 23);
            button1.TabIndex = 1;
            button1.Text = "Insert Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 256);
            button2.Name = "button2";
            button2.Size = new Size(360, 23);
            button2.TabIndex = 2;
            button2.Text = "Retrieve Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 316);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // id_textbox
            // 
            id_textbox.Location = new Point(12, 334);
            id_textbox.Name = "id_textbox";
            id_textbox.Size = new Size(116, 23);
            id_textbox.TabIndex = 4;
            // 
            // price_textbox
            // 
            price_textbox.Location = new Point(256, 334);
            price_textbox.Name = "price_textbox";
            price_textbox.Size = new Size(116, 23);
            price_textbox.TabIndex = 5;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(134, 334);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(116, 23);
            name_textbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 316);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 316);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // button3
            // 
            button3.Location = new Point(12, 373);
            button3.Name = "button3";
            button3.Size = new Size(360, 23);
            button3.TabIndex = 9;
            button3.Text = "Insert Data in Run Time";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 425);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name_textbox);
            Controls.Add(price_textbox);
            Controls.Add(id_textbox);
            Controls.Add(label1);
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

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox id_textbox;
        private TextBox price_textbox;
        private TextBox name_textbox;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}