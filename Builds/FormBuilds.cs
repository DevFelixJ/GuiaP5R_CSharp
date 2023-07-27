using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona5Royal.Builds.Crow;
using Persona5Royal.Builds.Fox;
using Persona5Royal.Builds.Joker;
using Persona5Royal.Builds.Mona;
using Persona5Royal.Builds.Noir;
using Persona5Royal.Builds.Oracle;
using Persona5Royal.Builds.Panther;
using Persona5Royal.Builds.Queen;
using Persona5Royal.Builds.Skull;
using Persona5Royal.Builds.Violet;
using Persona5Royal.Utilities;

namespace Persona5Royal.Builds
{
    public partial class FormBuilds : Form
    {
        public FormBuilds()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormBuilds_FormClosing;
        }

        private void BtnPanther_Click(object sender, EventArgs e)
        {
            FormPanther formPanther = new FormPanther();
            formPanther.Show();
        }

        private void BtnJoker_Click(object sender, EventArgs e)
        {
            FormJoker formJoker = new FormJoker();
            formJoker.Show();

        }

        private void BtnFox_Click(object sender, EventArgs e)
        {
            FormFox formFox = new FormFox();
            formFox.Show();
        }

        private void BtnSkull_Click(object sender, EventArgs e)
        {
            FormSkull formSkull = new FormSkull();
            formSkull.Show();
        }

        private void BtnMona_Click(object sender, EventArgs e)
        {
            FormMona formMona = new FormMona();
            formMona.Show();
        }

        private void BtnNoir_Click(object sender, EventArgs e)
        {
            FormNoir formNoir = new FormNoir();
            formNoir.Show();
        }

        private void BtnCrow_Click(object sender, EventArgs e)
        {
            FormCrow formCrow = new FormCrow();
            formCrow.Show();
        }

        private void BtnViolet_Click(object sender, EventArgs e)
        {
            FormViolet formViolet = new FormViolet();
            formViolet.Show();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FormMain.ReturnToMain();
            this.Close();
        }

        private void FormBuilds_Load(object sender, EventArgs e)
        {

        }

        // Evento FormClosing para abrir el formulario "FormMain" cuando se cierre FormBuilds
        private void FormBuilds_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el formulario está siendo cerrado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Evita que el evento se dispare mientras cambias al formulario "FormMain"
                this.FormClosing -= FormBuilds_FormClosing;

                // Abre el formulario "FormMain"
                FormMain.ReturnToMain();

                // Vuelve a agregar el evento para futuras ocasiones
                this.FormClosing += FormBuilds_FormClosing;
            }
        }
    }
}
