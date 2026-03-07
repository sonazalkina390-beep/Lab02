namespace Lab02
{
    partial class Form4
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
            Name = new Label();
            task1 = new Button();
            task2 = new Button();
            task3 = new Button();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Myanmar Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(282, 30);
            Name.Name = "Name";
            Name.Size = new Size(198, 41);
            Name.TabIndex = 0;
            Name.Text = "Главное меню";
            Name.Click += label1_Click;
            // 
            // task1
            // 
            task1.Location = new Point(201, 97);
            task1.Name = "task1";
            task1.Size = new Size(376, 57);
            task1.TabIndex = 1;
            task1.Text = "Задача 1: Конвертер систем счисления";
            task1.UseVisualStyleBackColor = true;
            // 
            // task2
            // 
            task2.Location = new Point(201, 182);
            task2.Name = "task2";
            task2.Size = new Size(376, 57);
            task2.TabIndex = 2;
            task2.Text = "Задача 2: Сложение в двоичной системе";
            task2.UseVisualStyleBackColor = true;
            // 
            // task3
            // 
            task3.Location = new Point(201, 268);
            task3.Name = "task3";
            task3.Size = new Size(376, 57);
            task3.TabIndex = 3;
            task3.Text = "Задача 3: Визуализация двоичного числа";
            task3.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(task3);
            Controls.Add(task2);
            Controls.Add(task1);
            Controls.Add(Name);
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private Button task1;
        private Button task2;
        private Button task3;
    }
}