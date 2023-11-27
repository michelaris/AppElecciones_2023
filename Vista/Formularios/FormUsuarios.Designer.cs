
namespace Vista.Formularios
{
    partial class FormUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvUsuarios = new Guna.UI.WinForms.GunaDataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.chkActivo = new Guna.UI.WinForms.GunaCheckBox();
            this.txtCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.cmbRol = new Guna.UI.WinForms.GunaComboBox();
            this.btnCambiarFoto = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtLoginName = new Guna.UI.WinForms.GunaTextBox();
            this.txtApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombres = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pcbFoto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvUsuarios);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(3, 294);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1081, 276);
            this.gunaGroupBox2.TabIndex = 85;
            this.gunaGroupBox2.Text = "Lista de Usuarios";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 22;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.DocumentoIdentidad,
            this.Nombres,
            this.Apellidos,
            this.Correo,
            this.LoginName,
            this.Password,
            this.Activo,
            this.Rol,
            this.Foto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(4, 35);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1071, 222);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsuarios.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvUsuarios.ThemeStyle.ReadOnly = true;
            this.dgvUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "ID";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // DocumentoIdentidad
            // 
            this.DocumentoIdentidad.DataPropertyName = "DocumentoIdentidad";
            this.DocumentoIdentidad.HeaderText = "DNI";
            this.DocumentoIdentidad.Name = "DocumentoIdentidad";
            this.DocumentoIdentidad.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "LoginName";
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // Rol
            // 
            this.Rol.DataPropertyName = "Rol";
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Visible = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.lblIdUsuario);
            this.gunaGroupBox1.Controls.Add(this.chkActivo);
            this.gunaGroupBox1.Controls.Add(this.txtCorreo);
            this.gunaGroupBox1.Controls.Add(this.cmbRol);
            this.gunaGroupBox1.Controls.Add(this.btnCambiarFoto);
            this.gunaGroupBox1.Controls.Add(this.btnNuevo);
            this.gunaGroupBox1.Controls.Add(this.btnEditar);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnGuardar);
            this.gunaGroupBox1.Controls.Add(this.txtDni);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtPassword);
            this.gunaGroupBox1.Controls.Add(this.txtLoginName);
            this.gunaGroupBox1.Controls.Add(this.txtApellidos);
            this.gunaGroupBox1.Controls.Add(this.txtNombres);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.lblNombre);
            this.gunaGroupBox1.Controls.Add(this.pcbFoto);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.DodgerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 6);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1082, 276);
            this.gunaGroupBox1.TabIndex = 84;
            this.gunaGroupBox1.Text = "Datos de Usuario";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.ForeColor = System.Drawing.Color.Silver;
            this.lblIdUsuario.Location = new System.Drawing.Point(219, 46);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(21, 25);
            this.lblIdUsuario.TabIndex = 142;
            this.lblIdUsuario.Text = "0";
            // 
            // chkActivo
            // 
            this.chkActivo.BaseColor = System.Drawing.Color.White;
            this.chkActivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkActivo.FillColor = System.Drawing.Color.White;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.Gray;
            this.chkActivo.Location = new System.Drawing.Point(724, 49);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Radius = 1;
            this.chkActivo.Size = new System.Drawing.Size(76, 22);
            this.chkActivo.TabIndex = 85;
            this.chkActivo.Text = "Activo";
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BaseColor = System.Drawing.Color.White;
            this.txtCorreo.BorderColor = System.Drawing.Color.Silver;
            this.txtCorreo.BorderSize = 1;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.Location = new System.Drawing.Point(334, 157);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.Radius = 4;
            this.txtCorreo.Size = new System.Drawing.Size(240, 30);
            this.txtCorreo.TabIndex = 141;
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BaseColor = System.Drawing.Color.White;
            this.cmbRol.BorderColor = System.Drawing.Color.Silver;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRol.ForeColor = System.Drawing.Color.Black;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Diseño",
            "Testing",
            "Empleado"});
            this.cmbRol.Location = new System.Drawing.Point(721, 83);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRol.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRol.Radius = 4;
            this.cmbRol.Size = new System.Drawing.Size(240, 26);
            this.cmbRol.TabIndex = 138;
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.AnimationHoverSpeed = 0.07F;
            this.btnCambiarFoto.AnimationSpeed = 0.03F;
            this.btnCambiarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarFoto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCambiarFoto.BorderColor = System.Drawing.Color.Black;
            this.btnCambiarFoto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambiarFoto.FocusedColor = System.Drawing.Color.Empty;
            this.btnCambiarFoto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFoto.ForeColor = System.Drawing.Color.White;
            this.btnCambiarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarFoto.Image")));
            this.btnCambiarFoto.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCambiarFoto.Location = new System.Drawing.Point(44, 230);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCambiarFoto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCambiarFoto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCambiarFoto.OnHoverImage = null;
            this.btnCambiarFoto.OnPressedColor = System.Drawing.Color.Black;
            this.btnCambiarFoto.Radius = 5;
            this.btnCambiarFoto.Size = new System.Drawing.Size(148, 38);
            this.btnCambiarFoto.TabIndex = 137;
            this.btnCambiarFoto.Text = "Fotografia";
            this.btnCambiarFoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AnimationHoverSpeed = 0.07F;
            this.btnNuevo.AnimationSpeed = 0.03F;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.Location = new System.Drawing.Point(789, 230);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Radius = 5;
            this.btnNuevo.Size = new System.Drawing.Size(139, 38);
            this.btnNuevo.TabIndex = 136;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEditar.Location = new System.Drawing.Point(479, 230);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 5;
            this.btnEditar.Size = new System.Drawing.Size(139, 38);
            this.btnEditar.TabIndex = 135;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEliminar.Location = new System.Drawing.Point(634, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 5;
            this.btnEliminar.Size = new System.Drawing.Size(139, 38);
            this.btnEliminar.TabIndex = 134;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGuardar.Location = new System.Drawing.Point(324, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 5;
            this.btnGuardar.Size = new System.Drawing.Size(139, 38);
            this.btnGuardar.TabIndex = 133;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Transparent;
            this.txtDni.BaseColor = System.Drawing.Color.White;
            this.txtDni.BorderColor = System.Drawing.Color.Silver;
            this.txtDni.BorderSize = 1;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.Location = new System.Drawing.Point(335, 43);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.Radius = 4;
            this.txtDni.Size = new System.Drawing.Size(240, 30);
            this.txtDni.TabIndex = 132;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(292, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "DNI:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(721, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.Radius = 4;
            this.txtPassword.Size = new System.Drawing.Size(240, 30);
            this.txtPassword.TabIndex = 126;
            // 
            // txtLoginName
            // 
            this.txtLoginName.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginName.BaseColor = System.Drawing.Color.White;
            this.txtLoginName.BorderColor = System.Drawing.Color.Silver;
            this.txtLoginName.BorderSize = 1;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLoginName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLoginName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoginName.Location = new System.Drawing.Point(721, 119);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.Radius = 4;
            this.txtLoginName.Size = new System.Drawing.Size(240, 30);
            this.txtLoginName.TabIndex = 125;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Transparent;
            this.txtApellidos.BaseColor = System.Drawing.Color.White;
            this.txtApellidos.BorderColor = System.Drawing.Color.Silver;
            this.txtApellidos.BorderSize = 1;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.FocusedBaseColor = System.Drawing.Color.White;
            this.txtApellidos.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtApellidos.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.Location = new System.Drawing.Point(334, 119);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.Radius = 4;
            this.txtApellidos.Size = new System.Drawing.Size(240, 30);
            this.txtApellidos.TabIndex = 121;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.Transparent;
            this.txtNombres.BaseColor = System.Drawing.Color.White;
            this.txtNombres.BorderColor = System.Drawing.Color.Silver;
            this.txtNombres.BorderSize = 1;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombres.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombres.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.Location = new System.Drawing.Point(335, 81);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.Radius = 4;
            this.txtNombres.Size = new System.Drawing.Size(240, 30);
            this.txtNombres.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(631, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 25);
            this.label13.TabIndex = 115;
            this.label13.Text = "PASSWORD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(261, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "CORREO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(666, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 113;
            this.label4.Text = "LOGIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(679, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 112;
            this.label3.Text = "ROL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(659, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "ACTIVO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(246, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 110;
            this.label1.Text = "APELLIDOS:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(251, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 109;
            this.lblNombre.Text = "NOMBRES:";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BaseColor = System.Drawing.Color.White;
            this.pcbFoto.Image = global::Vista.Properties.Resources.Usuario;
            this.pcbFoto.Location = new System.Drawing.Point(23, 34);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(190, 190);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 107;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.UseTransfarantBackground = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "FormUsuarios";
            this.Text = "Formulario de Usuarios";
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox chkActivo;
        private Guna.UI.WinForms.GunaTextBox txtCorreo;
        private Guna.UI.WinForms.GunaComboBox cmbRol;
        private Guna.UI.WinForms.GunaButton btnCambiarFoto;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaTextBox txtDni;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtLoginName;
        private Guna.UI.WinForms.GunaTextBox txtApellidos;
        private Guna.UI.WinForms.GunaTextBox txtNombres;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbFoto;
        private System.Windows.Forms.Label lblIdUsuario;
    }
}