
namespace Vista.Formularios
{
    partial class FormElecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElecciones));
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvElecciones = new Guna.UI.WinForms.GunaDataGridView();
            this.IdEleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVotacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuarioCreador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dtpFechaVotacion = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFechaRegistro = new Guna.UI.WinForms.GunaDateTimePicker();
            this.chkActivo = new Guna.UI.WinForms.GunaCheckBox();
            this.txtCargo = new Guna.UI.WinForms.GunaTextBox();
            this.btnCambiarFoto = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.txtIdEleccion = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioCreador = new Guna.UI.WinForms.GunaTextBox();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pcbFoto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElecciones)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvElecciones);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(3, 295);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1081, 276);
            this.gunaGroupBox2.TabIndex = 87;
            this.gunaGroupBox2.Text = "Listado de Elecciones";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // dgvElecciones
            // 
            this.dgvElecciones.AllowUserToAddRows = false;
            this.dgvElecciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvElecciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvElecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElecciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvElecciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvElecciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElecciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvElecciones.ColumnHeadersHeight = 22;
            this.dgvElecciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEleccion,
            this.DocumentoIdentidad,
            this.Cargo,
            this.Activo,
            this.FechaRegistro,
            this.FechaVotacion,
            this.NombreUsuarioCreador,
            this.Foto,
            this.IdUsuario,
            this.op});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElecciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvElecciones.EnableHeadersVisualStyles = false;
            this.dgvElecciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElecciones.Location = new System.Drawing.Point(4, 35);
            this.dgvElecciones.Name = "dgvElecciones";
            this.dgvElecciones.ReadOnly = true;
            this.dgvElecciones.RowHeadersVisible = false;
            this.dgvElecciones.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvElecciones.RowTemplate.Height = 50;
            this.dgvElecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElecciones.Size = new System.Drawing.Size(1071, 222);
            this.dgvElecciones.TabIndex = 0;
            this.dgvElecciones.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvElecciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElecciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvElecciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvElecciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvElecciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvElecciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvElecciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElecciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvElecciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvElecciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvElecciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvElecciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvElecciones.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvElecciones.ThemeStyle.ReadOnly = true;
            this.dgvElecciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElecciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElecciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvElecciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvElecciones.ThemeStyle.RowsStyle.Height = 50;
            this.dgvElecciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElecciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvElecciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElecciones_CellClick);
            this.dgvElecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElecciones_CellDoubleClick);
            // 
            // IdEleccion
            // 
            this.IdEleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdEleccion.DataPropertyName = "IdEleccion";
            this.IdEleccion.HeaderText = "ID";
            this.IdEleccion.Name = "IdEleccion";
            this.IdEleccion.ReadOnly = true;
            this.IdEleccion.Width = 40;
            // 
            // DocumentoIdentidad
            // 
            this.DocumentoIdentidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DocumentoIdentidad.DataPropertyName = "Descripcion";
            this.DocumentoIdentidad.HeaderText = "Descripcion";
            this.DocumentoIdentidad.Name = "DocumentoIdentidad";
            this.DocumentoIdentidad.ReadOnly = true;
            this.DocumentoIdentidad.Width = 300;
            // 
            // Cargo
            // 
            this.Cargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 150;
            // 
            // Activo
            // 
            this.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 75;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "Fec. de Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // FechaVotacion
            // 
            this.FechaVotacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaVotacion.DataPropertyName = "FechaVotacion";
            this.FechaVotacion.HeaderText = "Fec. de Votacion";
            this.FechaVotacion.Name = "FechaVotacion";
            this.FechaVotacion.ReadOnly = true;
            this.FechaVotacion.Width = 120;
            // 
            // NombreUsuarioCreador
            // 
            this.NombreUsuarioCreador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NombreUsuarioCreador.DataPropertyName = "NombreUsuario";
            this.NombreUsuarioCreador.HeaderText = "Creado Por";
            this.NombreUsuarioCreador.Name = "NombreUsuarioCreador";
            this.NombreUsuarioCreador.ReadOnly = true;
            this.NombreUsuarioCreador.Width = 150;
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
            this.Foto.Width = 60;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // op
            // 
            this.op.DataPropertyName = "op";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gold;
            this.op.DefaultCellStyle = dataGridViewCellStyle3;
            this.op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.op.HeaderText = "Candidat@s";
            this.op.Name = "op";
            this.op.ReadOnly = true;
            this.op.Text = "";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.dtpFechaVotacion);
            this.gunaGroupBox1.Controls.Add(this.dtpFechaRegistro);
            this.gunaGroupBox1.Controls.Add(this.chkActivo);
            this.gunaGroupBox1.Controls.Add(this.txtCargo);
            this.gunaGroupBox1.Controls.Add(this.btnCambiarFoto);
            this.gunaGroupBox1.Controls.Add(this.btnNuevo);
            this.gunaGroupBox1.Controls.Add(this.btnEditar);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnGuardar);
            this.gunaGroupBox1.Controls.Add(this.txtIdEleccion);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtUsuarioCreador);
            this.gunaGroupBox1.Controls.Add(this.txtDescripcion);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.lblNombre);
            this.gunaGroupBox1.Controls.Add(this.pcbFoto);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 7);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1082, 276);
            this.gunaGroupBox1.TabIndex = 86;
            this.gunaGroupBox1.Text = "Datos de Eleccion";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // dtpFechaVotacion
            // 
            this.dtpFechaVotacion.BaseColor = System.Drawing.Color.White;
            this.dtpFechaVotacion.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaVotacion.CustomFormat = null;
            this.dtpFechaVotacion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaVotacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaVotacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaVotacion.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaVotacion.Location = new System.Drawing.Point(772, 116);
            this.dtpFechaVotacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVotacion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVotacion.Name = "dtpFechaVotacion";
            this.dtpFechaVotacion.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaVotacion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaVotacion.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaVotacion.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaVotacion.Size = new System.Drawing.Size(237, 30);
            this.dtpFechaVotacion.TabIndex = 143;
            this.dtpFechaVotacion.Text = "jueves, 23 de noviembre de 2023";
            this.dtpFechaVotacion.Value = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.BaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaRegistro.CustomFormat = null;
            this.dtpFechaRegistro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRegistro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaRegistro.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(772, 78);
            this.dtpFechaRegistro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRegistro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Size = new System.Drawing.Size(237, 30);
            this.dtpFechaRegistro.TabIndex = 142;
            this.dtpFechaRegistro.Text = "jueves, 23 de noviembre de 2023";
            this.dtpFechaRegistro.Value = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            // 
            // chkActivo
            // 
            this.chkActivo.BaseColor = System.Drawing.Color.White;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkActivo.FillColor = System.Drawing.Color.White;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.Gray;
            this.chkActivo.Location = new System.Drawing.Point(772, 49);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Radius = 1;
            this.chkActivo.Size = new System.Drawing.Size(138, 22);
            this.chkActivo.TabIndex = 85;
            this.chkActivo.Text = "Activo/Inactivo";
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.Transparent;
            this.txtCargo.BaseColor = System.Drawing.Color.White;
            this.txtCargo.BorderColor = System.Drawing.Color.Silver;
            this.txtCargo.BorderSize = 1;
            this.txtCargo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCargo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCargo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCargo.Location = new System.Drawing.Point(353, 157);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.Radius = 4;
            this.txtCargo.Size = new System.Drawing.Size(240, 30);
            this.txtCargo.TabIndex = 141;
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
            // txtIdEleccion
            // 
            this.txtIdEleccion.BackColor = System.Drawing.Color.Transparent;
            this.txtIdEleccion.BaseColor = System.Drawing.Color.White;
            this.txtIdEleccion.BorderColor = System.Drawing.Color.Silver;
            this.txtIdEleccion.BorderSize = 1;
            this.txtIdEleccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdEleccion.Enabled = false;
            this.txtIdEleccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdEleccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdEleccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdEleccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdEleccion.Location = new System.Drawing.Point(354, 43);
            this.txtIdEleccion.Name = "txtIdEleccion";
            this.txtIdEleccion.PasswordChar = '\0';
            this.txtIdEleccion.Radius = 4;
            this.txtIdEleccion.Size = new System.Drawing.Size(240, 30);
            this.txtIdEleccion.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(326, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "ID:";
            // 
            // txtUsuarioCreador
            // 
            this.txtUsuarioCreador.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuarioCreador.BaseColor = System.Drawing.Color.White;
            this.txtUsuarioCreador.BorderColor = System.Drawing.Color.Silver;
            this.txtUsuarioCreador.BorderSize = 1;
            this.txtUsuarioCreador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuarioCreador.Enabled = false;
            this.txtUsuarioCreador.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsuarioCreador.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsuarioCreador.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuarioCreador.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCreador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuarioCreador.Location = new System.Drawing.Point(769, 157);
            this.txtUsuarioCreador.Name = "txtUsuarioCreador";
            this.txtUsuarioCreador.PasswordChar = '\0';
            this.txtUsuarioCreador.Radius = 4;
            this.txtUsuarioCreador.Size = new System.Drawing.Size(240, 35);
            this.txtUsuarioCreador.TabIndex = 126;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BaseColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Silver;
            this.txtDescripcion.BorderSize = 1;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(354, 78);
            this.txtDescripcion.MultiLine = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Radius = 4;
            this.txtDescripcion.Size = new System.Drawing.Size(240, 68);
            this.txtDescripcion.TabIndex = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(631, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 25);
            this.label13.TabIndex = 115;
            this.label13.Text = "USUARIO CREADOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(295, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "CARGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(637, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 113;
            this.label4.Text = "FEC. DE VOTACION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(636, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 112;
            this.label3.Text = "FEC. DE REGISTRO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(709, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "ACTIVO:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(251, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 25);
            this.lblNombre.TabIndex = 109;
            this.lblNombre.Text = "DESCRIPCION:";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BaseColor = System.Drawing.Color.White;
            this.pcbFoto.Image = global::Vista.Properties.Resources.Imagen_elecciones;
            this.pcbFoto.Location = new System.Drawing.Point(23, 34);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(190, 190);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 107;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.UseTransfarantBackground = false;
            // 
            // FormElecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "FormElecciones";
            this.Text = "Formulario de Elecciones";
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElecciones)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvElecciones;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox chkActivo;
        private Guna.UI.WinForms.GunaTextBox txtCargo;
        private Guna.UI.WinForms.GunaButton btnCambiarFoto;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaTextBox txtIdEleccion;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtUsuarioCreador;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbFoto;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaRegistro;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaVotacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVotacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuarioCreador;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn op;
    }
}