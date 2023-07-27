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

namespace Persona5Royal.Builds.Queen
{
    public partial class FormQueen : Form
    {
        private WebView2 webView;

        public FormQueen()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormQueen_Load;
        }

        private void FormQueen_Load(object sender, EventArgs e)
        {
            string fileName = "BuildQueen.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();
        }
    }
}
