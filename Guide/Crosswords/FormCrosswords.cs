using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Persona5Royal.Utilities;
namespace Persona5Royal.Guide.Crosswords
{
    public partial class FormCrosswords : Form
    {
        private WebView2 webView;
        public FormCrosswords()
        {
            InitializeComponent();
            // Configura el evento FormClosing
            this.FormClosing += FormCrosswords_FormClosing;

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormCrosswords_Load;
        }
        private void FormCrosswords_Load(object sender, EventArgs e)
        {
            string fileName = "Crosswords.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();
        }
        private void WvCrosswords_Click(object sender, EventArgs e)
        {

        }

        private void FormCrosswords_Load_1(object sender, EventArgs e)
        {

        }

        // Evento FormClosing para abrir el formulario "FormGuide" cuando se cierre FormCrosswords
        private void FormCrosswords_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Evita que el evento se dispare mientras cambias al formulario "FormGuide"
            this.FormClosing -= FormCrosswords_FormClosing;

            // Abre el formulario "FormGuide"
            ReturnForms.GetFormGuide().Show();

            // Vuelve a agregar el evento para futuras ocasiones
            this.FormClosing += FormCrosswords_FormClosing;
        }

    }
}
