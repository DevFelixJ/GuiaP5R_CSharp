using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persona5Royal.Confidents;
using Persona5Royal.Utilities;

namespace Persona5Royal.Confidents
{
    public partial class FormConfidents2 : Form
    {
        public FormConfidents2()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormConfidents2_FormClosing;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormConfidents1().Show();
            this.Hide();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FormMain.ReturnToMain();
            this.Close();
        }

        private void BtnChihaya_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("ChihayaConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnHifumi_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("HifumiConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnIchiko_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("IchikoConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnIwai_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("IwaiConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnSadayo_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("SadayoConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnShinya_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("ShinyaConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnTae_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("TaeConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnMaruki_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("MarukiConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnYoshida_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("YoshidaConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnJustineCaroline_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("JustineCarolineConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void FormConfidents2_Load(object sender, EventArgs e)
        {

        }
        // Evento FormClosing para abrir el formulario "FormMain" cuando se cierre FormConfidents2
        private void FormConfidents2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el formulario está siendo cerrado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Evita que el evento se dispare mientras cambias al formulario "FormMain"
                this.FormClosing -= FormConfidents2_FormClosing;

                // Abre el formulario "FormMain"
                FormMain.ReturnToMain();

                // Vuelve a agregar el evento para futuras ocasiones
                this.FormClosing += FormConfidents2_FormClosing;
            }
        }
    }
}
