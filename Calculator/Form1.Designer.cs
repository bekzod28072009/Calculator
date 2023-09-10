namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button20 = new Button();
            equalBtn = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button18 = new Button();
            richTextBox1 = new RichTextBox();
            button21 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtAnswer = new TextBox();
            txtDisplay = new TextBox();
            button22 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 159, 21);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 823);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(11, 816);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 5);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(246, 159, 21);
            panel3.Location = new Point(5, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(685, 5);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(695, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 821);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button20, 3, 4);
            tableLayoutPanel1.Controls.Add(equalBtn, 2, 4);
            tableLayoutPanel1.Controls.Add(button17, 0, 4);
            tableLayoutPanel1.Controls.Add(button16, 3, 3);
            tableLayoutPanel1.Controls.Add(button15, 2, 3);
            tableLayoutPanel1.Controls.Add(button14, 1, 3);
            tableLayoutPanel1.Controls.Add(button13, 0, 3);
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button9, 0, 2);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 0, 1);
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button18, 1, 4);
            tableLayoutPanel1.Location = new Point(5, 293);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(691, 524);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button20
            // 
            button20.BackColor = Color.DimGray;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button20.Location = new Point(519, 419);
            button20.Name = "button20";
            button20.Size = new Size(166, 98);
            button20.TabIndex = 24;
            button20.Text = "+";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button15_Click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.DimGray;
            equalBtn.FlatStyle = FlatStyle.Flat;
            equalBtn.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            equalBtn.Location = new Point(347, 419);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(166, 98);
            equalBtn.TabIndex = 23;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += equalBtn_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.DimGray;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(3, 419);
            button17.Name = "button17";
            button17.Size = new Size(166, 98);
            button17.TabIndex = 21;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DimGray;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(519, 315);
            button16.Name = "button16";
            button16.Size = new Size(166, 98);
            button16.TabIndex = 20;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button15_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(246, 159, 21);
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(347, 315);
            button15.Name = "button15";
            button15.Size = new Size(166, 98);
            button15.TabIndex = 19;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(246, 159, 21);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(175, 315);
            button14.Name = "button14";
            button14.Size = new Size(166, 98);
            button14.TabIndex = 18;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button15_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(246, 159, 21);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(3, 315);
            button13.Name = "button13";
            button13.Size = new Size(166, 98);
            button13.TabIndex = 17;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button15_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.DimGray;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(519, 211);
            button12.Name = "button12";
            button12.Size = new Size(166, 98);
            button12.TabIndex = 16;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button15_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(246, 159, 21);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(347, 211);
            button11.Name = "button11";
            button11.Size = new Size(166, 98);
            button11.TabIndex = 15;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button15_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(246, 159, 21);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(175, 211);
            button10.Name = "button10";
            button10.Size = new Size(166, 98);
            button10.TabIndex = 14;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button15_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(246, 159, 21);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(3, 211);
            button9.Name = "button9";
            button9.Size = new Size(166, 98);
            button9.TabIndex = 13;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button15_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(519, 107);
            button8.Name = "button8";
            button8.Size = new Size(166, 98);
            button8.TabIndex = 12;
            button8.Text = "/";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button15_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(246, 159, 21);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(347, 107);
            button7.Name = "button7";
            button7.Size = new Size(166, 98);
            button7.TabIndex = 11;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button15_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(246, 159, 21);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(175, 107);
            button6.Name = "button6";
            button6.Size = new Size(166, 98);
            button6.TabIndex = 10;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button15_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(246, 159, 21);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(3, 107);
            button5.Name = "button5";
            button5.Size = new Size(166, 98);
            button5.TabIndex = 9;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button15_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(519, 3);
            button4.Name = "button4";
            button4.Size = new Size(166, 98);
            button4.TabIndex = 8;
            button4.Text = "◀";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(347, 3);
            button3.Name = "button3";
            button3.Size = new Size(166, 98);
            button3.TabIndex = 7;
            button3.Text = "½";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(175, 3);
            button2.Name = "button2";
            button2.Size = new Size(166, 98);
            button2.TabIndex = 6;
            button2.Text = "%";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(166, 98);
            button1.TabIndex = 5;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(246, 159, 21);
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(175, 419);
            button18.Name = "button18";
            button18.Size = new Size(166, 98);
            button18.TabIndex = 22;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button15_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DimGray;
            richTextBox1.Location = new Point(717, 14);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(324, 734);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button21
            // 
            button21.BackColor = Color.DimGray;
            button21.ForeColor = Color.Black;
            button21.Image = (Image)resources.GetObject("button21.Image");
            button21.Location = new Point(920, 751);
            button21.Name = "button21";
            button21.Size = new Size(121, 66);
            button21.TabIndex = 6;
            button21.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(txtAnswer, 0, 1);
            tableLayoutPanel2.Controls.Add(txtDisplay, 0, 0);
            tableLayoutPanel2.Location = new Point(11, 11);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(678, 276);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.WindowFrame;
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Dock = DockStyle.Fill;
            txtAnswer.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.Location = new Point(0, 138);
            txtAnswer.Margin = new Padding(0);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(678, 138);
            txtAnswer.TabIndex = 0;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.WindowFrame;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Fill;
            txtDisplay.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisplay.Location = new Point(3, 3);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(672, 132);
            txtDisplay.TabIndex = 1;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox2_TextChanged;
            // 
            // button22
            // 
            button22.BackColor = Color.DimGray;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Image = (Image)resources.GetObject("button22.Image");
            button22.Location = new Point(1047, 14);
            button22.Name = "button22";
            button22.Size = new Size(61, 62);
            button22.TabIndex = 8;
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1120, 823);
            Controls.Add(button22);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(button21);
            Controls.Add(richTextBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button20;
        private Button equalBtn;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button21;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtAnswer;
        private TextBox txtDisplay;
        private Button button22;
    }
}