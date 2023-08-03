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

namespace Persona5Royal.Builds.Panther
{
    public partial class FormPanther : Form
    {
        private WebView2 webview;
        public FormPanther()
        {
            InitializeComponent();

            //Inicializr WebView2
            webview = new WebView2();
            webview.Dock = DockStyle.Fill;
            this.Controls.Add(webview);
            this.Load += FormPanther_Load;
        }

        private void FormPanther_Load(object sender, EventArgs e)
        {
            string fileName = "BuildPanther.pdf";
            PdfUtils.OpenPdf(webview, fileName);
            webview.Focus();

        }
    }

}
