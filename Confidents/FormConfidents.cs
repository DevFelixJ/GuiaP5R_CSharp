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
    public partial class FormConfidents1 : Form
    {
        public FormConfidents1()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormConfidents1_FormClosing;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormConfidents2().Show();
            this.Hide();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FormMain.ReturnToMain();
            this.Close();

        }

        private void BtnRyuji_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("RyujiConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnAnn_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("AnnConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnYusuke_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("YusukeConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnMakoto_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("MakotoConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnFutaba_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("FutabaConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnHaru_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("HaruConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnAkechi_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("AkechiConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnKasumi_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("KasumiConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnSojiro_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("SojiroConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnMishima_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("MishimaConfidantURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void FormConfidents1_Load(object sender, EventArgs e)
        {

        }

        // Evento FormClosing para abrir el formulario "FormMain" cuando se cierre FormConfidents1
        private void FormConfidents1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si el formulario está siendo cerrado por el usuario
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Evita que el evento se dispare mientras cambias al formulario "FormMain"
                this.FormClosing -= FormConfidents1_FormClosing;

                // Abre el formulario "FormMain"
                FormMain.ReturnToMain();

                // Vuelve a agregar el evento para futuras ocasiones
                this.FormClosing += FormConfidents1_FormClosing;
            }
        }
    }
}
