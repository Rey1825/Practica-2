namespace Practica_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Stencil", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 69);
            label1.Name = "label1";
            label1.Size = new Size(373, 61);
            label1.TabIndex = 0;
            label1.Text = "¡Hola mundo!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 191);
            label2.Name = "label2";
            label2.Size = new Size(300, 37);
            label2.TabIndex = 1;
            label2.Text = "¿Cuál es tu nombre?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 331);
            label3.Name = "label3";
            label3.Size = new Size(353, 37);
            label3.TabIndex = 2;
            label3.Text = "¡¡Hola, alguien especial!";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(47, 257);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 43);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(466, 257);
            button1.Name = "button1";
            button1.Size = new Size(209, 43);
            button1.TabIndex = 4;
            button1.Text = "Diga \"Hola\"";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}