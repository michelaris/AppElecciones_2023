
namespace Vista
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaButton();
            this.btnMaximizar = new Guna.UI.WinForms.GunaButton();
            this.btnMinimizar = new Guna.UI.WinForms.GunaButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRolUsuarioActual = new Guna.UI.WinForms.GunaLabel();
            this.lblNombreUsuarioActual = new Guna.UI.WinForms.GunaLabel();
            this.pcbFoto = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnResultados = new FontAwesome.Sharp.IconButton();
            this.btnVotantes = new FontAwesome.Sharp.IconButton();
            this.btnCandidatos = new FontAwesome.Sharp.IconButton();
            this.btnElecciones = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panelMenu.Controls.Add(this.btnCerrar);
            this.panelMenu.Controls.Add(this.btnMaximizar);
            this.panelMenu.Controls.Add(this.btnMinimizar);
            this.panelMenu.Controls.Add(this.iconCurrentChildForm);
            this.panelMenu.Controls.Add(this.lblTitleChildForm);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1086, 97);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
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
            this.btnCerrar.Location = new System.Drawing.Point(1056, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Radius = 3;
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.TabIndex = 29;
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
            this.btnMaximizar.Location = new System.Drawing.Point(1026, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMaximizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMaximizar.OnHoverImage = null;
            this.btnMaximizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaximizar.Radius = 3;
            this.btnMaximizar.Size = new System.Drawing.Size(27, 27);
            this.btnMaximizar.TabIndex = 28;
            this.btnMaximizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
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
            this.btnMinimizar.Location = new System.Drawing.Point(996, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMinimizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimizar.OnHoverImage = null;
            this.btnMinimizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizar.Radius = 3;
            this.btnMinimizar.Size = new System.Drawing.Size(27, 27);
            this.btnMinimizar.TabIndex = 27;
            this.btnMinimizar.Text = "___";
            this.btnMinimizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.DimGray;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 30;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(1, 1);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(30, 30);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(42, 6);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(68, 20);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Principal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.panel3.Controls.Add(this.lblRolUsuarioActual);
            this.panel3.Controls.Add(this.lblNombreUsuarioActual);
            this.panel3.Controls.Add(this.pcbFoto);
            this.panel3.Controls.Add(this.btnResultados);
            this.panel3.Controls.Add(this.btnVotantes);
            this.panel3.Controls.Add(this.btnCandidatos);
            this.panel3.Controls.Add(this.btnElecciones);
            this.panel3.Controls.Add(this.btnUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 65);
            this.panel3.TabIndex = 0;
            // 
            // lblRolUsuarioActual
            // 
            this.lblRolUsuarioActual.AutoSize = true;
            this.lblRolUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRolUsuarioActual.ForeColor = System.Drawing.Color.Gold;
            this.lblRolUsuarioActual.Location = new System.Drawing.Point(59, 34);
            this.lblRolUsuarioActual.Name = "lblRolUsuarioActual";
            this.lblRolUsuarioActual.Size = new System.Drawing.Size(83, 15);
            this.lblRolUsuarioActual.TabIndex = 11;
            this.lblRolUsuarioActual.Text = "Administrador";
            // 
            // lblNombreUsuarioActual
            // 
            this.lblNombreUsuarioActual.AutoSize = true;
            this.lblNombreUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreUsuarioActual.ForeColor = System.Drawing.Color.Gold;
            this.lblNombreUsuarioActual.Location = new System.Drawing.Point(59, 14);
            this.lblNombreUsuarioActual.Name = "lblNombreUsuarioActual";
            this.lblNombreUsuarioActual.Size = new System.Drawing.Size(43, 15);
            this.lblNombreUsuarioActual.TabIndex = 10;
            this.lblNombreUsuarioActual.Text = "Michel";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BaseColor = System.Drawing.Color.White;
            this.pcbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pcbFoto.Image")));
            this.pcbFoto.Location = new System.Drawing.Point(9, 3);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(47, 47);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 9;
            this.pcbFoto.TabStop = false;
            this.pcbFoto.UseTransfarantBackground = false;
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(78)))));
            this.btnResultados.FlatAppearance.BorderSize = 0;
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultados.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.ForeColor = System.Drawing.Color.White;
            this.btnResultados.IconChar = FontAwesome.Sharp.IconChar.Medal;
            this.btnResultados.IconColor = System.Drawing.Color.White;
            this.btnResultados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResultados.IconSize = 33;
            this.btnResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultados.Location = new System.Drawing.Point(896, 7);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnResultados.Size = new System.Drawing.Size(183, 52);
            this.btnResultados.TabIndex = 8;
            this.btnResultados.Text = "Resultados";
            this.btnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResultados.UseVisualStyleBackColor = false;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // btnVotantes
            // 
            this.btnVotantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.btnVotantes.FlatAppearance.BorderSize = 0;
            this.btnVotantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotantes.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotantes.ForeColor = System.Drawing.Color.White;
            this.btnVotantes.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.btnVotantes.IconColor = System.Drawing.Color.White;
            this.btnVotantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVotantes.IconSize = 35;
            this.btnVotantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotantes.Location = new System.Drawing.Point(708, 7);
            this.btnVotantes.Name = "btnVotantes";
            this.btnVotantes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVotantes.Size = new System.Drawing.Size(183, 52);
            this.btnVotantes.TabIndex = 7;
            this.btnVotantes.Text = "Votantes";
            this.btnVotantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVotantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVotantes.UseVisualStyleBackColor = false;
            this.btnVotantes.Click += new System.EventHandler(this.btnVotantes_Click);
            // 
            // btnCandidatos
            // 
            this.btnCandidatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.btnCandidatos.FlatAppearance.BorderSize = 0;
            this.btnCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidatos.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatos.ForeColor = System.Drawing.Color.White;
            this.btnCandidatos.IconChar = FontAwesome.Sharp.IconChar.UsersBetweenLines;
            this.btnCandidatos.IconColor = System.Drawing.Color.White;
            this.btnCandidatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCandidatos.IconSize = 35;
            this.btnCandidatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidatos.Location = new System.Drawing.Point(520, 7);
            this.btnCandidatos.Name = "btnCandidatos";
            this.btnCandidatos.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnCandidatos.Size = new System.Drawing.Size(183, 52);
            this.btnCandidatos.TabIndex = 6;
            this.btnCandidatos.Text = "Candidatos";
            this.btnCandidatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCandidatos.UseVisualStyleBackColor = false;
            this.btnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // btnElecciones
            // 
            this.btnElecciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(105)))), ((int)(((byte)(141)))));
            this.btnElecciones.FlatAppearance.BorderSize = 0;
            this.btnElecciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElecciones.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElecciones.ForeColor = System.Drawing.Color.White;
            this.btnElecciones.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btnElecciones.IconColor = System.Drawing.Color.White;
            this.btnElecciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnElecciones.IconSize = 33;
            this.btnElecciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElecciones.Location = new System.Drawing.Point(332, 7);
            this.btnElecciones.Name = "btnElecciones";
            this.btnElecciones.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnElecciones.Size = new System.Drawing.Size(183, 52);
            this.btnElecciones.TabIndex = 5;
            this.btnElecciones.Text = "Elecciones";
            this.btnElecciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElecciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElecciones.UseVisualStyleBackColor = false;
            this.btnElecciones.Click += new System.EventHandler(this.btnElecciones_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 40;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(144, 7);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(183, 52);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.lblHoraActual);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 677);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 34);
            this.panel1.TabIndex = 84;
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.ForeColor = System.Drawing.Color.Gold;
            this.lblHoraActual.Location = new System.Drawing.Point(860, 3);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(60, 25);
            this.lblHoraActual.TabIndex = 8;
            this.lblHoraActual.Text = "Hora";
            this.lblHoraActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(405, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sistema Gestion de Elecciones";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Black;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 97);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1086, 580);
            this.panelDesktop.TabIndex = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1086, 711);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaLabel lblRolUsuarioActual;
        private Guna.UI.WinForms.GunaLabel lblNombreUsuarioActual;
        private Guna.UI.WinForms.GunaCirclePictureBox pcbFoto;
        private FontAwesome.Sharp.IconButton btnResultados;
        private FontAwesome.Sharp.IconButton btnVotantes;
        private FontAwesome.Sharp.IconButton btnCandidatos;
        private FontAwesome.Sharp.IconButton btnElecciones;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private Guna.UI.WinForms.GunaButton btnMinimizar;
        private Guna.UI.WinForms.GunaButton btnCerrar;
        private Guna.UI.WinForms.GunaButton btnMaximizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

