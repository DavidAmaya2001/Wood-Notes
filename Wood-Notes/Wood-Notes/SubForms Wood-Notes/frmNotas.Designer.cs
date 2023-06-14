namespace Wood_Notes
{
    partial class frmNotas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotas));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.dgvContenedor = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelBuscadorNotas = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelToolsNotas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFooterShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenedor)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelBuscadorNotas.SuspendLayout();
            this.panelToolsNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(56)))));
            this.panelPrincipal.Controls.Add(this.btnFooterShow);
            this.panelPrincipal.Controls.Add(this.panelFooter);
            this.panelPrincipal.Controls.Add(this.dgvContenedor);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 117);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.panelPrincipal.Size = new System.Drawing.Size(1060, 603);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.OrangeRed;
            this.panelFooter.Controls.Add(this.pictureBox1);
            this.panelFooter.Controls.Add(this.label3);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 591);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1058, 10);
            this.panelFooter.TabIndex = 3;
            // 
            // dgvContenedor
            // 
            this.dgvContenedor.AllowUserToAddRows = false;
            this.dgvContenedor.AllowUserToDeleteRows = false;
            this.dgvContenedor.AllowUserToResizeColumns = false;
            this.dgvContenedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.dgvContenedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvContenedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(56)))));
            this.dgvContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContenedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContenedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(83)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContenedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvContenedor.ColumnHeadersHeight = 70;
            this.dgvContenedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContenedor.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvContenedor.EnableHeadersVisualStyles = false;
            this.dgvContenedor.GridColor = System.Drawing.Color.LightCyan;
            this.dgvContenedor.Location = new System.Drawing.Point(0, 0);
            this.dgvContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.dgvContenedor.MultiSelect = false;
            this.dgvContenedor.Name = "dgvContenedor";
            this.dgvContenedor.ReadOnly = true;
            this.dgvContenedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContenedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvContenedor.RowHeadersVisible = false;
            this.dgvContenedor.RowHeadersWidth = 40;
            this.dgvContenedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.dgvContenedor.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvContenedor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvContenedor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.dgvContenedor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvContenedor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvContenedor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgvContenedor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContenedor.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContenedor.RowTemplate.Height = 100;
            this.dgvContenedor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContenedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContenedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContenedor.Size = new System.Drawing.Size(1058, 594);
            this.dgvContenedor.TabIndex = 2;
            this.dgvContenedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContenedor_CellClick);
            this.dgvContenedor.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContenedor_CellMouseLeave);
            this.dgvContenedor.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContenedor_CellMouseMove);
            this.dgvContenedor.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContenedor_ColumnHeaderMouseClick);
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackgroundImage = global::Wood_Notes.Properties.Resources.menuNotesForm;
            this.panelSuperior.Controls.Add(this.panelBuscadorNotas);
            this.panelSuperior.Controls.Add(this.panelToolsNotas);
            this.panelSuperior.Controls.Add(this.panelTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1060, 117);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelBuscadorNotas
            // 
            this.panelBuscadorNotas.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscadorNotas.Controls.Add(this.txtSearch);
            this.panelBuscadorNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscadorNotas.Location = new System.Drawing.Point(251, 0);
            this.panelBuscadorNotas.Name = "panelBuscadorNotas";
            this.panelBuscadorNotas.Size = new System.Drawing.Size(609, 117);
            this.panelBuscadorNotas.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(32, 48);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(525, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Buscar por título";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panelToolsNotas
            // 
            this.panelToolsNotas.BackColor = System.Drawing.Color.Transparent;
            this.panelToolsNotas.Controls.Add(this.label2);
            this.panelToolsNotas.Controls.Add(this.label);
            this.panelToolsNotas.Controls.Add(this.btnAddNew);
            this.panelToolsNotas.Controls.Add(this.btnReload);
            this.panelToolsNotas.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelToolsNotas.Location = new System.Drawing.Point(860, 0);
            this.panelToolsNotas.Name = "panelToolsNotas";
            this.panelToolsNotas.Size = new System.Drawing.Size(200, 117);
            this.panelToolsNotas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recargar";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(106, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Agregar";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Image = global::Wood_Notes.Properties.Resources.addNoteIcon;
            this.btnAddNew.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.InitialImage")));
            this.btnAddNew.Location = new System.Drawing.Point(109, 39);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(39, 39);
            this.btnAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = global::Wood_Notes.Properties.Resources.refreshNotesIcon;
            this.btnReload.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnReload.InitialImage")));
            this.btnReload.Location = new System.Drawing.Point(38, 39);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(39, 39);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReload.TabIndex = 1;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(251, 117);
            this.panelTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis Notas";
            // 
            // btnFooterShow
            // 
            this.btnFooterShow.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFooterShow.FlatAppearance.BorderSize = 0;
            this.btnFooterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFooterShow.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFooterShow.ForeColor = System.Drawing.Color.White;
            this.btnFooterShow.Location = new System.Drawing.Point(499, 569);
            this.btnFooterShow.Name = "btnFooterShow";
            this.btnFooterShow.Size = new System.Drawing.Size(75, 23);
            this.btnFooterShow.TabIndex = 4;
            this.btnFooterShow.Text = "^";
            this.btnFooterShow.UseVisualStyleBackColor = false;
            this.btnFooterShow.Click += new System.EventHandler(this.btnFooterShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(688, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cualquier cambio hecho en las notas debe ser actualizado en el boton de \"Recargar" +
    "\" para que pueda ver los resultados en la tabla.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wood_Notes.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(175, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.panelPrincipal.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenedor)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelBuscadorNotas.ResumeLayout(false);
            this.panelBuscadorNotas.PerformLayout();
            this.panelToolsNotas.ResumeLayout(false);
            this.panelToolsNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBuscadorNotas;
        private System.Windows.Forms.Panel panelToolsNotas;
        private System.Windows.Forms.DataGridView dgvContenedor;
        private System.Windows.Forms.PictureBox btnAddNew;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnFooterShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}