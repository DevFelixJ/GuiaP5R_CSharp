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

namespace Persona5Royal.Builds.Oracle
{
    public partial class FormOracle : Form
    {
        private WebView2 webView;
        public FormOracle()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormOracle_Load;
        }

        private void FormOracle_Load(object sender, EventArgs e)
        {
            string fileName = "BuildOracle.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();
        }
    }
}
