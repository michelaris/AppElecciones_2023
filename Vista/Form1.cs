using Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Formularios;

namespace Vista
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            timer1.Enabled = true; //habilitamos el timer, que es el label que contiene el reloj
            cargarDatosDeUsuarioActual();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            
        }
        private void cargarDatosDeUsuarioActual()
        {
            this.lblNombreUsuarioActual.Text = UsuarioCache.Nombres;
            this.lblRolUsuarioActual.Text = UsuarioCache.Rol;
            this.pcbFoto.Image = bytesToImage(UsuarioCache.Foto);

            if (UsuarioCache.Rol!="Administrador")
            {
                this.btnUsuarios.Visible = false;
            }
        }
        //Convierte Imagen a byte[]
        private byte[] imageToBytes(PictureBox pbxFoto)
        {
            MemoryStream ms = new System.IO.MemoryStream();
            pbxFoto.Image.Save(ms, ImageFormat.Png);
            byte[] imagenByte = ms.ToArray();
            return imagenByte;
        }
        //Convierte Byte a Imagen
        public Image bytesToImage(byte[] imagenByte)
        {
            MemoryStream ms = new MemoryStream(imagenByte);
            Image foto = Image.FromStream(ms);

            return foto;
        }

        //Estucts se usa para colocar una barra verticual izquierda del boton seleccionado
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);//Color Morado
            public static Color color2 = Color.FromArgb(249, 118, 176);//Color rozado claro
            public static Color color3 = Color.FromArgb(253, 138, 114);//color naranjado
            public static Color color4 = Color.FromArgb(95, 77, 221);//Color Violeta
            public static Color color5 = Color.FromArgb(249, 88, 155);//Color Rosado oscuro
            public static Color color6 = Color.FromArgb(24, 161, 251);//Color Celest  
            public static Color color7 = Color.FromArgb(224, 224, 224);// Color Gris
            public static Color color8 = Color.FromArgb(51, 181, 229); //Color Celeste Info de boostrap  89, 105, 141
            public static Color color9 = Color.FromArgb(89, 105, 141); //Color Griz azulado de boostrap  MDB 
        }
        //Metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                // currentBtn.BackColor = Color.FromArgb(37, 36, 81);

                currentBtn.FlatAppearance.BorderSize = 0;
                // currentBtn.FlatAppearance.BorderColor = Color.White;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;//coloca el texto antes de la imagen
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, 40);
                currentBtn.IconSize = 33;
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icono Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.White;//color;
                iconCurrentChildForm.BackColor = color; //Color.White;

                currentBtn.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconSize = 33;

                currentBtn.Padding = new System.Windows.Forms.Padding(10, 0, 12, 0);
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //abre solamente un formulario a la vez
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            String tiempo = DateTime.Now.ToString();//DateTime.Now.ToString("HH:mm:ss");
            lblHoraActual.Text = " " + tiempo;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormUsuarios());
        }

        private void btnElecciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormElecciones());
        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormCandidatos());
        }

        private void btnVotantes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormVotantes());
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new FormResultados());
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    WindowState = FormWindowState.Normal;
            //}
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
