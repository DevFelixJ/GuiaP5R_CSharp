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

namespace Persona5Royal.Builds.Skull
{
    public partial class FormSkull : Form
    {
        private WebView2 webView;
        public FormSkull()
        {
            InitializeComponent();

            //Inicializar WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormSkull_Load;
        }

        private void FormSkull_Load(object sender, EventArgs e)
        {
            string fileName = "BuildSkull.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();
        }

        private void WvSkull_Click(object sender, EventArgs e)
        {

        }
    }
}
