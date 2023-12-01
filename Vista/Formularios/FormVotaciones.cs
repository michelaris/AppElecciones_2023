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
    public partial class FormVotaciones : Form
    {   VotanteController votanteController = new VotanteController();
        EleccionController eleccionController = new EleccionController();
        CandidatoController candidatoController = new CandidatoController();
        VotacionController votacionController = new VotacionController();
        public FormVotaciones()
        {
            InitializeComponent();
            cargarDatos();
            cargarListaCandidatos(VotanteCache.IdEleccion);

        }
        private void cargarDatos()
        {
            this.txtIdVotante.Text = VotanteCache.IdVotante.ToString();
            this.txtDni.Text = VotanteCache.DocumentoIdentidad;
            this.txtNombres.Text = VotanteCache.Nombres;
            this.txtApellidos.Text = VotanteCache.Apellidos;
            this.chkActivo.Checked = VotanteCache.Activo;
            this.dtpFechaRegistro.Value = VotanteCache.FechaRegistro;
            this.chbEmitioVotacion.Checked = VotanteCache.EmitioVotacion;
            var eleccion=eleccionController.ObtenerEleccion(VotanteCache.IdEleccion);
            this.txtEleccionCargo.Text = eleccion.Cargo;

            this.lblFechaDeEleccion.Text = "Fecha de Eleccion: "+eleccion.FechaVotacion.ToString("dd MMMM , yyyy");
            if (VotanteCache.EmitioVotacion==true)
            {
                this.btnEmitirVotacion.Text = "Actualizar Voto";
            }
            
        }
        private void cargarListaCandidatos(int idEleccion)
        {
            this.dgvCandidatos.DataSource = candidatoController.listarCandidatosPorEleccionParaVotante(idEleccion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void chbEmitioVotacion_CheckedChanged(object sender, EventArgs e)
        {

            if (this.chbEmitioVotacion.Checked == true)
            {
                this.chbEmitioVotacion.Text = "SI";
                this.chbEmitioVotacion.ForeColor = Color.FromArgb(56, 201, 255);
            }
            else
            {
                this.chbEmitioVotacion.Text = "NO";
                this.chbEmitioVotacion.ForeColor = Color.OrangeRed;
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkActivo.Checked == true)
            {
                this.chkActivo.Text = "Activo";
                this.chkActivo.ForeColor = Color.FromArgb(56, 201, 255);
            }
            else
            {
                this.chkActivo.Text = "Inactivo";
                this.chkActivo.ForeColor = Color.OrangeRed;
            }
        }

        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // se debe modificar el procedimiento almacenado en la columna con "Ver Funciones" as op
            if (e.RowIndex < 0 || e.ColumnIndex != dgvCandidatos.Columns["op"].Index)
            {
                return;
            }
            else
            {
                int idCandidato = int.Parse(this.dgvCandidatos.CurrentRow.Cells[0].Value.ToString());
                var candidato = candidatoController.ObtenerCandidato(idCandidato);
                this.txtIdCandidato.Text = candidato.IdCandidato.ToString();
                this.txtNombresCandidato.Text = candidato.Nombres;
                this.txtApellidosCandidatos.Text = candidato.Apellidos;
                this.txtMensajeCandidato.Text = candidato.Mensaje;
                this.pcbFotoCandidato.Image = bytesToImage((byte[])(this.dgvCandidatos.CurrentRow.Cells[4].Value));
                




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

        private void btnEmitirVotacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombres.Text != null )

                {
                    string Rpta = "";
                    Votacion vo = new Votacion();
                    if (VotanteCache.EmitioVotacion!=true) // se agrego para, solo puede emitir una sola ves votacion
                    {
                        
                        vo.FechaRegistro = this.dtpFechaRegistro.Value;
                        //var eleccion = eleccionController.ObtenerEleccion(VotanteCache.IdEleccion);
                        vo.IdEleccion = VotanteCache.IdEleccion;
                        vo.IdVotante = VotanteCache.IdVotante;
                        vo.IdCandidato = int.Parse(this.txtIdCandidato.Text);
                        Rpta = votacionController.CrearVotancion(vo);
                        if (Rpta.Equals("OK"))
                        {                           
                            var rest = votanteController.EditarVotante_EmitioVotacion(VotanteCache.IdVotante, true);
                            if (rest.Equals("OK"))
                            {
                                MensajeBox m = new MensajeBox("Realizo Votacion", "El Usuario: " + VotanteCache.Nombres + " " + VotanteCache.Apellidos);
                                DialogResult dg = m.ShowDialog();
                                this.chbEmitioVotacion.ForeColor = Color.GreenYellow;
                                this.chbEmitioVotacion.Text = "SI";
                                this.chbEmitioVotacion.Checked = true;
                            }     
                        }
                        else
                        {
                            MessageBox.Show(Rpta,
                                            "Aviso del Sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        vo = votacionController.ObtenerVotancionXIdVotante(VotanteCache.IdVotante);
                     
                       // vo.FechaRegistro = this.dtpFechaRegistro.Value;
                        //var eleccion = eleccionController.ObtenerEleccion(VotanteCache.IdEleccion);
                        vo.IdEleccion = VotanteCache.IdEleccion;
                        vo.IdVotante = VotanteCache.IdVotante;
                        vo.IdCandidato = int.Parse(this.txtIdCandidato.Text);
                        Rpta = votacionController.EditarVotancion(vo);
                        if (Rpta.Equals("OK"))
                        {
                            var rest = votanteController.EditarVotante_EmitioVotacion(VotanteCache.IdVotante, true);
                            if (rest.Equals("OK"))
                            {
                                MensajeBox m = new MensajeBox("Actualizo Votacion", "El Usuario: " + VotanteCache.Nombres + " " + VotanteCache.Apellidos);
                                DialogResult dg = m.ShowDialog();
                                this.chbEmitioVotacion.ForeColor = Color.GreenYellow;
                                this.chbEmitioVotacion.Text = "SI";
                                this.chbEmitioVotacion.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show(Rpta,
                                            "Aviso del Sistema",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Votante", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }
    }
}
