namespace PROYECTO_HOSPITAL
{
    partial class Registro
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            btnRegistro = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 366);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cropped_IMAGOTIPO_PRINCIPAL_COLOR_CORPORATIVO;
            pictureBox1.Location = new Point(38, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(451, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 8;
            label1.Text = "REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(413, 143);
            label3.Name = "label3";
            label3.Size = new Size(236, 19);
            label3.TabIndex = 14;
            label3.Text = "INGRESA UNA CONTRASEÑA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(383, 80);
            label2.Name = "label2";
            label2.Size = new Size(291, 19);
            label2.TabIndex = 13;
            label2.Text = "INGRESA UN NOMBRE DE USUARIO:";
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.White;
            txtContra.BorderStyle = BorderStyle.FixedSingle;
            txtContra.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContra.Location = new Point(363, 102);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(327, 26);
            txtContra.TabIndex = 12;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(363, 165);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(327, 26);
            txtUsuario.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(413, 207);
            label4.Name = "label4";
            label4.Size = new Size(229, 19);
            label4.TabIndex = 15;
            label4.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(363, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 26);
            textBox1.TabIndex = 16;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(224, 224, 224);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.Location = new Point(381, 277);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(145, 40);
            btnRegistro.TabIndex = 17;
            btnRegistro.Text = "CONFIRMAR";
            btnRegistro.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(532, 277);
            button1.Name = "button1";
            button1.Size = new Size(145, 40);
            button1.TabIndex = 18;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 366);
            Controls.Add(button1);
            Controls.Add(btnRegistro);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox textBox1;
        private Button btnRegistro;
        private Button button1;
    }
}