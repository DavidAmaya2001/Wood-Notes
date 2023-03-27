namespace Wood_Notes
{
    partial class frmWorkStation
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkStation));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pbProfilePicture = new Wood_Notes.RoundedPictureBox();
            this.panelEsc = new System.Windows.Forms.Panel();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.PanelLateral.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.panelTools.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panelEsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.White;
            this.PanelLateral.Controls.Add(this.panelButtons);
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(260, 788);
            this.PanelLateral.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnConfig);
            this.panelButtons.Controls.Add(this.panelDetalles);
            this.panelButtons.Controls.Add(this.btnInicio);
            this.panelButtons.Controls.Add(this.btnCalendario);
            this.panelButtons.Controls.Add(this.btnCuenta);
            this.panelButtons.Controls.Add(this.btnNotas);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 68);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 720);
            this.panelButtons.TabIndex = 25;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfig.FlatAppearance.BorderSize = 3;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Black;
            this.btnConfig.Location = new System.Drawing.Point(52, 388);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(154, 45);
            this.btnConfig.TabIndex = 10;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelDetalles
            // 
            this.panelDetalles.Location = new System.Drawing.Point(0, 606);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(260, 114);
            this.panelDetalles.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnInicio.FlatAppearance.BorderSize = 3;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(52, 45);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(154, 45);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalendario.FlatAppearance.BorderSize = 3;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.Black;
            this.btnCalendario.Location = new System.Drawing.Point(52, 303);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(154, 45);
            this.btnCalendario.TabIndex = 9;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCuenta.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCuenta.FlatAppearance.BorderSize = 3;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnCuenta.Location = new System.Drawing.Point(52, 131);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(154, 45);
            this.btnCuenta.TabIndex = 7;
            this.btnCuenta.Text = "Mi Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotas.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotas.FlatAppearance.BorderSize = 3;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.Black;
            this.btnNotas.Location = new System.Drawing.Point(52, 218);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(154, 45);
            this.btnNotas.TabIndex = 8;
            this.btnNotas.Text = "Mis Notas";
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 68);
            this.panelLogo.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1125, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(38, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "IdUser";
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(1106, 16);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(57, 13);
            this.lblIdUser.TabIndex = 0;
            this.lblIdUser.Text = "UserName";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(344, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Buscar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(955, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(90, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(25, 13);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimized.TabIndex = 8;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelTools.Controls.Add(this.panelSuperior);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(0, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1321, 68);
            this.panelTools.TabIndex = 13;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSuperior.Controls.Add(this.pbProfilePicture);
            this.panelSuperior.Controls.Add(this.lblId);
            this.panelSuperior.Controls.Add(this.panelLogo);
            this.panelSuperior.Controls.Add(this.lblIdUser);
            this.panelSuperior.Controls.Add(this.textBox1);
            this.panelSuperior.Controls.Add(this.pictureBox2);
            this.panelSuperior.Controls.Add(this.panelEsc);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1321, 68);
            this.panelSuperior.TabIndex = 0;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfilePicture.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbProfilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pbProfilePicture.BorderSize = 2;
            this.pbProfilePicture.Location = new System.Drawing.Point(1036, 1);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(64, 64);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 0;
            this.pbProfilePicture.TabStop = false;
            // 
            // panelEsc
            // 
            this.panelEsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelEsc.Controls.Add(this.btnMaximized);
            this.panelEsc.Controls.Add(this.btnClose);
            this.panelEsc.Controls.Add(this.btnMinimized);
            this.panelEsc.Location = new System.Drawing.Point(1181, 0);
            this.panelEsc.Name = "panelEsc";
            this.panelEsc.Size = new System.Drawing.Size(140, 68);
            this.panelEsc.TabIndex = 0;
            // 
            // btnMaximized
            // 
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(61, 16);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(24, 24);
            this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximized.TabIndex = 15;
            this.btnMaximized.TabStop = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContenido.Location = new System.Drawing.Point(260, 68);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1061, 720);
            this.panelContenido.TabIndex = 14;
            // 
            // frmWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1321, 788);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1163, 666);
            this.Name = "frmWorkStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmWorkStation_Load);
            this.PanelLateral.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panelEsc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.Panel panelEsc;
        private System.Windows.Forms.Panel panelSuperior;
        public System.Windows.Forms.Label lblIdUser;
        public System.Windows.Forms.Label lblId;
        public RoundedPictureBox pbProfilePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

