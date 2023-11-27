using Controller;
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
    public partial class FormListaDeCandidatos : Form
    {
        CandidatoController candidatoController = new CandidatoController();

        public FormListaDeCandidatos()
        {
            InitializeComponent();
        }
        public FormListaDeCandidatos(int idEleccion, string cargo)
        {
            InitializeComponent();
            cargarLista(idEleccion);
            this.lblCargo.Text = "Candidat@s a "+cargo;
        }
        private void cargarLista(int idEleccion)
        {
            this.dgvCandidatos.DataSource = candidatoController.ListarCandidatosPorEleccion(idEleccion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
