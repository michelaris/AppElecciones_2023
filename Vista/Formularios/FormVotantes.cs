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

namespace Vista.Formularios
{
    public partial class FormVotantes : Form
    {
        VotanteController votanteController = new VotanteController();
        private string path="";
        public FormVotantes()
        {
            InitializeComponent();
            cargarLista();
            cargarListaElecciones();
            this.txtCreadoPorUsuario.Text = "Michel Zerpa"; //UsuarioCache.Nombres + " " + UsuarioCache.Apellidos;
        }
        private void cargarLista()
        {
            this.dgvVotantes.DataSource = votanteController.ListarVotantes("%");
        }
        private void cargarListaElecciones()
        {
            EleccionController eleccionController = new EleccionController();
            this.cmbEleccion.DataSource = eleccionController.ListarElecciones("%");
            this.cmbEleccion.ValueMember = "idEleccion";
            this.cmbEleccion.DisplayMember = "cargo";
        }
        private void limpiarCampos()
        {
            this.txtIdVotante.Text = "";
            this.txtDni.Text = "";
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";         
            this.chkActivo.Checked = false;
            this.dtpFechaRegistro.Value = DateTime.Now;
            this.chbEmitioVotacion.Checked = false;
            this.cmbEleccion.StartIndex = -1;// "Seleccione Eleccion...";
            this.txtCreadoPorUsuario.Text = "";            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombres.Text != null)
                {
                    string Rpta = "";
                    Votante vo = new Votante();
                    vo.DocumentoIdentidad = this.txtDni.Text;
                    vo.Nombres = this.txtNombres.Text;
                    vo.Apellidos = this.txtApellidos.Text;
                    vo.Activo = this.chkActivo.Checked;
                    vo.FechaRegistro = this.dtpFechaRegistro.Value;
                    vo.EmitioVotacion = this.chbEmitioVotacion.Checked;
                    vo.IdEleccion = int.Parse(this.cmbEleccion.SelectedValue.ToString());
                    vo.IdUsuario = 2;//UsuarioCache.IdUSuario;
                    
                    Rpta = votanteController.CrearVotante(vo);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Guardo", "El Votante: " + vo.Nombres + " " + vo.Apellidos);
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
                if (this.txtIdVotante.Text != "")
                {
                    string Rpta = "";
                    Votante vo = new Votante();
                    vo.IdVotante = int.Parse(this.txtIdVotante.Text);
                    vo.DocumentoIdentidad = this.txtDni.Text;
                    vo.Nombres = this.txtNombres.Text;
                    vo.Apellidos = this.txtApellidos.Text;
                    vo.Activo = this.chkActivo.Checked;
                    vo.FechaRegistro = this.dtpFechaRegistro.Value;
                    vo.EmitioVotacion = this.chbEmitioVotacion.Checked;
                    vo.IdEleccion = int.Parse(this.cmbEleccion.SelectedValue.ToString());
                    vo.IdUsuario = 2;//UsuarioCache.IdUSuario;
                    Rpta = votanteController.EditarVotante(vo);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Actualizo", "El Votante: " + vo.Nombres + " " + vo.Apellidos);
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
                if (this.txtIdVotante.Text != "")
                {
                    int id = int.Parse(this.txtIdVotante.Text);
                    string Rpta;
                    Rpta = votanteController.EliminarVotante(id);
                    if (Rpta.Equals("OK"))
                    {
                        //nEstadoguarda = 0;                        

                        /* MessageBox.Show("Los datos han sido guardados correctamente",
                                         "Aviso del Sistema",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        */
                        MensajeBox m = new MensajeBox("Eliminó", "El Votante: " + this.txtNombres.Text + " " + this.txtApellidos.Text);
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

        private void chbEmitioVotacion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbEmitioVotacion.Checked == true)
            {
                this.chbEmitioVotacion.Text = "SI";
                this.chbEmitioVotacion.ForeColor = Color.DarkGreen;
            }
            else
            {
                this.chbEmitioVotacion.Text = "NO";
                this.chbEmitioVotacion.ForeColor = Color.Red;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            string rta = "";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Abrir archivo de Excel";
            theDialog.Filter = "Excel files|*.xls;*xlsx";
            //theDialog.
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                path = theDialog.FileName;
                rta= votanteController.CargarListaDeVotantes(path);
                if (rta.Equals("OK"))
                {
                    MensajeBox m = new MensajeBox("Cargo", "La Lista de Votantes");
                    // m.ShowDialog();
                    DialogResult dg = m.ShowDialog();
                }
                else
                {
                    MensajeBox m = new MensajeBox("Cargo", "La Lista de Votantes NO");
                    // m.ShowDialog();
                    DialogResult dg = m.ShowDialog();
                }
            }
           
            

        }

        private void dgvVotantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvVotantes.CurrentRow != null)
                {
                    this.txtIdVotante.Text = this.dgvVotantes.CurrentRow.Cells[0].Value.ToString();
                    this.txtDni.Text = this.dgvVotantes.CurrentRow.Cells[1].Value.ToString();
                    this.txtNombres.Text = this.dgvVotantes.CurrentRow.Cells[2].Value.ToString();
                    this.txtApellidos.Text = this.dgvVotantes.CurrentRow.Cells[3].Value.ToString();                    
                    this.chkActivo.Checked = this.dgvVotantes.CurrentRow.Cells[4].Value.ToString() == "1" ? true : false;
                    this.dtpFechaRegistro.Value = (DateTime)this.dgvVotantes.CurrentRow.Cells[5].Value;
                    this.chbEmitioVotacion.Checked = this.dgvVotantes.CurrentRow.Cells[6].Value.ToString() == "1" ? true : false;
                    this.cmbEleccion.Text = this.dgvVotantes.CurrentRow.Cells[7].Value.ToString();
                    this.txtCreadoPorUsuario.Text = this.dgvVotantes.CurrentRow.Cells[8].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar Datos " + ex.Message, "Error");
            }
        }
    }
}
