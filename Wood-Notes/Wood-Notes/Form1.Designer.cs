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
            this.PanelLateralLogo = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.txtSinProposito = new System.Windows.Forms.TextBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelEsc = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnSettingsSearch = new System.Windows.Forms.PictureBox();
            this.pbProfilePicture = new Wood_Notes.RoundedPictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.panelMenuContent = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.pbConfigIcon = new System.Windows.Forms.PictureBox();
            this.pbCalendarIcon = new System.Windows.Forms.PictureBox();
            this.pbNotesIcon = new System.Windows.Forms.PictureBox();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.pbMenuIcon = new System.Windows.Forms.PictureBox();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserOptions = new System.Windows.Forms.Button();
            this.PanelLateralLogo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelEsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettingsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.panelMenuContent.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfigIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLateralLogo
            // 
            this.PanelLateralLogo.BackColor = System.Drawing.Color.White;
            this.PanelLateralLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLateralLogo.Controls.Add(this.panelMenuContent);
            this.PanelLateralLogo.Controls.Add(this.panelLogo);
            this.PanelLateralLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateralLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLateralLogo.Name = "PanelLateralLogo";
            this.PanelLateralLogo.Size = new System.Drawing.Size(260, 788);
            this.PanelLateralLogo.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 68);
            this.panelLogo.TabIndex = 25;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(632, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblIdUser
            // 
            this.lblIdUser.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUser.ForeColor = System.Drawing.Color.White;
            this.lblIdUser.Location = new System.Drawing.Point(628, 23);
            this.lblIdUser.MaximumSize = new System.Drawing.Size(100, 17);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(100, 17);
            this.lblIdUser.TabIndex = 0;
            this.lblIdUser.Text = "UserName";
            // 
            // txtSinProposito
            // 
            this.txtSinProposito.BackColor = System.Drawing.Color.White;
            this.txtSinProposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinProposito.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinProposito.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSinProposito.Location = new System.Drawing.Point(44, 22);
            this.txtSinProposito.Multiline = true;
            this.txtSinProposito.Name = "txtSinProposito";
            this.txtSinProposito.Size = new System.Drawing.Size(365, 27);
            this.txtSinProposito.TabIndex = 1;
            this.txtSinProposito.Text = "Buscar";
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTools.Controls.Add(this.panelSuperior);
            this.panelTools.Controls.Add(this.panelEsc);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(260, 0);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(1061, 68);
            this.panelTools.TabIndex = 13;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.Controls.Add(this.btnUserOptions);
            this.panelSuperior.Controls.Add(this.btnSettingsSearch);
            this.panelSuperior.Controls.Add(this.pbProfilePicture);
            this.panelSuperior.Controls.Add(this.lblId);
            this.panelSuperior.Controls.Add(this.lblIdUser);
            this.panelSuperior.Controls.Add(this.txtSinProposito);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(963, 68);
            this.panelSuperior.TabIndex = 0;
            // 
            // panelEsc
            // 
            this.panelEsc.BackColor = System.Drawing.Color.Transparent;
            this.panelEsc.Controls.Add(this.btnClose);
            this.panelEsc.Controls.Add(this.btnMinimized);
            this.panelEsc.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEsc.Location = new System.Drawing.Point(963, 0);
            this.panelEsc.Name = "panelEsc";
            this.panelEsc.Size = new System.Drawing.Size(98, 68);
            this.panelEsc.TabIndex = 0;
            // 
            // panelContenido
            // 
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(260, 68);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1061, 720);
            this.panelContenido.TabIndex = 14;
            // 
            // btnSettingsSearch
            // 
            this.btnSettingsSearch.Image = global::Wood_Notes.Properties.Resources.searchIcon;
            this.btnSettingsSearch.Location = new System.Drawing.Point(428, 13);
            this.btnSettingsSearch.Name = "btnSettingsSearch";
            this.btnSettingsSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSettingsSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettingsSearch.TabIndex = 8;
            this.btnSettingsSearch.TabStop = false;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfilePicture.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbProfilePicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfilePicture.BorderSize = 2;
            this.pbProfilePicture.Location = new System.Drawing.Point(562, 4);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(60, 60);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 7;
            this.pbProfilePicture.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Wood_Notes.Properties.Resources.CloseWindows;
            this.btnClose.Location = new System.Drawing.Point(56, 12);
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
            this.btnMinimized.Image = global::Wood_Notes.Properties.Resources.MinimizeWindow;
            this.btnMinimized.Location = new System.Drawing.Point(15, 12);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimized.TabIndex = 8;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // panelMenuContent
            // 
            this.panelMenuContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.panelMenuContent.BackgroundImage = global::Wood_Notes.Properties.Resources.borde;
            this.panelMenuContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenuContent.Controls.Add(this.panelButtons);
            this.panelMenuContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuContent.Location = new System.Drawing.Point(0, 68);
            this.panelMenuContent.Name = "panelMenuContent";
            this.panelMenuContent.Size = new System.Drawing.Size(260, 720);
            this.panelMenuContent.TabIndex = 26;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.pbConfigIcon);
            this.panelButtons.Controls.Add(this.pbCalendarIcon);
            this.panelButtons.Controls.Add(this.pbNotesIcon);
            this.panelButtons.Controls.Add(this.pbUserIcon);
            this.panelButtons.Controls.Add(this.pbMenuIcon);
            this.panelButtons.Controls.Add(this.panelDetalles);
            this.panelButtons.Controls.Add(this.btnConfig);
            this.panelButtons.Controls.Add(this.btnInicio);
            this.panelButtons.Controls.Add(this.btnCalendario);
            this.panelButtons.Controls.Add(this.btnCuenta);
            this.panelButtons.Controls.Add(this.btnNotas);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(260, 720);
            this.panelButtons.TabIndex = 25;
            // 
            // pbConfigIcon
            // 
            this.pbConfigIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.pbConfigIcon.Image = global::Wood_Notes.Properties.Resources.ConfigMenu;
            this.pbConfigIcon.Location = new System.Drawing.Point(47, 512);
            this.pbConfigIcon.Name = "pbConfigIcon";
            this.pbConfigIcon.Size = new System.Drawing.Size(35, 35);
            this.pbConfigIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfigIcon.TabIndex = 13;
            this.pbConfigIcon.TabStop = false;
            // 
            // pbCalendarIcon
            // 
            this.pbCalendarIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.pbCalendarIcon.Image = global::Wood_Notes.Properties.Resources.CalendarMenu;
            this.pbCalendarIcon.Location = new System.Drawing.Point(47, 410);
            this.pbCalendarIcon.Name = "pbCalendarIcon";
            this.pbCalendarIcon.Size = new System.Drawing.Size(35, 35);
            this.pbCalendarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalendarIcon.TabIndex = 1;
            this.pbCalendarIcon.TabStop = false;
            // 
            // pbNotesIcon
            // 
            this.pbNotesIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.pbNotesIcon.Image = global::Wood_Notes.Properties.Resources.NotesMenu;
            this.pbNotesIcon.Location = new System.Drawing.Point(47, 307);
            this.pbNotesIcon.Name = "pbNotesIcon";
            this.pbNotesIcon.Size = new System.Drawing.Size(40, 40);
            this.pbNotesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotesIcon.TabIndex = 12;
            this.pbNotesIcon.TabStop = false;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.pbUserIcon.Image = global::Wood_Notes.Properties.Resources.UserMenu;
            this.pbUserIcon.Location = new System.Drawing.Point(47, 207);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(40, 40);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserIcon.TabIndex = 11;
            this.pbUserIcon.TabStop = false;
            // 
            // pbMenuIcon
            // 
            this.pbMenuIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.pbMenuIcon.Image = global::Wood_Notes.Properties.Resources.Menu;
            this.pbMenuIcon.Location = new System.Drawing.Point(47, 106);
            this.pbMenuIcon.Name = "pbMenuIcon";
            this.pbMenuIcon.Size = new System.Drawing.Size(40, 40);
            this.pbMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenuIcon.TabIndex = 0;
            this.pbMenuIcon.TabStop = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetalles.Location = new System.Drawing.Point(0, 606);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(260, 114);
            this.panelDetalles.TabIndex = 3;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.btnConfig.FlatAppearance.BorderSize = 2;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(74)))), ((int)(((byte)(216)))));
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(42, 503);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(180, 52);
            this.btnConfig.TabIndex = 10;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            this.btnConfig.MouseEnter += new System.EventHandler(this.btnConfig_MouseEnter);
            this.btnConfig.MouseLeave += new System.EventHandler(this.btnConfig_MouseLeave);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.btnInicio.FlatAppearance.BorderSize = 2;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(74)))), ((int)(((byte)(216)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(42, 101);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(180, 51);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnCalendario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.btnCalendario.FlatAppearance.BorderSize = 2;
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(74)))), ((int)(((byte)(216)))));
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.White;
            this.btnCalendario.Location = new System.Drawing.Point(42, 402);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(180, 51);
            this.btnCalendario.TabIndex = 9;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            this.btnCalendario.MouseEnter += new System.EventHandler(this.btnCalendario_MouseEnter);
            this.btnCalendario.MouseLeave += new System.EventHandler(this.btnCalendario_MouseLeave);
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnCuenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.btnCuenta.FlatAppearance.BorderSize = 2;
            this.btnCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(74)))), ((int)(((byte)(216)))));
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCuenta.Location = new System.Drawing.Point(42, 201);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(180, 52);
            this.btnCuenta.TabIndex = 7;
            this.btnCuenta.Text = "Mi Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            this.btnCuenta.MouseEnter += new System.EventHandler(this.btnCuenta_MouseEnter);
            this.btnCuenta.MouseLeave += new System.EventHandler(this.btnCuenta_MouseLeave);
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnNotas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.btnNotas.FlatAppearance.BorderSize = 2;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(74)))), ((int)(((byte)(216)))));
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Location = new System.Drawing.Point(42, 301);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(180, 52);
            this.btnNotas.TabIndex = 8;
            this.btnNotas.Text = "Mis Notas";
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            this.btnNotas.MouseEnter += new System.EventHandler(this.btnNotas_MouseEnter);
            this.btnNotas.MouseLeave += new System.EventHandler(this.btnNotas_MouseLeave);
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
            // btnUserOptions
            // 
            this.btnUserOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(60)))), ((int)(((byte)(182)))));
            this.btnUserOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.btnUserOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(74)))), ((int)(((byte)(216)))));
            this.btnUserOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserOptions.ForeColor = System.Drawing.Color.White;
            this.btnUserOptions.Location = new System.Drawing.Point(738, 26);
            this.btnUserOptions.Name = "btnUserOptions";
            this.btnUserOptions.Size = new System.Drawing.Size(30, 23);
            this.btnUserOptions.TabIndex = 9;
            this.btnUserOptions.Text = "▼";
            this.btnUserOptions.UseVisualStyleBackColor = false;
            // 
            // frmWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1321, 788);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.PanelLateralLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1163, 666);
            this.Name = "frmWorkStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmWorkStation_Load);
            this.PanelLateralLogo.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTools.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelEsc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSettingsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.panelMenuContent.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfigIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateralLogo;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.TextBox txtSinProposito;
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
        private System.Windows.Forms.Panel panelEsc;
        private System.Windows.Forms.Panel panelSuperior;
        public System.Windows.Forms.Label lblIdUser;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuContent;
        private RoundedPictureBox pbProfilePicture;
        private System.Windows.Forms.PictureBox pbMenuIcon;
        private System.Windows.Forms.PictureBox pbUserIcon;
        private System.Windows.Forms.PictureBox pbNotesIcon;
        private System.Windows.Forms.PictureBox pbCalendarIcon;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pbConfigIcon;
        private System.Windows.Forms.PictureBox btnSettingsSearch;
        private System.Windows.Forms.Button btnUserOptions;
    }
}

