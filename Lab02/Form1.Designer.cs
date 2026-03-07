namespace Lab02
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
            txtDecimalInput = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnConvert = new Button();
            lblBinaryResult = new Label();
            lblOctalResult = new Label();
            lblHexResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 82);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите десятичное число:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 213);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Двоичное:";
            // 
            // txtDecimalInput
            // 
            txtDecimalInput.Location = new Point(352, 82);
            txtDecimalInput.Name = "txtDecimalInput";
            txtDecimalInput.Size = new Size(125, 27);
            txtDecimalInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 267);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "Восьмиричное:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 322);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 4;
            label4.Text = "Шестнадцатиричное:";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(203, 134);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(164, 48);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Преобразовать";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblBinaryResult
            // 
            lblBinaryResult.AutoSize = true;
            lblBinaryResult.BackColor = Color.White;
            lblBinaryResult.Location = new Point(352, 213);
            lblBinaryResult.Name = "lblBinaryResult";
            lblBinaryResult.Size = new Size(61, 20);
            lblBinaryResult.TabIndex = 6;
            lblBinaryResult.Text = "             ";
            // 
            // lblOctalResult
            // 
            lblOctalResult.AutoSize = true;
            lblOctalResult.BackColor = Color.White;
            lblOctalResult.Location = new Point(348, 267);
            lblOctalResult.Name = "lblOctalResult";
            lblOctalResult.Size = new Size(65, 20);
            lblOctalResult.TabIndex = 7;
            lblOctalResult.Text = "              ";
            // 
            // lblHexResult
            // 
            lblHexResult.AutoSize = true;
            lblHexResult.BackColor = Color.White;
            lblHexResult.Location = new Point(348, 322);
            lblHexResult.Name = "lblHexResult";
            lblHexResult.Size = new Size(65, 20);
            lblHexResult.TabIndex = 8;
            lblHexResult.Text = "              ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(613, 450);
            Controls.Add(lblHexResult);
            Controls.Add(lblOctalResult);
            Controls.Add(lblBinaryResult);
            Controls.Add(btnConvert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDecimalInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDecimalInput;
        private Label label3;
        private Label label4;
        private Button btnConvert;
        private Label lblBinaryResult;
        private Label lblOctalResult;
        private Label lblHexResult;
    }
}
