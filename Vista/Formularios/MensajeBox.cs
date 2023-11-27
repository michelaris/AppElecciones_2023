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
    public partial class MensajeBox : Form
    {
        public string Accion { get; set; }
        public MensajeBox()
        {
            InitializeComponent();
        }
        
        public MensajeBox(string accion, string msj)
        {
            this.Accion = accion;
            InitializeComponent();
            if (this.Accion != null)
            {
                this.lblMensaje.Text = $"{msj} se {accion} correctamente!";//"Usuario: " + this.Mensaje + " se Agrego Correctamente";// $"¡El Usuario: {mensaje} se Agrego Correctamente!";
            }
            else
            {
                this.lblMensaje.Text = "Error al recibir el mensaje";
            }

        }
       

        private void btnAceptarMsjBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
