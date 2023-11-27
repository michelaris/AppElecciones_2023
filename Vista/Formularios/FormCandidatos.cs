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
    public partial class FormCandidatos : Form
    {
        CandidatoController candidatoController = new CandidatoController();
        EleccionController eleccionController = new EleccionController();
        public FormCandidatos()
        {
            InitializeComponent();
            cargarLista();
            cargarListaElecciones();
            this.txtCreadoPorUsuario.Text = "Michel Zerpa"; //UsuarioCache.Nombres + " " + UsuarioCache.Apellidos;
        }
        private void cargarLista()
        {
            this.dgvCandidatos.DataSource = candidatoController.ListarCandidatos("%");
        }
        private void cargarListaElecciones()
        {


            EleccionController eleccionController = new EleccionController();
            this.cmbEleccion.DataSource = eleccionController.ListarElecciones("%");
            this.cmbEleccion.ValueMember = "idEleccion";
            this.cmbEleccion.DisplayMember = "cargo";
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
            
            this.txtIdCandidato.Text = "";           
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtMensaje.Text = "";
            this.chkActivo.Checked = false;
            this.dtpFechaRegistro.Value = DateTime.Now;
            this.txtCreadoPorUsuario.Text = "";
            this.cmbEleccion.StartIndex = -1;// "Seleccione Eleccion...";

            this.pcbFoto.Image = Properties.Resources.candidato;// null;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombres.Text != null)
                {
                    string Rpta = "";
                    Candidato ca = new Candidato();                    
                    ca.Nombres = this.txtNombres.Text;
                    ca.Apellidos = this.txtApellidos.Text;
                    ca.Mensaje = this.txtMensaje.Text;
                    ca.Foto = imageToBytes(this.pcbFoto);
                    ca.Activo = this.chkActivo.Checked;
                    ca.FechaRegistro = this.dtpFechaRegistro.Value;
                    ca.IdUsuario = 2;//UsuarioCache.IdUSuario;
                    ca.IdEleccion = int.Parse(this.cmbEleccion.SelectedValue.ToString());
                    Rpta = candidatoController.CrearCandidato(ca);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Guardo", "El Candidato: " + ca.Nombres + " " + ca.Apellidos);
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
                if (this.txtIdCandidato.Text != "")
                {
                    string Rpta = "";
                    Candidato ca = new Candidato();
                    ca.IdCandidato = int.Parse(this.txtIdCandidato.Text);
                    ca.Nombres = this.txtNombres.Text;
                    ca.Apellidos = this.txtApellidos.Text;
                    ca.Mensaje = this.txtMensaje.Text;
                    ca.Foto = imageToBytes(this.pcbFoto);
                    ca.Activo = this.chkActivo.Checked;
                    ca.FechaRegistro = this.dtpFechaRegistro.Value;
                    ca.IdUsuario = 2;//UsuarioCache.IdUSuario;
                    ca.IdEleccion = int.Parse(this.cmbEleccion.SelectedValue.ToString());
                    Rpta = candidatoController.EditarCandidato(ca);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Actualizo", "El Candidato: " + ca.Nombres + " " + ca.Apellidos);
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
                if (this.txtIdCandidato.Text != "")
                {
                    int id = int.Parse(this.txtIdCandidato.Text);
                    string Rpta;
                    Rpta = candidatoController.EliminarCandidato(id);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Eliminó", "El Usuario: " + this.txtNombres.Text + " " + this.txtApellidos.Text);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkActivo.Checked == true)
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

        private void dgvCandidatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvCandidatos.CurrentRow != null)
                {
                    this.txtIdCandidato.Text = this.dgvCandidatos.CurrentRow.Cells[0].Value.ToString();
                    this.txtNombres.Text = this.dgvCandidatos.CurrentRow.Cells[1].Value.ToString();
                    this.txtApellidos.Text = this.dgvCandidatos.CurrentRow.Cells[2].Value.ToString();
                    this.txtMensaje.Text = this.dgvCandidatos.CurrentRow.Cells[3].Value.ToString();
                    this.chkActivo.Checked = this.dgvCandidatos.CurrentRow.Cells[4].Value.ToString() == "1" ? true : false;
                    this.dtpFechaRegistro.Value = (DateTime)this.dgvCandidatos.CurrentRow.Cells[5].Value;
                    this.txtCreadoPorUsuario.Text = this.dgvCandidatos.CurrentRow.Cells[6].Value.ToString();
                    var us = eleccionController.ObtenerEleccion(int.Parse(this.dgvCandidatos.CurrentRow.Cells[9].Value.ToString()));
                    this.cmbEleccion.SelectedValue = this.dgvCandidatos.CurrentRow.Cells[9].Value.ToString();
                    this.pcbFoto.Image = bytesToImage((byte[])(this.dgvCandidatos.CurrentRow.Cells[7].Value));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Datos " + ex.Message, "Error");
            }
        }
    }
}
