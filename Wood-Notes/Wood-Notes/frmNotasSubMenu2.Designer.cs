namespace Wood_Notes
{
    partial class frmNotasSubMenu2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotasSubMenu2));
            this.panelSupNew = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCenNew = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtNota = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panelInfNew = new System.Windows.Forms.Panel();
            this.txtMod = new System.Windows.Forms.Label();
            this.txtCreacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcontador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnPortapapeles = new System.Windows.Forms.Button();
            this.errorTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNota = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelSupNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelCenNew.SuspendLayout();
            this.panelInfNew.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupNew
            // 
            this.panelSupNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelSupNew.Controls.Add(this.btnClose);
            this.panelSupNew.Controls.Add(this.btnMenu);
            this.panelSupNew.Controls.Add(this.label2);
            this.panelSupNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupNew.Location = new System.Drawing.Point(0, 0);
            this.panelSupNew.Name = "panelSupNew";
            this.panelSupNew.Size = new System.Drawing.Size(805, 65);
            this.panelSupNew.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(741, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.InitialImage = null;
            this.btnMenu.Location = new System.Drawing.Point(682, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modificar nota";
            // 
            // panelCenNew
            // 
            this.panelCenNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCenNew.Controls.Add(this.panel1);
            this.panelCenNew.Controls.Add(this.rtxtNota);
            this.panelCenNew.Controls.Add(this.txtTitulo);
            this.panelCenNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenNew.Location = new System.Drawing.Point(0, 65);
            this.panelCenNew.Name = "panelCenNew";
            this.panelCenNew.Size = new System.Drawing.Size(805, 557);
            this.panelCenNew.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 3);
            this.panel1.TabIndex = 2;
            // 
            // rtxtNota
            // 
            this.rtxtNota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtxtNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNota.ForeColor = System.Drawing.Color.Black;
            this.rtxtNota.Location = new System.Drawing.Point(28, 67);
            this.rtxtNota.MaxLength = 2000;
            this.rtxtNota.Name = "rtxtNota";
            this.rtxtNota.Size = new System.Drawing.Size(735, 407);
            this.rtxtNota.TabIndex = 1;
            this.rtxtNota.Text = "Escribe una nota";
            this.rtxtNota.TextChanged += new System.EventHandler(this.rtxtNota_TextChanged);
            this.rtxtNota.Enter += new System.EventHandler(this.rtxtNota_Enter);
            this.rtxtNota.Leave += new System.EventHandler(this.rtxtNota_Leave);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(28, 6);
            this.txtTitulo.MaxLength = 80;
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(735, 37);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // panelInfNew
            // 
            this.panelInfNew.Controls.Add(this.txtMod);
            this.panelInfNew.Controls.Add(this.txtCreacion);
            this.panelInfNew.Controls.Add(this.label3);
            this.panelInfNew.Controls.Add(this.lblcontador);
            this.panelInfNew.Controls.Add(this.label4);
            this.panelInfNew.Controls.Add(this.txtId);
            this.panelInfNew.Controls.Add(this.label1);
            this.panelInfNew.Controls.Add(this.dtpNewDate);
            this.panelInfNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfNew.Location = new System.Drawing.Point(0, 568);
            this.panelInfNew.Name = "panelInfNew";
            this.panelInfNew.Size = new System.Drawing.Size(805, 54);
            this.panelInfNew.TabIndex = 14;
            // 
            // txtMod
            // 
            this.txtMod.AutoSize = true;
            this.txtMod.Location = new System.Drawing.Point(410, 21);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(0, 13);
            this.txtMod.TabIndex = 14;
            this.txtMod.Visible = false;
            // 
            // txtCreacion
            // 
            this.txtCreacion.AutoSize = true;
            this.txtCreacion.Location = new System.Drawing.Point(448, 21);
            this.txtCreacion.Name = "txtCreacion";
            this.txtCreacion.Size = new System.Drawing.Size(0, 13);
            this.txtCreacion.TabIndex = 13;
            this.txtCreacion.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(733, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "/  2000";
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontador.Location = new System.Drawing.Point(691, 21);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(14, 15);
            this.lblcontador.TabIndex = 11;
            this.lblcontador.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Limite de Caracteres:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(499, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guardado en la fecha actual:";
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Enabled = false;
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewDate.Location = new System.Drawing.Point(214, 16);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(116, 20);
            this.dtpNewDate.TabIndex = 1;
            this.dtpNewDate.Value = new System.DateTime(2023, 1, 10, 17, 44, 46, 0);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(0, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(177, 32);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Modificar Nota";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnDetalles);
            this.panelMenu.Controls.Add(this.btnEliminar);
            this.panelMenu.Controls.Add(this.btnFile);
            this.panelMenu.Controls.Add(this.btnPortapapeles);
            this.panelMenu.Controls.Add(this.btnEditar);
            this.panelMenu.Location = new System.Drawing.Point(545, 68);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(177, 192);
            this.panelMenu.TabIndex = 15;
            this.panelMenu.Visible = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDetalles.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(0, 153);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(177, 32);
            this.btnDetalles.TabIndex = 4;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(0, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Nota";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(3, 79);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(171, 32);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Crear Archivo";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnPortapapeles
            // 
            this.btnPortapapeles.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPortapapeles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPortapapeles.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPortapapeles.ForeColor = System.Drawing.Color.White;
            this.btnPortapapeles.Location = new System.Drawing.Point(3, 41);
            this.btnPortapapeles.Name = "btnPortapapeles";
            this.btnPortapapeles.Size = new System.Drawing.Size(171, 32);
            this.btnPortapapeles.TabIndex = 1;
            this.btnPortapapeles.Text = "Copiar al portapapeles";
            this.btnPortapapeles.UseVisualStyleBackColor = false;
            // 
            // errorTitulo
            // 
            this.errorTitulo.ContainerControl = this;
            this.errorTitulo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTitulo.Icon")));
            // 
            // errorNota
            // 
            this.errorNota.ContainerControl = this;
            this.errorNota.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNota.Icon")));
            // 
            // frmNotasSubMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 622);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelInfNew);
            this.Controls.Add(this.panelCenNew);
            this.Controls.Add(this.panelSupNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotasSubMenu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotasSubMenu2";
            this.panelSupNew.ResumeLayout(false);
            this.panelSupNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelCenNew.ResumeLayout(false);
            this.panelCenNew.PerformLayout();
            this.panelInfNew.ResumeLayout(false);
            this.panelInfNew.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupNew;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCenNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInfNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.RichTextBox rtxtNota;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnPortapapeles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalles;
        public System.Windows.Forms.Label txtId;
        private System.Windows.Forms.ErrorProvider errorTitulo;
        private System.Windows.Forms.ErrorProvider errorNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblcontador;
        public System.Windows.Forms.Label txtCreacion;
        public System.Windows.Forms.Label txtMod;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}