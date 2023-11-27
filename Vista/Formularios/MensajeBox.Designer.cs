
namespace Vista.Formularios
{
    partial class MensajeBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeBox));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnAceptarMsjBox = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnAceptarMsjBox
            // 
            this.btnAceptarMsjBox.Animated = true;
            this.btnAceptarMsjBox.AnimationHoverSpeed = 0.07F;
            this.btnAceptarMsjBox.AnimationSpeed = 0.03F;
            this.btnAceptarMsjBox.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarMsjBox.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnAceptarMsjBox.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAceptarMsjBox.BorderColor = System.Drawing.Color.Black;
            this.btnAceptarMsjBox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptarMsjBox.FocusedColor = System.Drawing.Color.Empty;
            this.btnAceptarMsjBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarMsjBox.ForeColor = System.Drawing.Color.White;
            this.btnAceptarMsjBox.Image = null;
            this.btnAceptarMsjBox.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAceptarMsjBox.Location = new System.Drawing.Point(168, 196);
            this.btnAceptarMsjBox.Name = "btnAceptarMsjBox";
            this.btnAceptarMsjBox.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAceptarMsjBox.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.btnAceptarMsjBox.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAceptarMsjBox.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAceptarMsjBox.OnHoverImage = null;
            this.btnAceptarMsjBox.OnPressedColor = System.Drawing.Color.Black;
            this.btnAceptarMsjBox.Radius = 20;
            this.btnAceptarMsjBox.Size = new System.Drawing.Size(154, 40);
            this.btnAceptarMsjBox.TabIndex = 2;
            this.btnAceptarMsjBox.Text = "ACEPTAR";
            this.btnAceptarMsjBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAceptarMsjBox.Click += new System.EventHandler(this.btnAceptarMsjBox_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(206, 39);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(78, 80);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(4, 151);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(473, 24);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "El Usuario Se Agrego Correctamente!";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // MensajeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 288);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnAceptarMsjBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensajeBox";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensajeBox";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btnAceptarMsjBox;
        private System.Windows.Forms.Label lblMensaje;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}