namespace Wood_Notes
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvitado = new System.Windows.Forms.Button();
            this.btnInvitado2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvitado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(196, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(315, 215);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(285, 29);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(315, 266);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(285, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(353, 321);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(95, 29);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿No tienes una cuenta?, ¡Unete!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnInvitado
            // 
            this.btnInvitado.BackColor = System.Drawing.Color.Navy;
            this.btnInvitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvitado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvitado.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvitado.ForeColor = System.Drawing.Color.White;
            this.btnInvitado.Location = new System.Drawing.Point(472, 391);
            this.btnInvitado.Name = "btnInvitado";
            this.btnInvitado.Size = new System.Drawing.Size(101, 39);
            this.btnInvitado.TabIndex = 7;
            this.btnInvitado.Text = "     Invitado";
            this.btnInvitado.UseVisualStyleBackColor = false;
            this.btnInvitado.Click += new System.EventHandler(this.btnInvitado_Click);
            // 
            // btnInvitado2
            // 
            this.btnInvitado2.BackColor = System.Drawing.Color.Navy;
            this.btnInvitado2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvitado2.Image = ((System.Drawing.Image)(resources.GetObject("btnInvitado2.Image")));
            this.btnInvitado2.Location = new System.Drawing.Point(477, 397);
            this.btnInvitado2.Name = "btnInvitado2";
            this.btnInvitado2.Size = new System.Drawing.Size(30, 30);
            this.btnInvitado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInvitado2.TabIndex = 8;
            this.btnInvitado2.TabStop = false;
            this.btnInvitado2.Click += new System.EventHandler(this.btnInvitado2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(745, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 9;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInvitado2);
            this.Controls.Add(this.btnInvitado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvitado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInvitado;
        private System.Windows.Forms.PictureBox btnInvitado2;
        private System.Windows.Forms.PictureBox btnSalir;
    }
}