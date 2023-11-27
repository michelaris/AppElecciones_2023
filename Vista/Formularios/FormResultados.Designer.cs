
namespace Vista.Formularios
{
    partial class FormResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtBuscarEleccion = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbFoto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCandidatos = new Guna.UI.WinForms.GunaDataGridView();
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
            this.gunaCircleProgressBar1 = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaCircleProgressBar1);
            this.gunaGroupBox1.Controls.Add(this.gunaGroupBox3);
            this.gunaGroupBox1.Controls.Add(this.txtBuscarEleccion);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.pcbFoto);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(78)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 14);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 5;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1082, 276);
            this.gunaGroupBox1.TabIndex = 88;
            this.gunaGroupBox1.Text = "Resultados de Eleccion";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(470, 4);
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaGroupBox3.Location = new System.Drawing.Point(14, 75);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(435, 185);
            this.gunaGroupBox3.TabIndex = 142;
            this.gunaGroupBox3.Text = "Lista de Elecciones";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtBuscarEleccion
            // 
            this.txtBuscarEleccion.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarEleccion.BaseColor = System.Drawing.Color.White;
            this.txtBuscarEleccion.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarEleccion.BorderSize = 1;
            this.txtBuscarEleccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEleccion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarEleccion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscarEleccion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarEleccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarEleccion.Location = new System.Drawing.Point(149, 39);
            this.txtBuscarEleccion.Name = "txtBuscarEleccion";
            this.txtBuscarEleccion.PasswordChar = '\0';
            this.txtBuscarEleccion.Radius = 4;
            this.txtBuscarEleccion.Size = new System.Drawing.Size(240, 30);
            this.txtBuscarEleccion.TabIndex = 141;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "BUSCAR ELECCION:";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BaseColor = System.Drawing.Color.White;
            this.pcbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pcbFoto.Image")));
            this.pcbFoto.Location = new System.Drawing.Point(816, 130);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(108, 106);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 107;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.UseTransfarantBackground = false;
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
            this.gunaGroupBox2.Location = new System.Drawing.Point(4, 304);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 5;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1081, 276);
            this.gunaGroupBox2.TabIndex = 143;
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
            // gunaCircleProgressBar1
            // 
            this.gunaCircleProgressBar1.Animated = true;
            this.gunaCircleProgressBar1.AnimationSpeed = 0.6F;
            this.gunaCircleProgressBar1.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.gunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressBar1.IdleOffset = 20;
            this.gunaCircleProgressBar1.Image = null;
            this.gunaCircleProgressBar1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressBar1.Location = new System.Drawing.Point(680, 44);
            this.gunaCircleProgressBar1.Name = "gunaCircleProgressBar1";
            this.gunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCircleProgressBar1.ProgressOffset = 20;
            this.gunaCircleProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.gunaCircleProgressBar1.TabIndex = 143;
            this.gunaCircleProgressBar1.UseProgressPercentText = true;
            this.gunaCircleProgressBar1.Value = 40;
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResultados";
            this.Text = "Resultados de Elecciones";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtBuscarEleccion;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbFoto;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvCandidatos;
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
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressBar1;
    }
}