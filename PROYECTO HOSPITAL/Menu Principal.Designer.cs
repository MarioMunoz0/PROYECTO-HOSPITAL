namespace PROYECTO_HOSPITAL
{
    partial class Menu_Principal
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
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEmpleados = new Button();
            btnSalir = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 391);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnEmpleados);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 391);
            panel2.TabIndex = 7;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.salida;
            pictureBox8.Location = new Point(45, 319);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(46, 51);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.examenes_de_salud1;
            pictureBox6.Location = new Point(13, 254);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(54, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.registro;
            pictureBox7.Location = new Point(13, 200);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(54, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.medico;
            pictureBox5.Location = new Point(13, 146);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 248);
            button1.Name = "button1";
            button1.Size = new Size(250, 54);
            button1.TabIndex = 8;
            button1.Text = "Examenes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.empleado;
            pictureBox4.Location = new Point(12, 91);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.MouseEnter += pictureBox4_MouseEnter;
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 255);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 194);
            button2.Name = "button2";
            button2.Size = new Size(250, 54);
            button2.TabIndex = 8;
            button2.Text = "Admisiones";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(0, 140);
            button3.Name = "button3";
            button3.Size = new Size(250, 54);
            button3.TabIndex = 18;
            button3.Text = "Pacientes";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkTurquoise;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 86);
            panel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.menu;
            pictureBox2.Location = new Point(215, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(83, 49);
            label3.Name = "label3";
            label3.Size = new Size(137, 19);
            label3.TabIndex = 3;
            label3.Text = "Support@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(83, 30);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 2;
            label2.Text = "Jackson, Smith";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(83, 11);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 1;
            label1.Text = "Administrador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_337531;
            pictureBox1.Location = new Point(1, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(128, 255, 255);
            btnEmpleados.Cursor = Cursors.Hand;
            btnEmpleados.FlatStyle = FlatStyle.Popup;
            btnEmpleados.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmpleados.ForeColor = Color.Black;
            btnEmpleados.Location = new Point(0, 86);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(250, 54);
            btnEmpleados.TabIndex = 19;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(128, 255, 255);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 302);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 89);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cropped_IMAGOTIPO_PRINCIPAL_COLOR_CORPORATIVO;
            pictureBox3.Location = new Point(344, 74);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(377, 244);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(780, 391);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Name = "Menu_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_Principal";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnEmpleados;
        private Button btnSalir;
    }
}