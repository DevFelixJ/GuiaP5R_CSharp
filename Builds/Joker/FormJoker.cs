using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.WinForms;
using Persona5Royal.Utilities;

namespace Persona5Royal.Builds.Joker
{
    public partial class FormJoker : Form
    {
        private WebView2 webView;
        public FormJoker()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormJoker_Load;
        }

        private void FormJoker_Load(object sender, EventArgs e)
        {
            string fileName = "BuildJoker.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();

        }
    }
}
