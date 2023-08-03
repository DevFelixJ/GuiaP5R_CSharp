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
using Persona5Royal.Persona.Compendium;

namespace Persona5Royal.Persona
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormPersona_FormClosing;
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("CalculadoraPersonaURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnCompendium_Click(object sender, EventArgs e)
        {
            FormCompendium formCompendium = new FormCompendium();
            formCompendium.Show();
            


        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FormMain.ReturnToMain();
            this.Close();
        }

        // Evento FormClosing para abrir el formulario "FormMain" cuando se cierre FormPersona
        private void FormPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el formulario está siendo cerrado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Evita que el evento se dispare mientras cambias al formulario "FormMain"
                this.FormClosing -= FormPersona_FormClosing;

                // Abre el formulario "FormMain"
                FormMain.ReturnToMain();

                // Vuelve a agregar el evento para futuras ocasiones
                this.FormClosing += FormPersona_FormClosing;
            }
        }
    }
}
