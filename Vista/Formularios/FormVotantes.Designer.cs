
namespace Vista.Formularios
{
    partial class FormVotantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVotantes));
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvVotantes = new Guna.UI.WinForms.GunaDataGridView();
            this.IdVotante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmitioVotacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EleccionCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbEleccion = new Guna.UI.WinForms.GunaComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCreadoPorUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbEmitioVotacion = new Guna.UI.WinForms.GunaCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActivo = new Guna.UI.WinForms.GunaCheckBox();
            this.btnCargarLista = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.txtIdVotante = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombres = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVotantes)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvVotantes);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(4, 300);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1081, 276);
            this.gunaGroupBox2.TabIndex = 87;
            this.gunaGroupBox2.Text = "Lista de Votantes";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // dgvVotantes
            // 
            this.dgvVotantes.AllowUserToAddRows = false;
            this.dgvVotantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVotantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVotantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVotantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvVotantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVotantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVotantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVotantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVotantes.ColumnHeadersHeight = 22;
            this.dgvVotantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVotante,
            this.DocumentoIdentidad,
            this.Nombres,
            this.Apellidos,
            this.Activo,
            this.FechaRegistro,
            this.EmitioVotacion,
            this.EleccionCargo,
            this.NombreUsuario,
            this.IdEleccion,
            this.IdUsuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVotantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVotantes.EnableHeadersVisualStyles = false;
            this.dgvVotantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVotantes.Location = new System.Drawing.Point(4, 35);
            this.dgvVotantes.Name = "dgvVotantes";
            this.dgvVotantes.ReadOnly = true;
            this.dgvVotantes.RowHeadersVisible = false;
            this.dgvVotantes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvVotantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVotantes.Size = new System.Drawing.Size(1071, 222);
            this.dgvVotantes.TabIndex = 0;
            this.dgvVotantes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvVotantes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVotantes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVotantes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVotantes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVotantes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVotantes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVotantes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVotantes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVotantes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVotantes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVotantes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVotantes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVotantes.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvVotantes.ThemeStyle.ReadOnly = true;
            this.dgvVotantes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVotantes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVotantes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVotantes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVotantes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVotantes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVotantes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVotantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVotantes_CellDoubleClick);
            // 
            // IdVotante
            // 
            this.IdVotante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdVotante.DataPropertyName = "IdVotante";
            this.IdVotante.HeaderText = "ID";
            this.IdVotante.Name = "IdVotante";
            this.IdVotante.ReadOnly = true;
            this.IdVotante.Width = 50;
            // 
            // DocumentoIdentidad
            // 
            this.DocumentoIdentidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DocumentoIdentidad.DataPropertyName = "DocumentoIdentidad";
            this.DocumentoIdentidad.HeaderText = "DNI";
            this.DocumentoIdentidad.Name = "DocumentoIdentidad";
            this.DocumentoIdentidad.ReadOnly = true;
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
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
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
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "Fec. de Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // EmitioVotacion
            // 
            this.EmitioVotacion.DataPropertyName = "EmitioVotacion";
            this.EmitioVotacion.HeaderText = "Emitio Votacion";
            this.EmitioVotacion.Name = "EmitioVotacion";
            this.EmitioVotacion.ReadOnly = true;
            // 
            // EleccionCargo
            // 
            this.EleccionCargo.DataPropertyName = "CargoDeEleccion";
            this.EleccionCargo.HeaderText = "Eleccion";
            this.EleccionCargo.Name = "EleccionCargo";
            this.EleccionCargo.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "NombreUsuario";
            this.NombreUsuario.HeaderText = "Creado Por";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // IdEleccion
            // 
            this.IdEleccion.DataPropertyName = "IdEleccion";
            this.IdEleccion.HeaderText = "IdEleccion";
            this.IdEleccion.Name = "IdEleccion";
            this.IdEleccion.ReadOnly = true;
            this.IdEleccion.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cmbEleccion);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.txtCreadoPorUsuario);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.chbEmitioVotacion);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.dtpFechaRegistro);
            this.gunaGroupBox1.Controls.Add(this.label8);
            this.gunaGroupBox1.Controls.Add(this.txtDni);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.chkActivo);
            this.gunaGroupBox1.Controls.Add(this.btnCargarLista);
            this.gunaGroupBox1.Controls.Add(this.btnNuevo);
            this.gunaGroupBox1.Controls.Add(this.btnEditar);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnGuardar);
            this.gunaGroupBox1.Controls.Add(this.txtIdVotante);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtApellidos);
            this.gunaGroupBox1.Controls.Add(this.txtNombres);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.lblNombre);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(4, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1082, 276);
            this.gunaGroupBox1.TabIndex = 86;
            this.gunaGroupBox1.Text = "Datos de Votantes";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.BackColor = System.Drawing.Color.Transparent;
            this.cmbEleccion.BaseColor = System.Drawing.Color.White;
            this.cmbEleccion.BorderColor = System.Drawing.Color.Silver;
            this.cmbEleccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEleccion.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEleccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEleccion.ForeColor = System.Drawing.Color.Black;
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Location = new System.Drawing.Point(537, 114);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEleccion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEleccion.Radius = 4;
            this.cmbEleccion.Size = new System.Drawing.Size(240, 28);
            this.cmbEleccion.TabIndex = 151;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(454, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 25);
            this.label13.TabIndex = 150;
            this.label13.Text = "ELECCION:";
            // 
            // txtCreadoPorUsuario
            // 
            this.txtCreadoPorUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtCreadoPorUsuario.BaseColor = System.Drawing.Color.White;
            this.txtCreadoPorUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtCreadoPorUsuario.BorderSize = 1;
            this.txtCreadoPorUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreadoPorUsuario.Enabled = false;
            this.txtCreadoPorUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCreadoPorUsuario.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCreadoPorUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCreadoPorUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreadoPorUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCreadoPorUsuario.Location = new System.Drawing.Point(537, 148);
            this.txtCreadoPorUsuario.Name = "txtCreadoPorUsuario";
            this.txtCreadoPorUsuario.PasswordChar = '\0';
            this.txtCreadoPorUsuario.Radius = 4;
            this.txtCreadoPorUsuario.Size = new System.Drawing.Size(240, 30);
            this.txtCreadoPorUsuario.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(433, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 148;
            this.label4.Text = "CREADO POR:";
            // 
            // chbEmitioVotacion
            // 
            this.chbEmitioVotacion.BaseColor = System.Drawing.Color.White;
            this.chbEmitioVotacion.CheckedOffColor = System.Drawing.Color.Gray;
            this.chbEmitioVotacion.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chbEmitioVotacion.FillColor = System.Drawing.Color.White;
            this.chbEmitioVotacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEmitioVotacion.ForeColor = System.Drawing.Color.Gray;
            this.chbEmitioVotacion.Location = new System.Drawing.Point(537, 77);
            this.chbEmitioVotacion.Name = "chbEmitioVotacion";
            this.chbEmitioVotacion.Size = new System.Drawing.Size(77, 23);
            this.chbEmitioVotacion.TabIndex = 146;
            this.chbEmitioVotacion.Text = "SI/NO";
            this.chbEmitioVotacion.CheckedChanged += new System.EventHandler(this.chbEmitioVotacion_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(409, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 147;
            this.label3.Text = "EMITIO VOTACION:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaRegistro.BaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaRegistro.CustomFormat = null;
            this.dtpFechaRegistro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRegistro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(537, 36);
            this.dtpFechaRegistro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRegistro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Radius = 4;
            this.dtpFechaRegistro.Size = new System.Drawing.Size(240, 30);
            this.dtpFechaRegistro.TabIndex = 145;
            this.dtpFechaRegistro.Text = "jueves, 23 de noviembre de 2023";
            this.dtpFechaRegistro.Value = new System.DateTime(2023, 11, 23, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(420, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 144;
            this.label8.Text = "FEC. REGISTRO:";
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
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni.Location = new System.Drawing.Point(117, 74);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.Radius = 4;
            this.txtDni.Size = new System.Drawing.Size(240, 30);
            this.txtDni.TabIndex = 143;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(74, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 142;
            this.label7.Text = "DNI:";
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
            this.chkActivo.Location = new System.Drawing.Point(117, 192);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Radius = 1;
            this.chkActivo.Size = new System.Drawing.Size(138, 22);
            this.chkActivo.TabIndex = 85;
            this.chkActivo.Text = "Activo/Inactivo";
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.AnimationHoverSpeed = 0.07F;
            this.btnCargarLista.AnimationSpeed = 0.03F;
            this.btnCargarLista.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarLista.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargarLista.BorderColor = System.Drawing.Color.Black;
            this.btnCargarLista.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCargarLista.FocusedColor = System.Drawing.Color.Empty;
            this.btnCargarLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarLista.ForeColor = System.Drawing.Color.White;
            this.btnCargarLista.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarLista.Image")));
            this.btnCargarLista.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCargarLista.Location = new System.Drawing.Point(875, 155);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCargarLista.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCargarLista.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCargarLista.OnHoverImage = null;
            this.btnCargarLista.OnPressedColor = System.Drawing.Color.Black;
            this.btnCargarLista.Radius = 5;
            this.btnCargarLista.Size = new System.Drawing.Size(177, 38);
            this.btnCargarLista.TabIndex = 137;
            this.btnCargarLista.Text = "Cargar Lista";
            this.btnCargarLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCargarLista.Click += new System.EventHandler(this.btnCargarLista_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(614, 225);
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
            this.btnEditar.Location = new System.Drawing.Point(304, 225);
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
            this.btnEliminar.Location = new System.Drawing.Point(459, 225);
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
            this.btnGuardar.Location = new System.Drawing.Point(149, 225);
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
            // txtIdVotante
            // 
            this.txtIdVotante.BackColor = System.Drawing.Color.Transparent;
            this.txtIdVotante.BaseColor = System.Drawing.Color.White;
            this.txtIdVotante.BorderColor = System.Drawing.Color.Silver;
            this.txtIdVotante.BorderSize = 1;
            this.txtIdVotante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdVotante.Enabled = false;
            this.txtIdVotante.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdVotante.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdVotante.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdVotante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVotante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdVotante.Location = new System.Drawing.Point(118, 38);
            this.txtIdVotante.Name = "txtIdVotante";
            this.txtIdVotante.PasswordChar = '\0';
            this.txtIdVotante.Radius = 4;
            this.txtIdVotante.Size = new System.Drawing.Size(240, 30);
            this.txtIdVotante.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(83, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "ID:";
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
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.Location = new System.Drawing.Point(117, 150);
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
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.Location = new System.Drawing.Point(118, 112);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.Radius = 4;
            this.txtNombres.Size = new System.Drawing.Size(240, 30);
            this.txtNombres.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(46, 189);
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
            this.label1.Location = new System.Drawing.Point(28, 153);
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
            this.lblNombre.Location = new System.Drawing.Point(33, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 109;
            this.lblNombre.Text = "NOMBRES:";
            // 
            // FormVotantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "FormVotantes";
            this.Text = "Formularios de Votantes";
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVotantes)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvVotantes;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox chkActivo;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaTextBox txtIdVotante;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtApellidos;
        private Guna.UI.WinForms.GunaTextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI.WinForms.GunaTextBox txtDni;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaCheckBox chbEmitioVotacion;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtCreadoPorUsuario;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox cmbEleccion;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaButton btnCargarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVotante;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmitioVotacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EleccionCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
    }
}