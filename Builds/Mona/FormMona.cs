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

namespace Persona5Royal.Builds.Mona
{
    public partial class FormMona : Form
    {
        private WebView2 webView;
        public FormMona()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormMona_Load;
        }

        private void FormMona_Load(object sender, EventArgs e)
        {
            string fileName = "BuildMona.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();

        }
    }
}
