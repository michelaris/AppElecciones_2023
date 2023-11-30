using Controller;
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
    public partial class FormResultados : Form
    {
        EleccionController eleccionController = new EleccionController();
        UsuarioController usuarioController = new UsuarioController();
        public FormResultados()
        {
            InitializeComponent();
            cargarLista();
        }
        private void cargarLista()
        {
            this.dgvElecciones.DataSource = eleccionController.ListarEleccionesConVotacion("%");
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
                cargarResultados(idEleccion);
/*
                string cargo = this.dgvElecciones.CurrentRow.Cells[2].Value.ToString();
                FormListaDeCandidatos formListaDeCandidatos = new FormListaDeCandidatos(idEleccion, cargo);
                formListaDeCandidatos.ShowDialog();*/
            }
        }

        private void cargarResultados(int idEleccion)
        {
            this.dgvCandidatos.DataSource = eleccionController.ListarResultados(idEleccion);
            mostrarPorcentajes();
        }
        private void mostrarPorcentajes()
        {
            try
            {
                if (this.dgvCandidatos.CurrentRow != null)
                {
                    
                    if (this.dgvCandidatos.Rows[0].Cells[4].Value!=null & this.dgvCandidatos.Rows[1].Cells[4].Value != null & this.dgvCandidatos.Rows[2].Cells[4].Value != null)
                    {
                        /*this.gunaCircleProgressBarPrimerPuesto.Value = Convert.ToInt32(this.dgvCandidatos.Rows[0].Cells[4].Value);
                        this.gunaCircleProgressBarSegundoPuesto.Value = Convert.ToInt32(this.dgvCandidatos.Rows[1].Cells[4].Value);
                        this.gunaCircleProgressBarTercerPuesto.Value = Convert.ToInt32(this.dgvCandidatos.Rows[2].Cells[4].Value);*/
                        this.gunaCircleProgressBarPrimerPuesto.Value = this.dgvCandidatos.Rows[0].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[0].Cells[4].Value);
                        this.gunaCircleProgressBarSegundoPuesto.Value = this.dgvCandidatos.Rows[1].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[1].Cells[4].Value);
                        this.gunaCircleProgressBarTercerPuesto.Value = this.dgvCandidatos.Rows[2].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[2].Cells[4].Value);

                        // this.pcbFotoPrimerPuesto.Image=bytesToImage((byte[])(this.dgvCandidatos.CurrentRow.Cells[5].Value));
                        this.pcbFotoPrimerPuesto.Image = bytesToImage((byte[])(this.dgvCandidatos.Rows[0].Cells[5].Value));
                        this.pcbFotoSegundoPuesto.Image = bytesToImage((byte[])(this.dgvCandidatos.Rows[1].Cells[5].Value));
                        this.pcbFotoTercerPuesto.Image = bytesToImage((byte[])(this.dgvCandidatos.Rows[2].Cells[5].Value));
                    }
                    else
                    {
                        MessageBox.Show("No posee Votos cargados ", "Error");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Datos " + ex.Message, "Error");
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

        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvCandidatos.CurrentRow != null)
                {
                    this.txtCantidadDeVotos.Text =this.dgvCandidatos.CurrentRow.Cells[3].Value.ToString();
                    this.txtNombresCandidato.Text = this.dgvCandidatos.CurrentRow.Cells[1].Value.ToString();
                    this.txtApellidosCandidatos.Text = this.dgvCandidatos.CurrentRow.Cells[2].Value.ToString();
                    this.txtPorcentajeObtenido.Text = this.dgvCandidatos.CurrentRow.Cells[4].Value.ToString();
                    this.pcbFotoCandidato.Image= bytesToImage((byte[])(this.dgvCandidatos.CurrentRow.Cells[5].Value));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
