namespace Wood_Notes
{
    partial class frmNotasSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotasSubMenu));
            this.panelSupNew = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfNew = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelCenNew = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtNota = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.errorTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNota = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPortapapeles = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.panelSupNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelInfNew.SuspendLayout();
            this.panelCenNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSupNew
            // 
            this.panelSupNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelSupNew.Controls.Add(this.btnClose);
            this.panelSupNew.Controls.Add(this.btnMenu);
            this.panelSupNew.Controls.Add(this.label1);
            this.panelSupNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupNew.Location = new System.Drawing.Point(0, 0);
            this.panelSupNew.Name = "panelSupNew";
            this.panelSupNew.Size = new System.Drawing.Size(805, 63);
            this.panelSupNew.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar nueva nota";
            // 
            // panelInfNew
            // 
            this.panelInfNew.Controls.Add(this.label2);
            this.panelInfNew.Controls.Add(this.dtpNewDate);
            this.panelInfNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfNew.Location = new System.Drawing.Point(0, 568);
            this.panelInfNew.Name = "panelInfNew";
            this.panelInfNew.Size = new System.Drawing.Size(805, 52);
            this.panelInfNew.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guardado en la fecha actual:";
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Enabled = false;
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewDate.Location = new System.Drawing.Point(214, 16);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(116, 20);
            this.dtpNewDate.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar nota";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelCenNew
            // 
            this.panelCenNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCenNew.Controls.Add(this.panel1);
            this.panelCenNew.Controls.Add(this.rtxtNota);
            this.panelCenNew.Controls.Add(this.txtTitulo);
            this.panelCenNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenNew.Location = new System.Drawing.Point(0, 63);
            this.panelCenNew.Name = "panelCenNew";
            this.panelCenNew.Size = new System.Drawing.Size(805, 505);
            this.panelCenNew.TabIndex = 2;
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
            this.rtxtNota.ForeColor = System.Drawing.Color.Silver;
            this.rtxtNota.Location = new System.Drawing.Point(49, 67);
            this.rtxtNota.MaxLength = 2000;
            this.rtxtNota.Name = "rtxtNota";
            this.rtxtNota.Size = new System.Drawing.Size(707, 421);
            this.rtxtNota.TabIndex = 1;
            this.rtxtNota.Text = "Escribe una nota";
            this.rtxtNota.Enter += new System.EventHandler(this.rtxtNota_Enter);
            this.rtxtNota.Leave += new System.EventHandler(this.rtxtNota_Leave);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Silver;
            this.txtTitulo.Location = new System.Drawing.Point(49, 6);
            this.txtTitulo.MaxLength = 80;
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(707, 37);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // errorTitulo
            // 
            this.errorTitulo.BlinkRate = 500;
            this.errorTitulo.ContainerControl = this;
            this.errorTitulo.Icon = ((System.Drawing.Icon)(resources.GetObject("errorTitulo.Icon")));
            // 
            // errorNota
            // 
            this.errorNota.BlinkRate = 500;
            this.errorNota.ContainerControl = this;
            this.errorNota.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNota.Icon")));
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnFile);
            this.panelMenu.Controls.Add(this.btnPortapapeles);
            this.panelMenu.Controls.Add(this.btnAgregar);
            this.panelMenu.Location = new System.Drawing.Point(545, 65);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(177, 150);
            this.panelMenu.TabIndex = 9;
            this.panelMenu.Visible = false;
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
            this.btnPortapapeles.Click += new System.EventHandler(this.btnPortapapeles_Click);
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
            // frmNotasSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 620);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCenNew);
            this.Controls.Add(this.panelInfNew);
            this.Controls.Add(this.panelSupNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotasSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotasSubMenu";
            this.panelSupNew.ResumeLayout(false);
            this.panelSupNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelInfNew.ResumeLayout(false);
            this.panelInfNew.PerformLayout();
            this.panelCenNew.ResumeLayout(false);
            this.panelCenNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInfNew;
        private System.Windows.Forms.Panel panelCenNew;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox rtxtNota;
        private System.Windows.Forms.DateTimePicker dtpNewDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorTitulo;
        private System.Windows.Forms.ErrorProvider errorNota;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPortapapeles;
        private System.Windows.Forms.Button btnFile;
    }
}