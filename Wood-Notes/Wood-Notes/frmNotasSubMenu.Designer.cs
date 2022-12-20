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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfNew = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelCenNew = new System.Windows.Forms.Panel();
            this.rtxtNota = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNota = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSupNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInfNew.SuspendLayout();
            this.panelCenNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupNew
            // 
            this.panelSupNew.BackColor = System.Drawing.Color.White;
            this.panelSupNew.Controls.Add(this.pictureBox1);
            this.panelSupNew.Controls.Add(this.label1);
            this.panelSupNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupNew.Location = new System.Drawing.Point(0, 0);
            this.panelSupNew.Name = "panelSupNew";
            this.panelSupNew.Size = new System.Drawing.Size(760, 60);
            this.panelSupNew.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(694, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar nueva nota";
            // 
            // panelInfNew
            // 
            this.panelInfNew.Controls.Add(this.btnCancel);
            this.panelInfNew.Controls.Add(this.label2);
            this.panelInfNew.Controls.Add(this.dtpNewDate);
            this.panelInfNew.Controls.Add(this.btnAgregar);
            this.panelInfNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfNew.Location = new System.Drawing.Point(0, 556);
            this.panelInfNew.Name = "panelInfNew";
            this.panelInfNew.Size = new System.Drawing.Size(760, 64);
            this.panelInfNew.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guardado en la fecha actual:";
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Enabled = false;
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewDate.Location = new System.Drawing.Point(214, 20);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(116, 20);
            this.dtpNewDate.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(619, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 32);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar nota";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelCenNew
            // 
            this.panelCenNew.BackColor = System.Drawing.Color.White;
            this.panelCenNew.Controls.Add(this.panel1);
            this.panelCenNew.Controls.Add(this.rtxtNota);
            this.panelCenNew.Controls.Add(this.txtTitulo);
            this.panelCenNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenNew.Location = new System.Drawing.Point(0, 60);
            this.panelCenNew.Name = "panelCenNew";
            this.panelCenNew.Size = new System.Drawing.Size(760, 496);
            this.panelCenNew.TabIndex = 2;
            // 
            // rtxtNota
            // 
            this.rtxtNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtNota.ForeColor = System.Drawing.Color.Silver;
            this.rtxtNota.Location = new System.Drawing.Point(0, 49);
            this.rtxtNota.MaxLength = 2000;
            this.rtxtNota.Name = "rtxtNota";
            this.rtxtNota.Size = new System.Drawing.Size(720, 447);
            this.rtxtNota.TabIndex = 1;
            this.rtxtNota.Text = "Escribe una nota";
            this.rtxtNota.Enter += new System.EventHandler(this.rtxtNota_Enter);
            this.rtxtNota.Leave += new System.EventHandler(this.rtxtNota_Leave);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Silver;
            this.txtTitulo.Location = new System.Drawing.Point(0, 0);
            this.txtTitulo.MaxLength = 80;
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(720, 33);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(487, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 3);
            this.panel1.TabIndex = 2;
            // 
            // errorTitulo
            // 
            this.errorTitulo.ContainerControl = this;
            // 
            // errorNota
            // 
            this.errorNota.ContainerControl = this;
            // 
            // frmNotasSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 620);
            this.Controls.Add(this.panelCenNew);
            this.Controls.Add(this.panelInfNew);
            this.Controls.Add(this.panelSupNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotasSubMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotasSubMenu";
            this.panelSupNew.ResumeLayout(false);
            this.panelSupNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInfNew.ResumeLayout(false);
            this.panelInfNew.PerformLayout();
            this.panelCenNew.ResumeLayout(false);
            this.panelCenNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorTitulo;
        private System.Windows.Forms.ErrorProvider errorNota;
    }
}