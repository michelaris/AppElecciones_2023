
namespace Vista.Formularios
{
    partial class FormCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCandidatos));
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCandidatos = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbEleccion = new Guna.UI.WinForms.GunaComboBox();
            this.dtpFechaRegistro = new Guna.UI.WinForms.GunaDateTimePicker();
            this.chkActivo = new Guna.UI.WinForms.GunaCheckBox();
            this.txtMensaje = new Guna.UI.WinForms.GunaTextBox();
            this.txtIdCandidato = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreadoPorUsuario = new Guna.UI.WinForms.GunaTextBox();
            this.txtApellidos = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombres = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCambiarFoto = new Guna.UI.WinForms.GunaButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaButton();
            this.btnEditar = new Guna.UI.WinForms.GunaButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.btnGuardar = new Guna.UI.WinForms.GunaButton();
            this.pcbFoto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.IdCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvCandidatos);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(4, 299);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1081, 276);
            this.gunaGroupBox2.TabIndex = 87;
            this.gunaGroupBox2.Text = "Lista de Candidatos";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(470, 4);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Activo,
            this.FechaRegistro,
            this.CreadoPor,
            this.Foto,
            this.IdUsuario,
            this.IdEleccion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCandidatos.EnableHeadersVisualStyles = false;
            this.dgvCandidatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.Location = new System.Drawing.Point(4, 35);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersVisible = false;
            this.dgvCandidatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvCandidatos.RowTemplate.Height = 45;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(1071, 222);
            this.dgvCandidatos.TabIndex = 0;
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
            this.dgvCandidatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCandidatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCandidatos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvCandidatos.ThemeStyle.ReadOnly = true;
            this.dgvCandidatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCandidatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCandidatos.ThemeStyle.RowsStyle.Height = 45;
            this.dgvCandidatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCandidatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatos_CellDoubleClick);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cmbEleccion);
            this.gunaGroupBox1.Controls.Add(this.dtpFechaRegistro);
            this.gunaGroupBox1.Controls.Add(this.chkActivo);
            this.gunaGroupBox1.Controls.Add(this.txtMensaje);
            this.gunaGroupBox1.Controls.Add(this.btnCambiarFoto);
            this.gunaGroupBox1.Controls.Add(this.btnNuevo);
            this.gunaGroupBox1.Controls.Add(this.btnEditar);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnGuardar);
            this.gunaGroupBox1.Controls.Add(this.txtIdCandidato);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtCreadoPorUsuario);
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
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(4, 11);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1082, 276);
            this.gunaGroupBox1.TabIndex = 86;
            this.gunaGroupBox1.Text = "Datos de Candidatos";
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
            this.cmbEleccion.Location = new System.Drawing.Point(719, 157);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEleccion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEleccion.Radius = 4;
            this.cmbEleccion.Size = new System.Drawing.Size(240, 28);
            this.cmbEleccion.TabIndex = 143;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaRegistro.BaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.BorderColor = System.Drawing.Color.Silver;
            this.dtpFechaRegistro.CustomFormat = null;
            this.dtpFechaRegistro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaRegistro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaRegistro.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(719, 80);
            this.dtpFechaRegistro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRegistro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaRegistro.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaRegistro.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaRegistro.Radius = 4;
            this.dtpFechaRegistro.Size = new System.Drawing.Size(240, 30);
            this.dtpFechaRegistro.TabIndex = 142;
            this.dtpFechaRegistro.Text = "domingo, 9 de octubre de 2022";
            this.dtpFechaRegistro.Value = new System.DateTime(2022, 10, 9, 22, 38, 41, 302);
            // 
            // chkActivo
            // 
            this.chkActivo.BaseColor = System.Drawing.Color.White;
            this.chkActivo.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkActivo.FillColor = System.Drawing.Color.White;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.ForeColor = System.Drawing.Color.Red;
            this.chkActivo.Location = new System.Drawing.Point(719, 49);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Radius = 1;
            this.chkActivo.Size = new System.Drawing.Size(88, 22);
            this.chkActivo.TabIndex = 85;
            this.chkActivo.Text = "Inactivo";
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.Transparent;
            this.txtMensaje.BaseColor = System.Drawing.Color.White;
            this.txtMensaje.BorderColor = System.Drawing.Color.Silver;
            this.txtMensaje.BorderSize = 1;
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensaje.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMensaje.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMensaje.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMensaje.Location = new System.Drawing.Point(334, 157);
            this.txtMensaje.MultiLine = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.PasswordChar = '\0';
            this.txtMensaje.Radius = 4;
            this.txtMensaje.Size = new System.Drawing.Size(240, 67);
            this.txtMensaje.TabIndex = 141;
            // 
            // txtIdCandidato
            // 
            this.txtIdCandidato.BackColor = System.Drawing.Color.Transparent;
            this.txtIdCandidato.BaseColor = System.Drawing.Color.White;
            this.txtIdCandidato.BorderColor = System.Drawing.Color.Silver;
            this.txtIdCandidato.BorderSize = 1;
            this.txtIdCandidato.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCandidato.Enabled = false;
            this.txtIdCandidato.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdCandidato.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIdCandidato.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdCandidato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCandidato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdCandidato.Location = new System.Drawing.Point(335, 43);
            this.txtIdCandidato.Name = "txtIdCandidato";
            this.txtIdCandidato.PasswordChar = '\0';
            this.txtIdCandidato.Radius = 4;
            this.txtIdCandidato.Size = new System.Drawing.Size(240, 30);
            this.txtIdCandidato.TabIndex = 132;
            this.txtIdCandidato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(292, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 131;
            this.label5.Text = "ID:";
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
            this.txtCreadoPorUsuario.Location = new System.Drawing.Point(719, 119);
            this.txtCreadoPorUsuario.Name = "txtCreadoPorUsuario";
            this.txtCreadoPorUsuario.PasswordChar = '\0';
            this.txtCreadoPorUsuario.Radius = 4;
            this.txtCreadoPorUsuario.Size = new System.Drawing.Size(240, 30);
            this.txtCreadoPorUsuario.TabIndex = 125;
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
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label13.Location = new System.Drawing.Point(633, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 25);
            this.label13.TabIndex = 115;
            this.label13.Text = "ELECCION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(254, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "MENSAJE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(612, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 113;
            this.label4.Text = "CREADO POR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(599, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 112;
            this.label3.Text = "FEC. REGISTRO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(651, 46);
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
            // pcbFoto
            // 
            this.pcbFoto.BaseColor = System.Drawing.Color.White;
            this.pcbFoto.Image = global::Vista.Properties.Resources.candidato;
            this.pcbFoto.Location = new System.Drawing.Point(23, 34);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(190, 190);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 107;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.UseTransfarantBackground = false;
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
            this.Mensaje.Width = 200;
            // 
            // Activo
            // 
            this.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 80;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "Fecha de Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 175;
            // 
            // CreadoPor
            // 
            this.CreadoPor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreadoPor.DataPropertyName = "NombreUsuario";
            this.CreadoPor.HeaderText = "Creado Por";
            this.CreadoPor.Name = "CreadoPor";
            this.CreadoPor.ReadOnly = true;
            this.CreadoPor.Width = 175;
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
            // 
            // FormCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.Name = "FormCandidatos";
            this.Text = "Formulario de Candidatos";
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvCandidatos;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCheckBox chkActivo;
        private Guna.UI.WinForms.GunaTextBox txtMensaje;
        private Guna.UI.WinForms.GunaButton btnCambiarFoto;
        private Guna.UI.WinForms.GunaButton btnNuevo;
        private Guna.UI.WinForms.GunaButton btnEditar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaButton btnGuardar;
        private Guna.UI.WinForms.GunaTextBox txtIdCandidato;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtCreadoPorUsuario;
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
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaRegistro;
        private Guna.UI.WinForms.GunaComboBox cmbEleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreadoPor;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEleccion;
    }
}