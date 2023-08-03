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

namespace Persona5Royal.Builds.Violet
{
    public partial class FormViolet : Form
    {
        private WebView2 webView;
        public FormViolet()
        {
            InitializeComponent();

            //Inicializar WebView
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormViolet_Load;

        }

        private void FormViolet_Load(object sender, EventArgs e)
        {
            string fileName = "BuildViolet.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();
        }

        private void WvViolet_Click(object sender, EventArgs e)
        {

        }
    }
}
