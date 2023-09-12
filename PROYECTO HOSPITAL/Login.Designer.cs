namespace PROYECTO_HOSPITAL
{
    partial class Login
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
            txtUsuario = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtContra = new TextBox();
            label1 = new Label();
            btnAcceder = new Button();
            label2 = new Label();
            label3 = new Label();
            btnRegistro = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.Location = new Point(445, 88);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(277, 26);
            txtUsuario.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 366);
            panel1.TabIndex = 5;
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
            // txtContra
            // 
            txtContra.BackColor = Color.White;
            txtContra.BorderStyle = BorderStyle.FixedSingle;
            txtContra.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContra.Location = new Point(445, 138);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(277, 26);
            txtContra.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(472, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(128, 255, 255);
            btnAcceder.FlatStyle = FlatStyle.Popup;
            btnAcceder.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcceder.ForeColor = Color.Black;
            btnAcceder.Location = new Point(522, 194);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(200, 40);
            btnAcceder.TabIndex = 8;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(315, 90);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 9;
            label2.Text = "USUARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(315, 141);
            label3.Name = "label3";
            label3.Size = new Size(124, 19);
            label3.TabIndex = 10;
            label3.Text = "CONTRASEÑA:";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.FromArgb(224, 224, 224);
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.Location = new Point(315, 194);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(201, 40);
            btnRegistro.TabIndex = 11;
            btnRegistro.Text = "REGISTRARSE";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(416, 248);
            label5.Name = "label5";
            label5.Size = new Size(199, 17);
            label5.TabIndex = 13;
            label5.Text = "¿Ha olvidado su contraseña?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(780, 366);
            Controls.Add(label5);
            Controls.Add(btnRegistro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAcceder);
            Controls.Add(label1);
            Controls.Add(txtContra);
            Controls.Add(panel1);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital OBISPADO´S";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private Panel panel1;
        private TextBox txtContra;
        private Label label1;
        private Button btnAcceder;
        private Label label2;
        private Label label3;
        private Button btnRegistro;
        private Label label5;
        private PictureBox pictureBox1;
    }
}