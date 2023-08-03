using Persona5Royal.Guide.Calendar;
using Persona5Royal.Guide.Crosswords;
using Persona5Royal.Guide.Jobs;
using Persona5Royal.Guide.Palaces;
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

namespace Persona5Royal.Guide
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormGuide_FormClosing;
        }

        private void FormGuide_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalendar_Click(object sender, EventArgs e)
        {
            FormCalendar formCalendar = new FormCalendar();
            formCalendar.Show();
            this.Hide();
        }

        private void BtnCrosswords_Click(object sender, EventArgs e)
        {
            FormCrosswords formCrosswords = new FormCrosswords();
            formCrosswords.Show();
            this.Hide();

        }

        private void BtnPalaces_Click(object sender, EventArgs e)
        {
            FormPalaces formPalaces = new FormPalaces();
            formPalaces.Show();
            this.Hide();
        }

        private void BtnJobs_Click(object sender, EventArgs e)
        {
            FormJobs formJobs = new FormJobs();
            formJobs.Show();
            this.Hide();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FormMain.ReturnToMain();
            this.Close();
        }
        // Evento FormClosing para abrir el formulario "FormMain" cuando se cierre FormGuide
        private void FormGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita que el evento se dispare mientras cambias al formulario "FormMain"
            this.FormClosing -= FormGuide_FormClosing;

            // Abre el formulario "FormMain"
            FormMain.ReturnToMain();

            // Vuelve a agregar el evento para futuras ocasiones
            this.FormClosing += FormGuide_FormClosing;
        }
    }
}
