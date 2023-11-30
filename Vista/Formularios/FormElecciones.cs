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
    public partial class FormElecciones : Form
    {
        EleccionController eleccionController = new EleccionController();
        UsuarioController usuarioController = new UsuarioController();
        public FormElecciones()
        {
            InitializeComponent();
            cargarLista();
            this.txtUsuarioCreador.Text = "Michel Zerpa";// UsuarioCache.Nombres + " " + UsuarioCache.Apellidos;
        }

        private void cargarLista()
        {
            this.dgvElecciones.DataSource = eleccionController.ListarElecciones("%");
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
            this.txtIdEleccion.Text = "";
            this.txtDescripcion.Text = "";
            this.txtCargo.Text = "";
            this.dtpFechaRegistro.Text = DateTime.Now.ToString();// "";
            this.dtpFechaVotacion.Text = "";
            this.chkActivo.Checked = false;

            this.txtUsuarioCreador.Text = "";

            this.pcbFoto.Image = Properties.Resources.Imagen_elecciones;// null;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDescripcion.Text != null)
                {
                    string Rpta = "";
                    Eleccion ele = new Eleccion();
                    ele.Descripcion = this.txtDescripcion.Text;
                    ele.Cargo = this.txtCargo.Text;                 
                    ele.Activo = this.chkActivo.Checked;
                    ele.FechaRegistro = this.dtpFechaRegistro.Value;
                    ele.FechaVotacion = this.dtpFechaVotacion.Value;
                    ele.IdUsuario = 2;//UsuarioCache.IdUSuario;
                    ele.Foto = imageToBytes(this.pcbFoto);
                    Rpta = eleccionController.CrearEleccion(ele);
                    if (Rpta.Equals("OK"))
                    {
                       
                        MensajeBox m = new MensajeBox("Guardo", "La Eleccion: " + ele.Descripcion);
                       
                        DialogResult dg = m.ShowDialog();
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
                if (this.txtIdEleccion.Text != null)
                {
                    string Rpta = "";
                    Eleccion ele = new Eleccion();
                    ele.IdEleccion = int.Parse(this.txtIdEleccion.Text);
                    ele.Descripcion = this.txtDescripcion.Text;
                    ele.Cargo = this.txtCargo.Text;
                    ele.Activo = this.chkActivo.Checked;
                    ele.FechaRegistro = this.dtpFechaRegistro.Value;
                    ele.FechaVotacion = this.dtpFechaVotacion.Value;
                    ele.IdUsuario = 2;//UsuarioCache.IdUSuario;
                    ele.Foto = imageToBytes(this.pcbFoto);
                    Rpta = eleccionController.EditarEleccion(ele);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Actualizo", "La Eleccion: " + ele.Descripcion);
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
                if (this.txtIdEleccion.Text != "")
                {
                    int id = int.Parse(this.txtIdEleccion.Text);
                    string Rpta;
                    Rpta = eleccionController.EliminarEleccion(id);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Eliminó", "La Eleccion: " + this.txtDescripcion.Text);
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

        private void dgvElecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvElecciones.CurrentRow != null)
                {
                    this.txtIdEleccion.Text = this.dgvElecciones.CurrentRow.Cells[0].Value.ToString();
                    this.txtDescripcion.Text = this.dgvElecciones.CurrentRow.Cells[1].Value.ToString();
                    this.txtCargo.Text = this.dgvElecciones.CurrentRow.Cells[2].Value.ToString();                    
                    this.chkActivo.Checked = this.dgvElecciones.CurrentRow.Cells[3].Value.ToString() == "1" ? true : false;
                    this.dtpFechaRegistro.Value = (DateTime)this.dgvElecciones.CurrentRow.Cells[4].Value;//.ToString();
                    this.dtpFechaVotacion.Value = (DateTime)this.dgvElecciones.CurrentRow.Cells[5].Value;//.ToString();
                    var us = usuarioController.ObtenerUsuario(int.Parse(this.dgvElecciones.CurrentRow.Cells[8].Value.ToString()));
                    this.txtUsuarioCreador.Text = us.Nombres+" "+us.Apellidos;
                    this.pcbFoto.Image = bytesToImage((byte[])(this.dgvElecciones.CurrentRow.Cells[7].Value));


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Datos " + ex.Message, "Error");
            }
        }

        private void dgvElecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // se debe modificar el procedimiento almacenado en la columna con "Ver Funciones" as op
            if (e.RowIndex < 0 || e.ColumnIndex != dgvElecciones.Columns["op"].Index)
            {
                return;
            }
            else
            {
                int idEleccion = int.Parse(this.dgvElecciones.CurrentRow.Cells[0].Value.ToString());
                string cargo = this.dgvElecciones.CurrentRow.Cells[2].Value.ToString();
                FormListaDeCandidatos formListaDeCandidatos = new FormListaDeCandidatos(idEleccion,cargo);
                formListaDeCandidatos.ShowDialog();
                



            }
        }
    }
}
