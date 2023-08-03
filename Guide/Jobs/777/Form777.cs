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

namespace Persona5Royal.Guide.Jobs._777
{
    public partial class Form777 : Form
    {
        private WebView2 webView;
        public Form777()
        {
            InitializeComponent();

            //Iniciar el WebView2
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);


            this.Load += Form777_Load;

        }

        private void Form777_Load(object sender, EventArgs e)
        {
            string fileName = "777.pdf";
            PdfUtils.OpenPdf(webView, fileName);
            webView.Focus();

        }
        private void Wv777_Click(object sender, EventArgs e)
        {

        }
    }
}
