namespace Wood_Notes
{
    partial class frmInicio
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
            this.panelPrincipalInicio = new System.Windows.Forms.Panel();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panelIzquierdoSup = new System.Windows.Forms.Panel();
            this.panelIzquierdoInf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPrincipalInicio.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.panelIzquierdoSup.SuspendLayout();
            this.panelIzquierdoInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipalInicio
            // 
            this.panelPrincipalInicio.Controls.Add(this.panelIzquierdo);
            this.panelPrincipalInicio.Controls.Add(this.panelDerecho);
            this.panelPrincipalInicio.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipalInicio.Name = "panelPrincipalInicio";
            this.panelPrincipalInicio.Size = new System.Drawing.Size(1060, 720);
            this.panelPrincipalInicio.TabIndex = 0;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelDerecho.Controls.Add(this.label3);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(652, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(408, 720);
            this.panelDerecho.TabIndex = 0;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Controls.Add(this.panelIzquierdoInf);
            this.panelIzquierdo.Controls.Add(this.panelIzquierdoSup);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(652, 720);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // panelIzquierdoSup
            // 
            this.panelIzquierdoSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelIzquierdoSup.Controls.Add(this.label1);
            this.panelIzquierdoSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIzquierdoSup.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdoSup.Name = "panelIzquierdoSup";
            this.panelIzquierdoSup.Size = new System.Drawing.Size(652, 365);
            this.panelIzquierdoSup.TabIndex = 0;
            // 
            // panelIzquierdoInf
            // 
            this.panelIzquierdoInf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelIzquierdoInf.Controls.Add(this.label2);
            this.panelIzquierdoInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzquierdoInf.Location = new System.Drawing.Point(0, 365);
            this.panelIzquierdoInf.Name = "panelIzquierdoInf";
            this.panelIzquierdoInf.Size = new System.Drawing.Size(652, 355);
            this.panelIzquierdoInf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Perfil";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.panelPrincipalInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.panelPrincipalInicio.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdoSup.ResumeLayout(false);
            this.panelIzquierdoSup.PerformLayout();
            this.panelIzquierdoInf.ResumeLayout(false);
            this.panelIzquierdoInf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipalInicio;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelIzquierdoInf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelIzquierdoSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label label3;
    }
}