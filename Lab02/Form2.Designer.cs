namespace Lab02
{
    partial class Form2
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
            txtBinary1 = new TextBox();
            label2 = new Label();
            txtBinary2 = new TextBox();
            btnAddBinary = new Button();
            label3 = new Label();
            label4 = new Label();
            lblBinarySumResult = new Label();
            lblDecimalSumResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 73);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите первое двоичное число:";
            // 
            // txtBinary1
            // 
            txtBinary1.Location = new Point(380, 70);
            txtBinary1.Name = "txtBinary1";
            txtBinary1.Size = new Size(125, 27);
            txtBinary1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 142);
            label2.Name = "label2";
            label2.Size = new Size(238, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите второе двоичное число:";
            // 
            // txtBinary2
            // 
            txtBinary2.Location = new Point(380, 139);
            txtBinary2.Name = "txtBinary2";
            txtBinary2.Size = new Size(125, 27);
            txtBinary2.TabIndex = 3;
            // 
            // btnAddBinary
            // 
            btnAddBinary.Location = new Point(231, 205);
            btnAddBinary.Name = "btnAddBinary";
            btnAddBinary.Size = new Size(145, 53);
            btnAddBinary.TabIndex = 4;
            btnAddBinary.Text = "Сложить";
            btnAddBinary.UseVisualStyleBackColor = true;
            btnAddBinary.Click += btnAddBinary_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 305);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 5;
            label3.Text = "Результат (двоичный):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 356);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 6;
            label4.Text = "Результат (десятичный):";
            // 
            // lblBinarySumResult
            // 
            lblBinarySumResult.AutoSize = true;
            lblBinarySumResult.BackColor = Color.White;
            lblBinarySumResult.Location = new Point(380, 305);
            lblBinarySumResult.Name = "lblBinarySumResult";
            lblBinarySumResult.Size = new Size(76, 20);
            lblBinarySumResult.TabIndex = 7;
            lblBinarySumResult.Text = "результат";
            // 
            // lblDecimalSumResult
            // 
            lblDecimalSumResult.AutoSize = true;
            lblDecimalSumResult.BackColor = Color.White;
            lblDecimalSumResult.Location = new Point(380, 356);
            lblDecimalSumResult.Name = "lblDecimalSumResult";
            lblDecimalSumResult.Size = new Size(76, 20);
            lblDecimalSumResult.TabIndex = 8;
            lblDecimalSumResult.Text = "результат";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(619, 450);
            Controls.Add(lblDecimalSumResult);
            Controls.Add(lblBinarySumResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddBinary);
            Controls.Add(txtBinary2);
            Controls.Add(label2);
            Controls.Add(txtBinary1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBinary1;
        private Label label2;
        private TextBox txtBinary2;
        private Button btnAddBinary;
        private Label label3;
        private Label label4;
        private Label lblBinarySumResult;
        private Label lblDecimalSumResult;
    }
}