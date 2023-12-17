
namespace Vista
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.gunaElipseWindows = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControlPiclTureBackground = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panelSuperior = new Guna.UI.WinForms.GunaGradient2Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.btnCerrar = new Guna.UI.WinForms.GunaButton();
            this.btnMinimizar = new Guna.UI.WinForms.GunaButton();
            this.pcbBackground = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipsePictureLogin = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pcbDni = new Guna.UI.WinForms.GunaPictureBox();
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.grbCredencialesAdmin = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtLoginName = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.chkIngresarConCredenciales = new Guna.UI.WinForms.GunaCheckBox();
            this.btnIngresar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDni)).BeginInit();
            this.grbCredencialesAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipseWindows
            // 
            this.gunaElipseWindows.Radius = 10;
            this.gunaElipseWindows.TargetControl = this;
            // 
            // gunaDragControlPiclTureBackground
            // 
            this.gunaDragControlPiclTureBackground.TargetControl = this.panelSuperior;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.Controls.Add(this.iconCurrentChildForm);
            this.panelSuperior.Controls.Add(this.lblTitleChildForm);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Controls.Add(this.btnMinimizar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.GradientColor1 = System.Drawing.Color.DarkViolet;
            this.panelSuperior.GradientColor2 = System.Drawing.Color.Black;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1050, 50);
            this.panelSuperior.TabIndex = 4;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(11, 6);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
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
            this.lblTitleChildForm.Size = new System.Drawing.Size(427, 26);
            this.lblTitleChildForm.TabIndex = 37;
            this.lblTitleChildForm.Text = "Sistema Gestion de Elecciones";
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
            this.btnCerrar.Location = new System.Drawing.Point(1015, 6);
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
            this.btnMinimizar.Location = new System.Drawing.Point(974, 6);
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
            // 
            // pcbBackground
            // 
            this.pcbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pcbBackground.BaseColor = System.Drawing.Color.White;
            this.pcbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbBackground.Location = new System.Drawing.Point(0, 0);
            this.pcbBackground.Name = "pcbBackground";
            this.pcbBackground.Radius = 5;
            this.pcbBackground.Size = new System.Drawing.Size(1050, 597);
            this.pcbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackground.TabIndex = 0;
            this.pcbBackground.TabStop = false;
            // 
            // gunaElipsePictureLogin
            // 
            this.gunaElipsePictureLogin.Radius = 10;
            this.gunaElipsePictureLogin.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel1.Controls.Add(this.gunaGroupBox1);
            this.gunaPanel1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 50);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1050, 547);
            this.gunaPanel1.TabIndex = 5;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.OrangeRed;
            this.gunaGroupBox1.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaGroupBox1.Controls.Add(this.pcbDni);
            this.gunaGroupBox1.Controls.Add(this.txtDni);
            this.gunaGroupBox1.Controls.Add(this.grbCredencialesAdmin);
            this.gunaGroupBox1.Controls.Add(this.chkIngresarConCredenciales);
            this.gunaGroupBox1.Controls.Add(this.btnIngresar);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.Location = new System.Drawing.Point(672, 35);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 20;
            this.gunaGroupBox1.Size = new System.Drawing.Size(309, 472);
            this.gunaGroupBox1.TabIndex = 5;
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            this.gunaGroupBox1.UseTransfarantBackground = true;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::Vista.Properties.Resources.Usuario;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(54, 16);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(200, 200);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 7;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // pcbDni
            // 
            this.pcbDni.BaseColor = System.Drawing.Color.White;
            this.pcbDni.Image = ((System.Drawing.Image)(resources.GetObject("pcbDni.Image")));
            this.pcbDni.Location = new System.Drawing.Point(18, 309);
            this.pcbDni.Name = "pcbDni";
            this.pcbDni.Size = new System.Drawing.Size(40, 40);
            this.pcbDni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDni.TabIndex = 6;
            this.pcbDni.TabStop = false;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.Transparent;
            this.txtDni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDni.BaseColor = System.Drawing.Color.Black;
            this.txtDni.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDni.BorderSize = 1;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.Gold;
            this.txtDni.Location = new System.Drawing.Point(65, 309);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '●';
            this.txtDni.Radius = 10;
            this.txtDni.Size = new System.Drawing.Size(220, 43);
            this.txtDni.TabIndex = 5;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni.UseSystemPasswordChar = true;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // grbCredencialesAdmin
            // 
            this.grbCredencialesAdmin.BackColor = System.Drawing.Color.Transparent;
            this.grbCredencialesAdmin.BaseColor = System.Drawing.Color.Transparent;
            this.grbCredencialesAdmin.BorderColor = System.Drawing.Color.Transparent;
            this.grbCredencialesAdmin.Controls.Add(this.gunaPictureBox2);
            this.grbCredencialesAdmin.Controls.Add(this.gunaPictureBox1);
            this.grbCredencialesAdmin.Controls.Add(this.txtLoginName);
            this.grbCredencialesAdmin.Controls.Add(this.txtPassword);
            this.grbCredencialesAdmin.LineColor = System.Drawing.Color.Transparent;
            this.grbCredencialesAdmin.Location = new System.Drawing.Point(0, 223);
            this.grbCredencialesAdmin.Name = "grbCredencialesAdmin";
            this.grbCredencialesAdmin.Size = new System.Drawing.Size(309, 137);
            this.grbCredencialesAdmin.TabIndex = 4;
            this.grbCredencialesAdmin.TextLocation = new System.Drawing.Point(10, 8);
            this.grbCredencialesAdmin.Visible = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(22, 88);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 5;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(22, 34);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // txtLoginName
            // 
            this.txtLoginName.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtLoginName.BaseColor = System.Drawing.Color.Black;
            this.txtLoginName.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtLoginName.BorderSize = 1;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtLoginName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLoginName.FocusedForeColor = System.Drawing.Color.DodgerBlue;
            this.txtLoginName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.ForeColor = System.Drawing.Color.Gold;
            this.txtLoginName.Location = new System.Drawing.Point(65, 33);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.Radius = 10;
            this.txtLoginName.Size = new System.Drawing.Size(220, 43);
            this.txtLoginName.TabIndex = 3;
            this.txtLoginName.Text = "LoginName";
            this.txtLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLoginName.Enter += new System.EventHandler(this.txtLoginName_Enter);
            this.txtLoginName.Leave += new System.EventHandler(this.txtLoginName_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BaseColor = System.Drawing.Color.Black;
            this.txtPassword.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.Black;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gold;
            this.txtPassword.Location = new System.Drawing.Point(65, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Radius = 10;
            this.txtPassword.Size = new System.Drawing.Size(220, 43);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkIngresarConCredenciales
            // 
            this.chkIngresarConCredenciales.BaseColor = System.Drawing.Color.White;
            this.chkIngresarConCredenciales.CheckedOffColor = System.Drawing.Color.Gray;
            this.chkIngresarConCredenciales.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chkIngresarConCredenciales.FillColor = System.Drawing.Color.White;
            this.chkIngresarConCredenciales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIngresarConCredenciales.ForeColor = System.Drawing.Color.White;
            this.chkIngresarConCredenciales.Location = new System.Drawing.Point(35, 360);
            this.chkIngresarConCredenciales.Name = "chkIngresarConCredenciales";
            this.chkIngresarConCredenciales.Size = new System.Drawing.Size(242, 23);
            this.chkIngresarConCredenciales.TabIndex = 3;
            this.chkIngresarConCredenciales.Text = "Ingresar con Credenciales";
            this.chkIngresarConCredenciales.CheckedChanged += new System.EventHandler(this.chkIngresarConCredenciales_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.Animated = true;
            this.btnIngresar.AnimationHoverSpeed = 5F;
            this.btnIngresar.AnimationSpeed = 5F;
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.BaseColor2 = System.Drawing.Color.MidnightBlue;
            this.btnIngresar.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresar.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = null;
            this.btnIngresar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIngresar.Location = new System.Drawing.Point(54, 389);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnHoverBaseColor1 = System.Drawing.Color.MidnightBlue;
            this.btnIngresar.OnHoverBaseColor2 = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresar.OnHoverImage = null;
            this.btnIngresar.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresar.Radius = 5;
            this.btnIngresar.Size = new System.Drawing.Size(211, 44);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox1.Image")));
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(651, 15);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(354, 515);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 4;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 597);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.pcbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDni)).EndInit();
            this.grbCredencialesAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipseWindows;
        private Guna.UI.WinForms.GunaDragControl gunaDragControlPiclTureBackground;
        private Guna.UI.WinForms.GunaPictureBox pcbBackground;
        private Guna.UI.WinForms.GunaElipse gunaElipsePictureLogin;
        private Guna.UI.WinForms.GunaGradient2Panel panelSuperior;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private Guna.UI.WinForms.GunaButton btnCerrar;
        private Guna.UI.WinForms.GunaButton btnMinimizar;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaPictureBox pcbDni;
        private Guna.UI.WinForms.GunaTextBox txtDni;
        private Guna.UI.WinForms.GunaGroupBox grbCredencialesAdmin;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaTextBox txtLoginName;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaCheckBox chkIngresarConCredenciales;
        private Guna.UI.WinForms.GunaGradientButton btnIngresar;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
    }
}