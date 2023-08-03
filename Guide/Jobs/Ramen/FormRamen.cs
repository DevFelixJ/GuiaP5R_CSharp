using Persona5Royal.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona5Royal.Guide.Jobs.Ramen
{
    public partial class FormRamen : Form
    {
        public FormRamen()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormRamen_FormClosing;
        }

        private void LstFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRamen_Load(object sender, EventArgs e)
        {

        }
        // Evento FormClosing para abrir el formulario "FormGuide" cuando se cierre FormRamen
        private void FormRamen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita que el evento se dispare mientras cambias al formulario "FormGuide"
            this.FormClosing -= FormRamen_FormClosing;

            // Abre el formulario "FormGuide"
            ReturnForms.GetFormJobs().Show();

            // Vuelve a agregar el evento para futuras ocasiones
            this.FormClosing += FormRamen_FormClosing;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormJobs().Show();
            this.Close();
        }
    }
}
