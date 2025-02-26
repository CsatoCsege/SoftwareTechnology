namespace LoanCalculator
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
            tbLoanAmount = new TextBox();
            tbMonthlyIntrest = new TextBox();
            tbMonthlyPayment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            tbMonthCount = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbLoanAmount
            // 
            tbLoanAmount.Location = new Point(55, 60);
            tbLoanAmount.Name = "tbLoanAmount";
            tbLoanAmount.Size = new Size(107, 23);
            tbLoanAmount.TabIndex = 0;
            tbLoanAmount.Text = "10000000";
            tbLoanAmount.TextChanged += tbLoanAmount_TextChanged;
            // 
            // tbMonthlyIntrest
            // 
            tbMonthlyIntrest.Location = new Point(55, 134);
            tbMonthlyIntrest.Name = "tbMonthlyIntrest";
            tbMonthlyIntrest.Size = new Size(107, 23);
            tbMonthlyIntrest.TabIndex = 1;
            tbMonthlyIntrest.Text = "1";
            // 
            // tbMonthlyPayment
            // 
            tbMonthlyPayment.Location = new Point(55, 192);
            tbMonthlyPayment.Name = "tbMonthlyPayment";
            tbMonthlyPayment.Size = new Size(107, 23);
            tbMonthlyPayment.TabIndex = 2;
            tbMonthlyPayment.Text = "200000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 42);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Loan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 116);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Monthly intrest";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 174);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Monthly amount";
            // 
            // button1
            // 
            button1.Location = new Point(62, 243);
            button1.Name = "button1";
            button1.Size = new Size(90, 73);
            button1.TabIndex = 6;
            button1.Text = "go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbMonthCount
            // 
            tbMonthCount.BackColor = Color.FromArgb(255, 255, 192);
            tbMonthCount.Enabled = false;
            tbMonthCount.Location = new Point(52, 351);
            tbMonthCount.Name = "tbMonthCount";
            tbMonthCount.Size = new Size(100, 23);
            tbMonthCount.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(235, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(466, 332);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tbMonthCount);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMonthlyPayment);
            Controls.Add(tbMonthlyIntrest);
            Controls.Add(tbLoanAmount);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLoanAmount;
        private TextBox tbMonthlyIntrest;
        private TextBox tbMonthlyPayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox tbMonthCount;
        private DataGridView dataGridView1;
    }
}