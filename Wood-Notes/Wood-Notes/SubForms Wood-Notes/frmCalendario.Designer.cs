namespace Wood_Notes
{
    partial class frmCalendario
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
            this.flpCalendar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblMonthAndYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpCalendar
            // 
            this.flpCalendar.Location = new System.Drawing.Point(49, 97);
            this.flpCalendar.Name = "flpCalendar";
            this.flpCalendar.Size = new System.Drawing.Size(960, 571);
            this.flpCalendar.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(11, 320);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 147);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = " ←";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1015, 320);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 147);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = " →";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunday.Location = new System.Drawing.Point(88, 77);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(63, 17);
            this.lblSunday.TabIndex = 3;
            this.lblSunday.Text = "Domingo";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(235, 77);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(43, 17);
            this.lblMonday.TabIndex = 4;
            this.lblMonday.Text = "Lunes";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWednesday.Location = new System.Drawing.Point(492, 77);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(65, 17);
            this.lblWednesday.TabIndex = 6;
            this.lblWednesday.Text = "Miercoles";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(364, 77);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(49, 17);
            this.lblTuesday.TabIndex = 5;
            this.lblTuesday.Text = "Martes";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThursday.Location = new System.Drawing.Point(643, 77);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(47, 17);
            this.lblThursday.TabIndex = 7;
            this.lblThursday.Text = "Jueves";
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturday.Location = new System.Drawing.Point(912, 77);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(53, 17);
            this.lblSaturday.TabIndex = 8;
            this.lblSaturday.Text = "Sabado";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriday.Location = new System.Drawing.Point(778, 77);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(52, 17);
            this.lblFriday.TabIndex = 9;
            this.lblFriday.Text = "Viernes";
            // 
            // lblMonthAndYear
            // 
            this.lblMonthAndYear.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthAndYear.Location = new System.Drawing.Point(56, 25);
            this.lblMonthAndYear.Name = "lblMonthAndYear";
            this.lblMonthAndYear.Size = new System.Drawing.Size(473, 35);
            this.lblMonthAndYear.TabIndex = 10;
            this.lblMonthAndYear.Text = "MONTH YEAR";
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 720);
            this.Controls.Add(this.lblMonthAndYear);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.lblSaturday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.lblSunday);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.flpCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendario";
            this.Text = "frmCalendario";
            this.Load += new System.EventHandler(this.frmCalendario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpCalendar;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblMonthAndYear;
    }
}