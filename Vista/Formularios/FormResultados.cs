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
    public partial class FormResultados : Form
    {
        EleccionController eleccionController = new EleccionController();
        UsuarioController usuarioController = new UsuarioController();
        int porcentajeDeVotos = 0;
        public FormResultados()
        {
            InitializeComponent();
            cargarLista();
            cargarListaElecciones();
        }

        private void cargarListaElecciones()
        {
           
            this.cmbElecciones.DataSource = eleccionController.ListarElecciones("%");
            this.cmbElecciones.ValueMember = "idEleccion";
            this.cmbElecciones.DisplayMember = "cargo";
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

                        this.gunaCircleProgressBarPrimerPuesto.Value = this.dgvCandidatos.Rows[0].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[0].Cells[4].Value);
                        this.gunaCircleProgressBarSegundoPuesto.Value = this.dgvCandidatos.Rows[1].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[1].Cells[4].Value);
                        this.gunaCircleProgressBarTercerPuesto.Value = this.dgvCandidatos.Rows[2].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[2].Cells[4].Value);

                        this.pcbFotoPrimerPuesto.Image = bytesToImage((byte[])(this.dgvCandidatos.Rows[0].Cells[5].Value));
                        this.pcbFotoSegundoPuesto.Image = bytesToImage((byte[])(this.dgvCandidatos.Rows[1].Cells[5].Value));
                        this.pcbFotoTercerPuesto.Image = bytesToImage((byte[])(this.dgvCandidatos.Rows[2].Cells[5].Value));


                        this.porcentajeDeVotos= this.dgvCandidatos.Rows[0].Cells[4].Value == null ? 0 : Convert.ToInt32(this.dgvCandidatos.Rows[0].Cells[4].Value);
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

        private void btnFinalizarEleccion_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            resultado.PorcentajeVotos = this.porcentajeDeVotos;


            // crear el ResultadoController, ResultadoDao
            // crearResultado(resultado);

        }
        CandidatoController candidatoController = new CandidatoController();
        private void cmbElecciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idEleccion = int.Parse(this.cmbElecciones.SelectedValue.ToString());
              //  this.txtBuscarEleccion.Text = idEleccion.ToString();
                cargarCandidatos(idEleccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Candidatos " + ex.Message, "Error");
            }

        }
        private void cargarCandidatos(int idEleccion)
        {
            this.dgvCandidatos.DataSource = eleccionController.ListarResultados(idEleccion);//candidatoController.ListarCandidatosPorEleccion(idEleccion);
            cargarCantidadDeCandidatosPorEleccion(idEleccion);

        }
        private void cargarCantidadDeCandidatosPorEleccion(int idEleccion)
        {
            int cant = this.candidatoController.ObtenerCantidadCandidatosDeUnaEleccion(idEleccion);
            this.lblCantidad.Text = "CANTIDAD: "+cant.ToString();
            int canRestante = 10 - cant;
            if (cant<10)
            {   
                this.lblCantidadDeCandidatos.ForeColor = Color.Blue;
                this.lblCantidadDeCandidatos.Text = "CANTIDAD: " + cant.ToString();
                this.lblCantidadRestante.ForeColor = Color.Blue;
                this.lblCantidadRestante.Text = "Le quedan "+canRestante.ToString()+" espacios ";

            }
            else
            {
                if (cant==10)
                {
                    this.lblCantidadDeCandidatos.ForeColor = Color.Green;
                    this.lblCantidadDeCandidatos.Text = "CANTIDAD LIMITE: " + cant.ToString();
                    this.lblCantidadRestante.ForeColor = Color.Green;
                    this.lblCantidadRestante.Text = "Le quedan " + canRestante.ToString() + " espacios ";
                }
                else
                {
                    this.lblCantidadDeCandidatos.ForeColor = Color.Red;
                    this.lblCantidadDeCandidatos.Text = "No PUEDE AGREGAR MAS TAREAS";
                    this.lblCantidadRestante.ForeColor = Color.Red;
                    this.lblCantidadRestante.Text = canRestante.ToString();
                }

            }
           
        }
        
    }
}
