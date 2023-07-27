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

namespace Persona5Royal.Guide.Calendar.SchemeMonths
{
    public partial class FormSchemeMonths : Form
    {
        private WebView2 webView;
        public FormSchemeMonths()
        {
            InitializeComponent();

            //Iniciar el WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            this.Load += FormSchemeMonths_Load;
        }

        private void WvSchemeMonths_Click(object sender, EventArgs e)
        {


        }

        private void FormSchemeMonths_Load(object sender, EventArgs e)
        {
            string fileName = "Calendar.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();
        }
    }
}
