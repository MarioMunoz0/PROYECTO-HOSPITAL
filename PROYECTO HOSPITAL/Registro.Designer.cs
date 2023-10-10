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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            txtContra = new TextBox();
            label4 = new Label();
            txtConfContra = new TextBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
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
            pictureBox1.Image = Properties.Resources.MedConnect_SF1;
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
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(363, 102);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(327, 26);
            txtNombreUsuario.TabIndex = 12;
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.White;
            txtContra.BorderStyle = BorderStyle.FixedSingle;
            txtContra.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContra.Location = new Point(363, 165);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(327, 26);
            txtContra.TabIndex = 11;
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
            // txtConfContra
            // 
            txtConfContra.BackColor = Color.White;
            txtConfContra.BorderStyle = BorderStyle.FixedSingle;
            txtConfContra.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfContra.Location = new Point(363, 229);
            txtConfContra.Name = "txtConfContra";
            txtConfContra.Size = new Size(327, 26);
            txtConfContra.TabIndex = 16;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(224, 224, 224);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(381, 277);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(145, 40);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(532, 277);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 40);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 366);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(txtConfContra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContra);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private TextBox txtNombreUsuario;
        private TextBox txtContra;
        private Label label4;
        private TextBox txtConfContra;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}