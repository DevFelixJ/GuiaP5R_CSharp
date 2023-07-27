using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Persona5Royal.Utilities;
using Persona5Royal.Guide.Calendar.SchemeMonths;


namespace Persona5Royal.Guide.Calendar
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormCalendar_FormClosing; 

        }



        private void BtnApril_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("AprilGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnMay_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("MayGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }

        }

        private void BtnJune_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("JuneGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnJuly_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("JulyGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }

        }

        private void BtnAugust_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("AugustGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnSeptember_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("SeptemberGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }

        }

        private void BtnOctober_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("OctoberGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }

        }

        private void BtnNovember_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("NovemberGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }

        }

        private void BtnDecember_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("DecemberGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }

        private void BtnJanuaryFebruary_Click(object sender, EventArgs e)
        {
            string url = UrlJson.GetGuideURLFromAppSettings("JanuaryFebruaryGuideURL");
            if (!string.IsNullOrEmpty(url))
            {
                UrlJson.OpenWebPage(url);
            }
        }
        private void BtnComplete_Click(object sender, EventArgs e)
        {
            FormSchemeMonths formSchemeMonths = new FormSchemeMonths();
            formSchemeMonths.Show();
        }
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ReturnForms.GetFormGuide().Show();
            this.Close();
        }

        private void FormCalendar_Load(object sender, EventArgs e)
        {

        }

        // Evento FormClosing para abrir el formulario "FormGuide" cuando se cierre FormCalendar
        private void FormCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita que el evento se dispare mientras cambias al formulario "FormGuide"
            this.FormClosing -= FormCalendar_FormClosing;

            // Abre el formulario "FormGuide"
            ReturnForms.GetFormGuide().Show();

            // Vuelve a agregar el evento para futuras ocasiones
            this.FormClosing += FormCalendar_FormClosing;
        }

        }
}
