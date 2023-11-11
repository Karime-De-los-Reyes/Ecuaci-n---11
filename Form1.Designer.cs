namespace Ecuación___11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SG Alternative High-Alt", 20.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(232, 23);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 0;
            label1.Text = "f(x)= x/1+x¨2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SG Alternative High-Alt", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(87, 98);
            label2.Name = "label2";
            label2.Size = new Size(25, 28);
            label2.TabIndex = 1;
            label2.Text = "x";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SG Alternative High-Alt", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(232, 98);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 2;
            label3.Text = "f(x)";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(64, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(81, 124);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(216, 129);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(83, 124);
            listBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(418, 98);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 5;
            button1.Text = "For";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(418, 133);
            button2.Name = "button2";
            button2.Size = new Size(108, 38);
            button2.TabIndex = 6;
            button2.Text = "While";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(418, 177);
            button3.Name = "button3";
            button3.Size = new Size(108, 35);
            button3.TabIndex = 7;
            button3.Text = "Do...While";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("SG Alternative High-Alt", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(418, 218);
            button4.Name = "button4";
            button4.Size = new Size(108, 35);
            button4.TabIndex = 8;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}