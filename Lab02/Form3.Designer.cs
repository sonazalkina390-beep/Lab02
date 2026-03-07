namespace Lab02
{
    partial class Form3
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
            txtDecimalForVisualization = new TextBox();
            btnVisualizeBinary = new Button();
            pictureBoxBinaryVisualization = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBinaryVisualization).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 80);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите десятичное число:";
            // 
            // txtDecimalForVisualization
            // 
            txtDecimalForVisualization.Location = new Point(302, 77);
            txtDecimalForVisualization.Name = "txtDecimalForVisualization";
            txtDecimalForVisualization.Size = new Size(125, 27);
            txtDecimalForVisualization.TabIndex = 1;
            // 
            // btnVisualizeBinary
            // 
            btnVisualizeBinary.Location = new Point(156, 136);
            btnVisualizeBinary.Name = "btnVisualizeBinary";
            btnVisualizeBinary.Size = new Size(178, 50);
            btnVisualizeBinary.TabIndex = 2;
            btnVisualizeBinary.Text = "Визуализировать";
            btnVisualizeBinary.UseVisualStyleBackColor = true;
            btnVisualizeBinary.Click += btnVisualizeBinary_Click;
            // 
            // pictureBoxBinaryVisualization
            // 
            pictureBoxBinaryVisualization.BackColor = Color.White;
            pictureBoxBinaryVisualization.Location = new Point(32, 218);
            pictureBoxBinaryVisualization.Name = "pictureBoxBinaryVisualization";
            pictureBoxBinaryVisualization.Size = new Size(433, 180);
            pictureBoxBinaryVisualization.TabIndex = 3;
            pictureBoxBinaryVisualization.TabStop = false;
            pictureBoxBinaryVisualization.Paint += pictureBoxBinaryVisualization_Paint;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(502, 450);
            Controls.Add(pictureBoxBinaryVisualization);
            Controls.Add(btnVisualizeBinary);
            Controls.Add(txtDecimalForVisualization);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBinaryVisualization).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDecimalForVisualization;
        private Button btnVisualizeBinary;
        private PictureBox pictureBoxBinaryVisualization;
    }
}