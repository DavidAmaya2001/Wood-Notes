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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotasSubMenu2));
            this.panelSupNew = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCenNew = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtNota = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panelInfNew = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNewDate = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panelSupNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelCenNew.SuspendLayout();
            this.panelInfNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSupNew
            // 
            this.panelSupNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelSupNew.Controls.Add(this.txtId);
            this.panelSupNew.Controls.Add(this.btnClose);
            this.panelSupNew.Controls.Add(this.pictureBox3);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(682, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agregar nueva nota";
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
            this.panelInfNew.Controls.Add(this.btnEliminar);
            this.panelInfNew.Controls.Add(this.btnCancel);
            this.panelInfNew.Controls.Add(this.label1);
            this.panelInfNew.Controls.Add(this.dtpNewDate);
            this.panelInfNew.Controls.Add(this.btnEditar);
            this.panelInfNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfNew.Location = new System.Drawing.Point(0, 558);
            this.panelInfNew.Name = "panelInfNew";
            this.panelInfNew.Size = new System.Drawing.Size(805, 64);
            this.panelInfNew.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(601, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 32);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(455, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guardado en la fecha actual:";
            // 
            // dtpNewDate
            // 
            this.dtpNewDate.Enabled = false;
            this.dtpNewDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNewDate.Location = new System.Drawing.Point(214, 20);
            this.dtpNewDate.Name = "dtpNewDate";
            this.dtpNewDate.Size = new System.Drawing.Size(116, 20);
            this.dtpNewDate.TabIndex = 1;
            this.dtpNewDate.Value = new System.DateTime(2023, 1, 10, 17, 44, 46, 0);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(650, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 32);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtId.Location = new System.Drawing.Point(229, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(20, 13);
            this.txtId.TabIndex = 9;
            // 
            // frmNotasSubMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 622);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelCenNew.ResumeLayout(false);
            this.panelCenNew.PerformLayout();
            this.panelInfNew.ResumeLayout(false);
            this.panelInfNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSupNew;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCenNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInfNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox btnEliminar;
        public System.Windows.Forms.RichTextBox rtxtNota;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.DateTimePicker dtpNewDate;
        public System.Windows.Forms.TextBox txtId;
    }
}