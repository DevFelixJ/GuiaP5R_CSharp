using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona5Royal.Utilities;

namespace Persona5Royal.Guide.Palaces
{
    public partial class FormPalaces : Form
    {
        public FormPalaces()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormPalaces_FormClosing;
        }

        private void BtnKamoshida_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("KamoshidaPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }

        }

        private void BtnMadarame_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("MadaramePalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnKaneshiro_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("KaneshiroPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnAlibaba_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("AlibabaPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnOkumura_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("OkumuraPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnNijima_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("NijimaPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnShido_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("ShidoPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnInterrogation_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("InterrogationPalaceGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormGuide().Show();
            this.Close();
        }

        private void FormPalaces_Load(object sender, EventArgs e)
        {

        }
        
        // Evento FormClosing para abrir el formulario "FormGuide" cuando se cierre FormPalaces
        private void FormPalaces_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita que el evento se dispare mientras cambias al formulario "FormGuide"
            this.FormClosing -= FormPalaces_FormClosing;

            // Abre el formulario "FormGuide"
            ReturnForms.GetFormGuide().Show();

            // Vuelve a agregar el evento para futuras ocasiones
            this.FormClosing += FormPalaces_FormClosing;
        }
    }
    
}
