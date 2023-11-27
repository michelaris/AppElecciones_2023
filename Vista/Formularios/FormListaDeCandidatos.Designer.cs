
namespace Vista.Formularios
{
    partial class FormListaDeCandidatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaDeCandidatos));
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCandidatos = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
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
            this.lblCargo = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gunaGroupBox2.Location = new System.Drawing.Point(7, 112);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1004, 459);
            this.gunaGroupBox2.TabIndex = 88;
            this.gunaGroupBox2.Text = "Lista de Candidat@s";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvCandidatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCandidatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCandidatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCandidatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandidatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandidatos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCandidatos.EnableHeadersVisualStyles = false;
            this.dgvCandidatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.Location = new System.Drawing.Point(4, 35);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersVisible = false;
            this.dgvCandidatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dgvCandidatos.RowTemplate.Height = 65;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(998, 410);
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
            this.dgvCandidatos.ThemeStyle.RowsStyle.Height = 65;
            this.dgvCandidatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCandidatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 44);
            this.panel1.TabIndex = 89;
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
            this.btnCerrar.Location = new System.Drawing.Point(979, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Radius = 3;
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
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
            this.Activo.Width = 75;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "Fec. de Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 120;
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
            this.Foto.Width = 75;
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
            this.IdEleccion.HeaderText = "Eleccion";
            this.IdEleccion.Name = "IdEleccion";
            this.IdEleccion.ReadOnly = true;
            this.IdEleccion.Width = 75;
            // 
            // lblCargo
            // 
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Gold;
            this.lblCargo.Location = new System.Drawing.Point(7, 47);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(1000, 51);
            this.lblCargo.TabIndex = 90;
            this.lblCargo.Text = "CANDIDAT@S";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormListaDeCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1019, 580);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaGroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaDeCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaDeCandidatos";
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvCandidatos;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnCerrar;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
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
        private Guna.UI.WinForms.GunaLabel lblCargo;
    }
}