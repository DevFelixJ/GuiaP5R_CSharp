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

namespace Persona5Royal.Guide.Jobs.Florist
{
    public partial class FormFlorist : Form
    {
        private WebView2 webView;
        public FormFlorist()
        {
            InitializeComponent();

            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormFlorist_Load;
        }

        private void FormFlorist_Load(object sender, EventArgs e)
        {
            string fileName = "Florist.pdf";
            PdfUtils.OpenPdf (webView,  fileName);
            webView.Focus();
        }

        private void WvFlorist_Click(object sender, EventArgs e)
        {

        }
    }
}
