using Controller;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Formularios
{
    public partial class FormUsuarios : Form
    {
        UsuarioController usuarioController = new UsuarioController();

        //private static FormUsuarios _instance = null;
        //public FormUsuarios ObtenerInstancia()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new FormUsuarios();
        //    }
        //    return _instance;
        //}

        public FormUsuarios()
        {
            InitializeComponent();
            cargarLista();
            ocultarBotones();
        }


        private void cargarLista()
        {
            this.dgvUsuarios.DataSource = usuarioController.ListarUsuarios("%");
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
        private void limpiarCampos()
        {
            this.lblIdUsuario.Text = "0";
            this.txtDni.Text = "";
            this.txtApellidos.Text = "";
            this.txtNombres.Text = "";
            this.txtCorreo.Text = "";
            this.chkActivo.Checked = false;
            this.cmbRol.Text = "Seleccione Rol..";
            this.txtPassword.Text = "";
            this.txtLoginName.Text = "";

            this.pcbFoto.Image = Properties.Resources.Usuario;// null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombres.Text != null)
                {
                    string Rpta = "";
                    Usuario us = new Usuario();
                    us.DocumentoIdentidad = this.txtDni.Text;                   
                    us.Nombres = this.txtNombres.Text;
                    us.Apellidos = this.txtApellidos.Text;
                    us.Correo = this.txtCorreo.Text;
                    us.Activo = this.chkActivo.Checked;
                    us.Rol = this.cmbRol.Text;
                    us.LoginName = this.txtLoginName.Text;
                    us.Password = this.txtPassword.Text;
                    us.Foto = imageToBytes(this.pcbFoto);
                    Rpta = usuarioController.CrearUsuario(us);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                       /* MessageBox.Show("Los datos han sido guardados correctamente",
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                       */
                        MensajeBox m = new MensajeBox("Guardo","El Usuario: "+us.Nombres+" "+us.Apellidos);
                       // m.ShowDialog();
                        DialogResult dg = m.ShowDialog();
                        //label1.Text = dg.ToString();

                        //cargarLista();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    cargarLista();

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Fotografia", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lblIdUsuario.Text != "0")
                {
                    string Rpta = "";
                    Usuario us = new Usuario();
                    us.IdUsuario = int.Parse(this.lblIdUsuario.Text);
                    us.DocumentoIdentidad = this.txtDni.Text;
                    us.Nombres = this.txtNombres.Text;
                    us.Apellidos = this.txtApellidos.Text;
                    us.Correo = this.txtCorreo.Text;
                    us.Activo = this.chkActivo.Checked;
                    us.Rol = this.cmbRol.Text;
                    us.LoginName = this.txtLoginName.Text;
                    us.Password = this.txtPassword.Text;
                    us.Foto = imageToBytes(this.pcbFoto);
                    Rpta = usuarioController.EditarUsuario(us);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Actualizo", "El Usuario: " + us.Nombres + " " + us.Apellidos);
                        // m.ShowDialog();
                        DialogResult dg = m.ShowDialog();
                        //label1.Text = dg.ToString();

                        //cargarLista();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    cargarLista();

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Fotografia", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lblIdUsuario.Text != "0")
                {
                    int id = int.Parse(this.lblIdUsuario.Text);
                    string Rpta;
                    Rpta = usuarioController.EliminarUsuario(id);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Elimino", "El Usuario: " + this.txtNombres.Text + " " + this.txtApellidos.Text);
                        // m.ShowDialog();
                        DialogResult dg = m.ShowDialog();
                        //label1.Text = dg.ToString();

                        //cargarLista();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    cargarLista();

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Fotografia", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen JPG y PNG|*.jpg;*.png|PNG(*.png)|*.png|All Files(*.*)|*.*";
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Seleccione Imagen para el Usuario";

            DialogResult rs = openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                this.pcbFoto.BackgroundImage = null;
                //  direImagen = openFileDialog.FileName.ToString();
                // nombreImagen = System.IO.Path.GetFileName(direImagen);

                this.pcbFoto.Image = Image.FromFile(openFileDialog.FileName);
                //this.pbxFoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkActivo.Checked==true)
            {
                this.chkActivo.Text = "Activo";
                this.chkActivo.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.chkActivo.Text = "Inactivo";
                this.chkActivo.ForeColor = Color.Red;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void ocultarBotones()
        {
            this.btnGuardar.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }
        private void mostrarBotones()
        {
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
            

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvUsuarios.CurrentRow != null)
                {
                    this.lblIdUsuario.Text = this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                    this.txtDni.Text = this.dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                    this.txtNombres.Text = this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                    this.txtApellidos.Text = this.dgvUsuarios.CurrentRow.Cells[3].Value.ToString();

                    this.txtCorreo.Text = this.dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                    this.txtLoginName.Text = this.dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                    this.txtPassword.Text = this.dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
                    this.chkActivo.Checked =this.dgvUsuarios.CurrentRow.Cells[7].Value.ToString()=="1"?true:false;
                    this.cmbRol.Text = this.dgvUsuarios.CurrentRow.Cells[8].Value.ToString();

                    this.pcbFoto.Image = bytesToImage((byte[])(this.dgvUsuarios.CurrentRow.Cells[9].Value));
                    mostrarBotones();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Datos " + ex.Message, "Error");
            }
        }
    }
}
