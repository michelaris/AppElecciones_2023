
namespace Vista.Formularios
{
    partial class FormVotaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipseFormularioVotaciones = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControlFormulario = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelSuperior = new Guna.UI.WinForms.GunaGradient2Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.btnCerrar = new Guna.UI.WinForms.GunaButton();
            this.btnMaximizar = new Guna.UI.WinForms.GunaButton();
            this.btnMinimizar = new Guna.UI.WinForms.GunaButton();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.grbListaCandidatos = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCandidatos = new Guna.UI.WinForms.GunaDataGridView();
            this.IdCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.op = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCandidato = new Guna.UI.WinForms.GunaGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMensajeCandidato = new Guna.UI.WinForms.GunaTextBox();
            this.txtIdCandidato = new Guna.UI.WinForms.GunaTextBox();
            this.txtApellidosCandidatos = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombresCandidato = new Guna.UI.WinForms.GunaTextBox();
            this.pcbFotoCandidato = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.grbDatosDeVotante = new Guna.UI.WinForms.GunaGroupBox();
            this.lblFechaDeEleccion = new System.Windows.Forms.Label();
            this.btnEmitirVotacion = new FontAwesome.Sharp.IconButton();
            this.txtEleccionCargo = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chbEmitioVotacion = new Guna.UI.WinForms.GunaCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivo = new Guna.UI.WinForms.GunaCheckBox();
            this.txtIdVotante = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombres = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaElipseBotonVotar = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.gunaGradient2Panel1.SuspendLayout();
            this.grbListaCandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.grbCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoCandidato)).BeginInit();
            this.grbDatosDeVotante.SuspendLayout();
            this.gunaGradient2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipseFormularioVotaciones
            // 
            this.gunaElipseFormularioVotaciones.Radius = 6;
            this.gunaElipseFormularioVotaciones.TargetControl = this;
            // 
            // gunaDragControlFormulario
            // 
            this.gunaDragControlFormulario.TargetControl = this.panelSuperior;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.Controls.Add(this.iconCurrentChildForm);
            this.panelSuperior.Controls.Add(this.lblTitleChildForm);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.btnMaximizar);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.GradientColor1 = System.Drawing.Color.Red;
            this.panelSuperior.GradientColor2 = System.Drawing.Color.Black;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1089, 50);
            this.panelSuperior.TabIndex = 2;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 30;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(12, 11);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(30, 30);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCurrentChildForm.TabIndex = 36;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(50, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(167, 26);
            this.lblTitleChildForm.TabIndex = 37;
            this.lblTitleChildForm.Text = "Votaciones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.ImageSize = new System.Drawing.Size(18, 20);
            this.btnCerrar.Location = new System.Drawing.Point(1054, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Radius = 3;
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.TabIndex = 35;
            this.btnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.AnimationHoverSpeed = 0.07F;
            this.btnMaximizar.AnimationSpeed = 0.03F;
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.BaseColor = System.Drawing.Color.Black;
            this.btnMaximizar.BorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMaximizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMaximizar.Location = new System.Drawing.Point(1024, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaximizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMaximizar.OnHoverImage = null;
            this.btnMaximizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaximizar.Radius = 3;
            this.btnMaximizar.Size = new System.Drawing.Size(27, 27);
            this.btnMaximizar.TabIndex = 34;
            this.btnMaximizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AnimationHoverSpeed = 0.07F;
            this.btnMinimizar.AnimationSpeed = 0.03F;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BaseColor = System.Drawing.Color.Black;
            this.btnMinimizar.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = null;
            this.btnMinimizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinimizar.Location = new System.Drawing.Point(994, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimizar.OnHoverImage = null;
            this.btnMinimizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizar.Radius = 3;
            this.btnMinimizar.Size = new System.Drawing.Size(27, 27);
            this.btnMinimizar.TabIndex = 33;
            this.btnMinimizar.Text = "___";
            this.btnMinimizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.grbListaCandidatos);
            this.gunaGradient2Panel1.Controls.Add(this.grbCandidato);
            this.gunaGradient2Panel1.Controls.Add(this.grbDatosDeVotante);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(199)))), ((int)(((byte)(250)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(68)))), ((int)(((byte)(116)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1089, 645);
            this.gunaGradient2Panel1.TabIndex = 1;
            // 
            // grbListaCandidatos
            // 
            this.grbListaCandidatos.BackColor = System.Drawing.Color.Transparent;
            this.grbListaCandidatos.BaseColor = System.Drawing.Color.White;
            this.grbListaCandidatos.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.grbListaCandidatos.BorderSize = 1;
            this.grbListaCandidatos.Controls.Add(this.dgvCandidatos);
            this.grbListaCandidatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaCandidatos.ForeColor = System.Drawing.Color.White;
            this.grbListaCandidatos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.grbListaCandidatos.Location = new System.Drawing.Point(438, 324);
            this.grbListaCandidatos.Name = "grbListaCandidatos";
            this.grbListaCandidatos.Radius = 10;
            this.grbListaCandidatos.Size = new System.Drawing.Size(638, 271);
            this.grbListaCandidatos.TabIndex = 2;
            this.grbListaCandidatos.Text = "Lista De Candidatos";
            this.grbListaCandidatos.TextLocation = new System.Drawing.Point(235, 5);
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCandidatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandidatos.ColumnHeadersHeight = 22;
            this.dgvCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCandidato,
            this.Nombres,
            this.Apellidos,
            this.Mensaje,
            this.Foto,
            this.op,
            this.IdUsuario,
            this.IdEleccion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCandidatos.EnableHeadersVisualStyles = false;
            this.dgvCandidatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.Location = new System.Drawing.Point(3, 30);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersVisible = false;
            this.dgvCandidatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvCandidatos.RowTemplate.Height = 45;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(632, 228);
            this.dgvCandidatos.TabIndex = 5;
            this.dgvCandidatos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvCandidatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCandidatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCandidatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCandidatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCandidatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCandidatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCandidatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCandidatos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvCandidatos.ThemeStyle.ReadOnly = true;
            this.dgvCandidatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCandidatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.RowsStyle.Height = 45;
            this.dgvCandidatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCandidatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatos_CellClick);
            // 
            // IdCandidato
            // 
            this.IdCandidato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdCandidato.DataPropertyName = "IdCandidato";
            this.IdCandidato.HeaderText = "ID";
            this.IdCandidato.Name = "IdCandidato";
            this.IdCandidato.ReadOnly = true;
            this.IdCandidato.Width = 50;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 120;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 120;
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mensaje.DataPropertyName = "Mensaje";
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.ReadOnly = true;
            this.Mensaje.Width = 160;
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Foto.Width = 50;
            // 
            // op
            // 
            this.op.DataPropertyName = "op";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.op.DefaultCellStyle = dataGridViewCellStyle3;
            this.op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.op.HeaderText = "Opcion";
            this.op.Name = "op";
            this.op.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // IdEleccion
            // 
            this.IdEleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdEleccion.DataPropertyName = "IdEleccion";
            this.IdEleccion.HeaderText = "IdEleccion";
            this.IdEleccion.Name = "IdEleccion";
            this.IdEleccion.ReadOnly = true;
            this.IdEleccion.Visible = false;
            // 
            // grbCandidato
            // 
            this.grbCandidato.BackColor = System.Drawing.Color.Transparent;
            this.grbCandidato.BaseColor = System.Drawing.Color.Transparent;
            this.grbCandidato.BorderColor = System.Drawing.Color.DarkViolet;
            this.grbCandidato.BorderSize = 1;
            this.grbCandidato.Controls.Add(this.label4);
            this.grbCandidato.Controls.Add(this.label9);
            this.grbCandidato.Controls.Add(this.label10);
            this.grbCandidato.Controls.Add(this.label11);
            this.grbCandidato.Controls.Add(this.txtMensajeCandidato);
            this.grbCandidato.Controls.Add(this.txtIdCandidato);
            this.grbCandidato.Controls.Add(this.txtApellidosCandidatos);
            this.grbCandidato.Controls.Add(this.txtNombresCandidato);
            this.grbCandidato.Controls.Add(this.pcbFotoCandidato);
            this.grbCandidato.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCandidato.ForeColor = System.Drawing.Color.Gold;
            this.grbCandidato.LineColor = System.Drawing.Color.MidnightBlue;
            this.grbCandidato.Location = new System.Drawing.Point(438, 61);
            this.grbCandidato.Name = "grbCandidato";
            this.grbCandidato.Radius = 10;
            this.grbCandidato.Size = new System.Drawing.Size(639, 250);
            this.grbCandidato.TabIndex = 1;
            this.grbCandidato.Text = "Candidato";
            this.grbCandidato.TextLocation = new System.Drawing.Point(250, 3);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(336, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 28);
            this.label4.TabIndex = 150;
            this.label4.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(282, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 28);
            this.label9.TabIndex = 149;
            this.label9.Text = "MENSAJE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(274, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 28);
            this.label10.TabIndex = 148;
            this.label10.Text = "APELLIDOS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(279, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 28);
            this.label11.TabIndex = 147;
            this.label11.Text = "NOMBRES:";
            // 
            // txtMensajeCandidato
            // 
            this.txtMensajeCandidato.BackColor = System.Drawing.Color.Transparent;
            this.txtMensajeCandidato.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtMensajeCandidato.BorderColor = System.Drawing.Color.Silver;
            this.txtMensajeCandidato.BorderSize = 0;
            this.txtMensajeCandidato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensajeCandidato.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMensajeCandidato.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMensajeCandidato.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMensajeCandidato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeCandidato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtMensajeCandidato.Location = new System.Drawing.Point(374, 159);
            this.txtMensajeCandidato.MultiLine = true;
            this.txtMensajeCandidato.Name = "txtMensajeCandidato";
            this.txtMensajeCandidato.PasswordChar = '\0';
            this.txtMensajeCandidato.Radius = 4;
            this.txtMensajeCandidato.ReadOnly = true;
            this.txtMensajeCandidato.Size = new System.Drawing.Size(240, 67);
            this.txtMensajeCandidato.TabIndex = 146;
            // 
            // txtIdCandidato
            // 
            this.txtIdCandidato.BackColor = System.Drawing.Color.Transparent;
            this.txtIdCandidato.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtIdCandidato.BorderColor = System.Drawing.Color.Silver;
            this.txtIdCandidato.BorderSize = 0;
            this.txtIdCandidato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCandidato.Enabled = false;
            this.txtIdCandidato.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdCandidato.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdCandidato.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdCandidato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCandidato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtIdCandidato.Location = new System.Drawing.Point(374, 42);
            this.txtIdCandidato.Name = "txtIdCandidato";
            this.txtIdCandidato.PasswordChar = '\0';
            this.txtIdCandidato.Radius = 4;
            this.txtIdCandidato.ReadOnly = true;
            this.txtIdCandidato.Size = new System.Drawing.Size(240, 30);
            this.txtIdCandidato.TabIndex = 145;
            // 
            // txtApellidosCandidatos
            // 
            this.txtApellidosCandidatos.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidosCandidatos.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtApellidosCandidatos.BorderColor = System.Drawing.Color.Silver;
            this.txtApellidosCandidatos.BorderSize = 0;
            this.txtApellidosCandidatos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidosCandidatos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellidosCandidatos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellidosCandidatos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellidosCandidatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosCandidatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtApellidosCandidatos.Location = new System.Drawing.Point(374, 120);
            this.txtApellidosCandidatos.Name = "txtApellidosCandidatos";
            this.txtApellidosCandidatos.PasswordChar = '\0';
            this.txtApellidosCandidatos.Radius = 4;
            this.txtApellidosCandidatos.ReadOnly = true;
            this.txtApellidosCandidatos.Size = new System.Drawing.Size(240, 30);
            this.txtApellidosCandidatos.TabIndex = 144;
            // 
            // txtNombresCandidato
            // 
            this.txtNombresCandidato.BackColor = System.Drawing.Color.Transparent;
            this.txtNombresCandidato.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtNombresCandidato.BorderColor = System.Drawing.Color.Silver;
            this.txtNombresCandidato.BorderSize = 0;
            this.txtNombresCandidato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombresCandidato.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombresCandidato.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombresCandidato.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombresCandidato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCandidato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtNombresCandidato.Location = new System.Drawing.Point(374, 81);
            this.txtNombresCandidato.Name = "txtNombresCandidato";
            this.txtNombresCandidato.PasswordChar = '\0';
            this.txtNombresCandidato.Radius = 4;
            this.txtNombresCandidato.ReadOnly = true;
            this.txtNombresCandidato.Size = new System.Drawing.Size(240, 30);
            this.txtNombresCandidato.TabIndex = 143;
            // 
            // pcbFotoCandidato
            // 
            this.pcbFotoCandidato.BaseColor = System.Drawing.Color.White;
            this.pcbFotoCandidato.Image = global::Vista.Properties.Resources.candidato;
            this.pcbFotoCandidato.Location = new System.Drawing.Point(16, 45);
            this.pcbFotoCandidato.Name = "pcbFotoCandidato";
            this.pcbFotoCandidato.Size = new System.Drawing.Size(190, 190);
            this.pcbFotoCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoCandidato.TabIndex = 142;
            this.pcbFotoCandidato.TabStop = false;
            this.pcbFotoCandidato.UseTransfarantBackground = false;
            // 
            // grbDatosDeVotante
            // 
            this.grbDatosDeVotante.BackColor = System.Drawing.Color.Transparent;
            this.grbDatosDeVotante.BaseColor = System.Drawing.Color.Transparent;
            this.grbDatosDeVotante.BorderColor = System.Drawing.Color.DarkViolet;
            this.grbDatosDeVotante.BorderSize = 1;
            this.grbDatosDeVotante.Controls.Add(this.lblFechaDeEleccion);
            this.grbDatosDeVotante.Controls.Add(this.btnEmitirVotacion);
            this.grbDatosDeVotante.Controls.Add(this.txtEleccionCargo);
            this.grbDatosDeVotante.Controls.Add(this.label13);
            this.grbDatosDeVotante.Controls.Add(this.chbEmitioVotacion);
            this.grbDatosDeVotante.Controls.Add(this.label6);
            this.grbDatosDeVotante.Controls.Add(this.dtpFechaRegistro);
            this.grbDatosDeVotante.Controls.Add(this.label8);
            this.grbDatosDeVotante.Controls.Add(this.txtDni);
            this.grbDatosDeVotante.Controls.Add(this.label1);
            this.grbDatosDeVotante.Controls.Add(this.chkActivo);
            this.grbDatosDeVotante.Controls.Add(this.txtIdVotante);
            this.grbDatosDeVotante.Controls.Add(this.label5);
            this.grbDatosDeVotante.Controls.Add(this.txtApellidos);
            this.grbDatosDeVotante.Controls.Add(this.txtNombres);
            this.grbDatosDeVotante.Controls.Add(this.label2);
            this.grbDatosDeVotante.Controls.Add(this.label3);
            this.grbDatosDeVotante.Controls.Add(this.lblNombre);
            this.grbDatosDeVotante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosDeVotante.ForeColor = System.Drawing.Color.Gold;
            this.grbDatosDeVotante.LineColor = System.Drawing.Color.MidnightBlue;
            this.grbDatosDeVotante.Location = new System.Drawing.Point(9, 61);
            this.grbDatosDeVotante.Name = "grbDatosDeVotante";
            this.grbDatosDeVotante.Radius = 20;
            this.grbDatosDeVotante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbDatosDeVotante.Size = new System.Drawing.Size(402, 534);
            this.grbDatosDeVotante.TabIndex = 0;
            this.grbDatosDeVotante.Text = "Datos de Votante";
            this.grbDatosDeVotante.TextLocation = new System.Drawing.Point(123, 7);
            // 
            // lblFechaDeEleccion
            // 
            this.lblFechaDeEleccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeEleccion.ForeColor = System.Drawing.Color.Gold;
            this.lblFechaDeEleccion.Location = new System.Drawing.Point(4, 396);
            this.lblFechaDeEleccion.Name = "lblFechaDeEleccion";
            this.lblFechaDeEleccion.Size = new System.Drawing.Size(395, 25);
            this.lblFechaDeEleccion.TabIndex = 163;
            this.lblFechaDeEleccion.Text = "Fecha de Eleccion";
            this.lblFechaDeEleccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmitirVotacion
            // 
            this.btnEmitirVotacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnEmitirVotacion.FlatAppearance.BorderSize = 0;
            this.btnEmitirVotacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.btnEmitirVotacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEmitirVotacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirVotacion.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirVotacion.ForeColor = System.Drawing.Color.White;
            this.btnEmitirVotacion.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.btnEmitirVotacion.IconColor = System.Drawing.Color.White;
            this.btnEmitirVotacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmitirVotacion.IconSize = 40;
            this.btnEmitirVotacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitirVotacion.Location = new System.Drawing.Point(59, 452);
            this.btnEmitirVotacion.Name = "btnEmitirVotacion";
            this.btnEmitirVotacion.Size = new System.Drawing.Size(281, 61);
            this.btnEmitirVotacion.TabIndex = 162;
            this.btnEmitirVotacion.Text = "Realizar Votacion";
            this.btnEmitirVotacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmitirVotacion.UseVisualStyleBackColor = false;
            this.btnEmitirVotacion.Click += new System.EventHandler(this.btnEmitirVotacion_Click);
            // 
            // txtEleccionCargo
            // 
            this.txtEleccionCargo.BackColor = System.Drawing.Color.Transparent;
            this.txtEleccionCargo.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtEleccionCargo.BorderColor = System.Drawing.Color.Silver;
            this.txtEleccionCargo.BorderSize = 0;
            this.txtEleccionCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEleccionCargo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEleccionCargo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEleccionCargo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEleccionCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEleccionCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtEleccionCargo.Location = new System.Drawing.Point(138, 352);
            this.txtEleccionCargo.Name = "txtEleccionCargo";
            this.txtEleccionCargo.PasswordChar = '\0';
            this.txtEleccionCargo.Radius = 4;
            this.txtEleccionCargo.ReadOnly = true;
            this.txtEleccionCargo.Size = new System.Drawing.Size(240, 30);
            this.txtEleccionCargo.TabIndex = 161;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(54, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 28);
            this.label13.TabIndex = 160;
            this.label13.Text = "ELECCION:";
            // 
            // chbEmitioVotacion
            // 
            this.chbEmitioVotacion.BaseColor = System.Drawing.Color.White;
            this.chbEmitioVotacion.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbEmitioVotacion.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbEmitioVotacion.FillColor = System.Drawing.Color.White;
            this.chbEmitioVotacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEmitioVotacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.chbEmitioVotacion.Location = new System.Drawing.Point(138, 313);
            this.chbEmitioVotacion.Name = "chbEmitioVotacion";
            this.chbEmitioVotacion.Size = new System.Drawing.Size(57, 23);
            this.chbEmitioVotacion.TabIndex = 156;
            this.chbEmitioVotacion.Text = "NO";
            this.chbEmitioVotacion.CheckedChanged += new System.EventHandler(this.chbEmitioVotacion_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-1, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 157;
            this.label6.Text = "EMITIO VOTACION:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaRegistro.BaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaRegistro.BorderSize = 0;
            this.dtpFechaRegistro.CustomFormat = null;
            this.dtpFechaRegistro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRegistro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(138, 267);
            this.dtpFechaRegistro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRegistro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Radius = 4;
            this.dtpFechaRegistro.Size = new System.Drawing.Size(240, 30);
            this.dtpFechaRegistro.TabIndex = 155;
            this.dtpFechaRegistro.Text = "jueves, 23 de noviembre de 2023";
            this.dtpFechaRegistro.Value = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 154;
            this.label8.Text = "FEC. REGISTRO:";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Transparent;
            this.txtDni.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtDni.BorderColor = System.Drawing.Color.Silver;
            this.txtDni.BorderSize = 0;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtDni.Location = new System.Drawing.Point(138, 91);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.Radius = 4;
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(240, 30);
            this.txtDni.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 152;
            this.label1.Text = "DNI:";
            // 
            // chkActivo
            // 
            this.chkActivo.BaseColor = System.Drawing.Color.White;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkActivo.FillColor = System.Drawing.Color.White;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.chkActivo.Location = new System.Drawing.Point(138, 229);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Radius = 1;
            this.chkActivo.Size = new System.Drawing.Size(91, 22);
            this.chkActivo.TabIndex = 144;
            this.chkActivo.Text = "Inactivo";
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // txtIdVotante
            // 
            this.txtIdVotante.BackColor = System.Drawing.Color.Transparent;
            this.txtIdVotante.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtIdVotante.BorderColor = System.Drawing.Color.Silver;
            this.txtIdVotante.BorderSize = 0;
            this.txtIdVotante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdVotante.Enabled = false;
            this.txtIdVotante.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdVotante.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdVotante.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdVotante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVotante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtIdVotante.Location = new System.Drawing.Point(138, 45);
            this.txtIdVotante.Name = "txtIdVotante";
            this.txtIdVotante.PasswordChar = '\0';
            this.txtIdVotante.Radius = 4;
            this.txtIdVotante.Size = new System.Drawing.Size(240, 30);
            this.txtIdVotante.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(107, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 28);
            this.label5.TabIndex = 150;
            this.label5.Text = "ID:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidos.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtApellidos.BorderColor = System.Drawing.Color.Silver;
            this.txtApellidos.BorderSize = 0;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtApellidos.Location = new System.Drawing.Point(138, 183);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.Radius = 4;
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(240, 30);
            this.txtApellidos.TabIndex = 149;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.Transparent;
            this.txtNombres.BaseColor = System.Drawing.Color.MidnightBlue;
            this.txtNombres.BorderColor = System.Drawing.Color.Silver;
            this.txtNombres.BorderSize = 0;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombres.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombres.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.txtNombres.Location = new System.Drawing.Point(138, 137);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.Radius = 4;
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(240, 30);
            this.txtNombres.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 147;
            this.label2.Text = "ACTIVO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 146;
            this.label3.Text = "APELLIDOS:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(50, 138);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 28);
            this.lblNombre.TabIndex = 145;
            this.lblNombre.Text = "NOMBRES:";
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.label7);
            this.gunaGradient2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.Gray;
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(0, 601);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(1089, 44);
            this.gunaGradient2Panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(370, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sistema Gestion de Elecciones";
            // 
            // gunaElipseBotonVotar
            // 
            this.gunaElipseBotonVotar.Radius = 10;
            this.gunaElipseBotonVotar.TargetControl = this.btnEmitirVotacion;
            // 
            // FormVotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 645);
            this.Controls.Add(this.gunaGradient2Panel3);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVotaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVotaciones";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.grbListaCandidatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.grbCandidato.ResumeLayout(false);
            this.grbCandidato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoCandidato)).EndInit();
            this.grbDatosDeVotante.ResumeLayout(false);
            this.grbDatosDeVotante.PerformLayout();
            this.gunaGradient2Panel3.ResumeLayout(false);
            this.gunaGradient2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipseFormularioVotaciones;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private Guna.UI.WinForms.GunaGradient2Panel panelSuperior;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControlFormulario;
        private Guna.UI.WinForms.GunaButton btnCerrar;
        private Guna.UI.WinForms.GunaButton btnMaximizar;
        private Guna.UI.WinForms.GunaButton btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaGroupBox grbDatosDeVotante;
        private Guna.UI.WinForms.GunaTextBox txtDni;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCheckBox chkActivo;
        private Guna.UI.WinForms.GunaTextBox txtIdVotante;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtApellidos;
        private Guna.UI.WinForms.GunaTextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaCheckBox chbEmitioVotacion;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtEleccionCargo;
        private Guna.UI.WinForms.GunaGroupBox grbCandidato;
        private Guna.UI.WinForms.GunaTextBox txtMensajeCandidato;
        private Guna.UI.WinForms.GunaTextBox txtIdCandidato;
        private Guna.UI.WinForms.GunaTextBox txtApellidosCandidatos;
        private Guna.UI.WinForms.GunaTextBox txtNombresCandidato;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbFotoCandidato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaGroupBox grbListaCandidatos;
        private Guna.UI.WinForms.GunaDataGridView dgvCandidatos;
        private FontAwesome.Sharp.IconButton btnEmitirVotacion;
        private Guna.UI.WinForms.GunaElipse gunaElipseBotonVotar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewButtonColumn op;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEleccion;
        private System.Windows.Forms.Label lblFechaDeEleccion;
    }
}