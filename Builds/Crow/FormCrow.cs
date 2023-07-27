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

namespace Persona5Royal.Builds.Crow
{
    public partial class FormCrow : Form
    {
        private WebView2 webView;
        public FormCrow()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormCrow_Load;
        }

        private void FormCrow_Load(object sender, EventArgs e)
        {
            string fileName = "BuildCrow.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();

        }
    }
}
