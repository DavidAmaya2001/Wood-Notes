namespace Wood_Notes.Calendar_SubForm
{
    partial class frmEventosAdd
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
            this.txtEventCalendar = new System.Windows.Forms.TextBox();
            this.lblFechaEvent = new System.Windows.Forms.Label();
            this.lblNotaEvent = new System.Windows.Forms.Label();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.dtpDateSelected = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtEventCalendar
            // 
            this.txtEventCalendar.Location = new System.Drawing.Point(116, 234);
            this.txtEventCalendar.Name = "txtEventCalendar";
            this.txtEventCalendar.Size = new System.Drawing.Size(412, 20);
            this.txtEventCalendar.TabIndex = 1;
            // 
            // lblFechaEvent
            // 
            this.lblFechaEvent.AutoSize = true;
            this.lblFechaEvent.Location = new System.Drawing.Point(116, 122);
            this.lblFechaEvent.Name = "lblFechaEvent";
            this.lblFechaEvent.Size = new System.Drawing.Size(37, 13);
            this.lblFechaEvent.TabIndex = 2;
            this.lblFechaEvent.Text = "Fecha";
            // 
            // lblNotaEvent
            // 
            this.lblNotaEvent.AutoSize = true;
            this.lblNotaEvent.Location = new System.Drawing.Point(116, 215);
            this.lblNotaEvent.Name = "lblNotaEvent";
            this.lblNotaEvent.Size = new System.Drawing.Size(41, 13);
            this.lblNotaEvent.TabIndex = 3;
            this.lblNotaEvent.Text = "Evento";
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Location = new System.Drawing.Point(453, 348);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEvent.TabIndex = 4;
            this.btnSaveEvent.Text = "Guardar";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // dtpDateSelected
            // 
            this.dtpDateSelected.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSelected.Location = new System.Drawing.Point(116, 154);
            this.dtpDateSelected.Name = "dtpDateSelected";
            this.dtpDateSelected.Size = new System.Drawing.Size(200, 20);
            this.dtpDateSelected.TabIndex = 5;
            // 
            // frmEventosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.dtpDateSelected);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.lblNotaEvent);
            this.Controls.Add(this.lblFechaEvent);
            this.Controls.Add(this.txtEventCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventosAdd";
            this.Text = "frmEventosAdd";
            this.Load += new System.EventHandler(this.frmEventosAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEventCalendar;
        private System.Windows.Forms.Label lblFechaEvent;
        private System.Windows.Forms.Label lblNotaEvent;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.DateTimePicker dtpDateSelected;
    }
}