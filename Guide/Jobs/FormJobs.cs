using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona5Royal.Guide.Jobs._777;
using Persona5Royal.Guide.Jobs.Florist;
using Persona5Royal.Guide.Jobs.Ramen;
using Persona5Royal.Utilities;

namespace Persona5Royal.Guide.Jobs
{
    public partial class FormJobs : Form
    {
        public FormJobs()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormJobs_FormClosing;
        }

        private void Btn777_Click(object sender, EventArgs e)
        {
            Form777 form777 = new Form777();
            form777.Show();
        }

        private void BtnFlorista_Click(object sender, EventArgs e)
        {
            FormFlorist formFlorist = new FormFlorist();
            formFlorist.Show();
        }

        private void BtnRamen_Click(object sender, EventArgs e)
        {
            FormRamen formRamen = new FormRamen();
            formRamen.Show();
            this.Hide();

        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormGuide().Show();
            this.Close();
        }

        private void FormJobs_Load(object sender, EventArgs e)
        {

        }
        // Evento FormClosing para abrir el formulario "FormGuide" cuando se cierre FormJobs
        private void FormJobs_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita que el evento se dispare mientras cambias al formulario "FormGuide"
            this.FormClosing -= FormJobs_FormClosing;

            // Abre el formulario "FormGuide"
            ReturnForms.GetFormGuide().Show();

            // Vuelve a agregar el evento para futuras ocasiones
            this.FormClosing += FormJobs_FormClosing;
        }
    }
}
