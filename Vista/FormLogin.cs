using Controller;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Formularios;

namespace Vista
{
    public partial class FormLogin : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        VotanteController votanteController = new VotanteController();
        public FormLogin()
        {
            InitializeComponent();
            //this.txtPassword.UseSystemPasswordChar = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           // this.panel1.BackColor = Color.FromArgb(25,0,0,0);
        }
                

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkIngresarConCredenciales_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkIngresarConCredenciales.Checked == true)
            {
                this.grbCredencialesAdmin.Visible = true;
                this.pcbDni.Visible = false;
                this.txtDni.Visible = false;
                //this.chkIngresarConCredenciales.Text = "Ingresar con DNI";
            }
            else
            {
                this.grbCredencialesAdmin.Visible = false;
                this.pcbDni.Visible = true;
                this.txtDni.Visible = true;
                this.chkIngresarConCredenciales.Text = "Ingresar con Credenciales";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.chkIngresarConCredenciales.Checked==true)
                {
                    var validLogin = usuarioController.Login(this.txtLoginName.Text, this.txtPassword.Text);

                    if (validLogin)
                    {
                        if (UsuarioCache.Rol == "Administrador")
                        {
                            Form1 formUsuariosCrud = new Form1();
                            // MessageBox.Show("Bienvenido " + UsuarioCache.LoginName);


                            MensajeBox m = new MensajeBox("Ingresó", "El Usuario: " + UsuarioCache.LoginName);
                            // m.ShowDialog();
                            DialogResult dg = m.ShowDialog();
                            //formUsuariosCrud.ShowDialog();
                            formUsuariosCrud.Show();
                            formUsuariosCrud.Closed += Logout;
                            this.Hide();

                        }
                        else
                        {
                            Form1 formMiCuenta = new Form1();
                            MessageBox.Show("Bienvenido " + UsuarioCache.LoginName);
                            // formMiCuenta.ShowDialog();
                            formMiCuenta.Show();
                            formMiCuenta.Closed += Logout;
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Datos ingresados Incorrectos");
                    }
                }
                else
                {
                    var validLoginVotante = votanteController.LoginVotante(this.txtDni.Text);

                    if (validLoginVotante)
                    {
                        if (VotanteCache.Activo==true)
                        {
                            FormVotaciones formVotaciones = new FormVotaciones();
                            // MessageBox.Show("Bienvenido " + UsuarioCache.LoginName);


                            MensajeBox m = new MensajeBox("Ingresó", "El Votante: " + VotanteCache.Nombres+" "+VotanteCache.Apellidos);
                            // m.ShowDialog();
                            DialogResult dg = m.ShowDialog();
                            // formVotaciones.ShowDialog();
                            formVotaciones.Show();
                            formVotaciones.Closed += Logout;
                            this.Hide();

                        }
                        else
                        {
                            Form1 formMiCuenta = new Form1();
                            MessageBox.Show("Bienvenido " + UsuarioCache.LoginName);
                            formMiCuenta.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Datos ingresados Incorrectos");
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Logout(object sender, EventArgs e)
        {
            try
            {
               // this.txtPassword.UseSystemPasswordChar = false;
                //this.txtPassword.Text = "Contraseña";
                //this.txtLoginName.Text = "Usuario";
                //this.FotoInicioSesion.Fill=
                //this.Show();
               
                this.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.StackTrace);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        

        private void txtLoginName_Enter(object sender, EventArgs e)
        {
            if (this.txtLoginName.Text=="LoginName")
            {
                this.txtLoginName.Text = "";
            }
            
        }

        private void txtLoginName_Leave(object sender, EventArgs e)
        {
            if (this.txtLoginName.Text=="")
            {
                this.txtLoginName.Text = "LoginName";
            }
        }
    }
}
